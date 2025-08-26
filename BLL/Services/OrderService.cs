using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using DAL.Repositories;
using DAL.Models;

namespace BLL.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ICartService _cartService;

        public OrderService()
        {
            _orderRepository = new OrderRepository();
            _cartService = new CartService();
        }

        public async Task<Order?> GetOrderByIdAsync(int orderId)
        {
            try
            {
                return await _orderRepository.GetByIdAsync(orderId);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<List<Order>> GetUserOrdersAsync(int userId)
        {
            try
            {
                return await _orderRepository.GetOrdersByUserIdAsync(userId);
            }
            catch (Exception)
            {
                return new List<Order>();
            }
        }

        public async Task<bool> CreateOrderFromCartAsync(int userId, List<CartItem> cartItems, string shippingAddress)
        {
            try
            {
                if (cartItems == null || cartItems.Count == 0)
                {
                    System.Diagnostics.Trace.WriteLine("[ORDER] Fail: cartItems null/empty");
                    return false;
                }

                using var context = new DAL.Models.shopdbContext();
                using var transaction = await context.Database.BeginTransactionAsync();

                // Kiểm tra và cập nhật tồn kho (trong cùng transaction)
                var productIds = cartItems.Select(ci => ci.ProductId).Distinct().ToList();
                var products = await context.Products
                    .Where(p => productIds.Contains(p.ProductId))
                    .ToListAsync();

                var quantityByProductId = cartItems
                    .GroupBy(ci => ci.ProductId)
                    .ToDictionary(g => g.Key, g => g.Sum(ci => ci.Quantity));

                foreach (var product in products)
                {
                    var qty = quantityByProductId[product.ProductId];
                    System.Diagnostics.Trace.WriteLine($"[TX-INV] productId={product.ProductId}, stock={product.ProductInStock}, sold={product.SoldCount}, orderQty={qty}");
                    if (product.ProductInStock < qty)
                    {
                        System.Diagnostics.Trace.WriteLine($"[TX-INV] Fail: not enough stock for productId={product.ProductId}");
                        return false;
                    }
                    product.ProductInStock -= qty;
                    product.SoldCount += qty;
                    // Đánh dấu modified để chắc chắn EF theo dõi cập nhật
                    context.Products.Update(product);
                }

                // Tạo Order mới (trong cùng DbContext)
                var order = new Order
                {
                    UserId = userId,
                    OrderDate = DateTime.Now,
                    OrderTotal = await CalculateOrderTotalAsync(cartItems),
                    ShippingAddress = shippingAddress
                };

                var orderDetails = new List<OrderDetail>();
                foreach (var cartItem in cartItems)
                {
                    var price = (cartItem.Product?.SellPrice ?? 0) * cartItem.Quantity;
                    orderDetails.Add(new OrderDetail
                    {
                        ProductId = cartItem.ProductId,
                        Quantity = cartItem.Quantity,
                        Price = price
                    });
                }
                order.OrderDetails = orderDetails;

                context.Orders.Add(order);
                var saved = await context.SaveChangesAsync();
                System.Diagnostics.Trace.WriteLine($"[TX] SaveChanges affected={saved}");
                if (saved <= 0)
                {
                    System.Diagnostics.Trace.WriteLine("[TX] Fail: SaveChanges <= 0");
                    return false;
                }

                await transaction.CommitAsync();

                // Xóa giỏ hàng sau khi commit
                var cleared = await _cartService.ClearCartAsync(userId);
                System.Diagnostics.Trace.WriteLine($"[ORDER] ClearCart result={cleared}");
                return true;
            }
            catch (Exception)
            {
                System.Diagnostics.Trace.WriteLine("[ORDER] Exception in CreateOrderFromCartAsync");
                return false;
            }
        }

        private static async Task<bool> UpdateProductInventoryAsync(List<CartItem> cartItems)
        {
            try
            {
                using var context = new DAL.Models.shopdbContext();

                // Tập hợp các sản phẩm cần cập nhật
                var productIds = cartItems.Select(ci => ci.ProductId).Distinct().ToList();
                var products = await context.Products
                    .Where(p => productIds.Contains(p.ProductId))
                    .ToListAsync();

                // Ánh xạ productId -> quantity đã bán trong đơn này
                var quantityByProductId = cartItems
                    .GroupBy(ci => ci.ProductId)
                    .ToDictionary(g => g.Key, g => g.Sum(ci => ci.Quantity));

                foreach (var product in products)
                {
                    var qty = quantityByProductId[product.ProductId];
                    System.Diagnostics.Trace.WriteLine($"[INV] productId={product.ProductId}, stock={product.ProductInStock}, sold={product.SoldCount}, orderQty={qty}");
                    // Kiểm tra tồn kho trước khi trừ
                    if (product.ProductInStock < qty)
                    {
                        System.Diagnostics.Trace.WriteLine($"[INV] Fail: not enough stock for productId={product.ProductId}");
                        return false;
                    }

                    product.ProductInStock -= qty;
                    product.SoldCount += qty;
                }

                var saved = await context.SaveChangesAsync();
                System.Diagnostics.Trace.WriteLine($"[INV] SaveChanges affected={saved}");
                return saved > 0;
            }
            catch
            {
                System.Diagnostics.Trace.WriteLine("[INV] Exception while updating inventory");
                return false;
            }
        }

        private static async Task<bool> RevertProductInventoryAsync(List<CartItem> cartItems)
        {
            try
            {
                using var context = new DAL.Models.shopdbContext();
                var productIds = cartItems.Select(ci => ci.ProductId).Distinct().ToList();
                var products = await context.Products
                    .Where(p => productIds.Contains(p.ProductId))
                    .ToListAsync();

                var quantityByProductId = cartItems
                    .GroupBy(ci => ci.ProductId)
                    .ToDictionary(g => g.Key, g => g.Sum(ci => ci.Quantity));

                foreach (var product in products)
                {
                    var qty = quantityByProductId[product.ProductId];
                    product.ProductInStock += qty;
                    product.SoldCount = product.SoldCount - qty < 0 ? 0 : product.SoldCount - qty;
                }

                var saved = await context.SaveChangesAsync();
                System.Diagnostics.Trace.WriteLine($"[INV-REVERT] SaveChanges affected={saved}");
                return saved > 0;
            }
            catch
            {
                System.Diagnostics.Trace.WriteLine("[INV-REVERT] Exception while reverting inventory");
                return false;
            }
        }

        public async Task<bool> UpdateOrderStatusAsync(int orderId, string newStatus)
        {
            try
            {
                // Tạo OrderStatus mới thay vì update trực tiếp
                var orderStatus = new OrderStatus
                {
                    OrderId = orderId,
                    Status = newStatus,
                    ChangedAt = DateTime.Now
                };

                // Thêm vào context và save
                using (var context = new DAL.Models.shopdbContext())
                {
                    context.OrderStatuses.Add(orderStatus);
                    var result = await context.SaveChangesAsync();
                    return result > 0;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> CancelOrderAsync(int orderId)
        {
            try
            {
                // Tạo OrderStatus mới với trạng thái "Cancelled"
                var orderStatus = new OrderStatus
                {
                    OrderId = orderId,
                    Status = "Cancelled",
                    ChangedAt = DateTime.Now
                };

                // Thêm vào context và save
                using (var context = new DAL.Models.shopdbContext())
                {
                    context.OrderStatuses.Add(orderStatus);
                    var result = await context.SaveChangesAsync();
                    return result > 0;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<decimal> CalculateOrderTotalAsync(List<CartItem> cartItems)
        {
            try
            {
                decimal total = 0;
                foreach (var cartItem in cartItems)
                {
                    if (cartItem.Product?.SellPrice.HasValue == true)
                    {
                        total += cartItem.Product.SellPrice.Value * cartItem.Quantity;
                    }
                }
                return total;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
