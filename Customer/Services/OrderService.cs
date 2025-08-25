using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Customer.Repositories;
using DAL.Models;

namespace Customer.Services
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
                    return false;
                }

                // Tạo Order mới
                var order = new Order
                {
                    UserId = userId,
                    OrderDate = DateTime.Now,
                    OrderTotal = await CalculateOrderTotalAsync(cartItems),
                    ShippingAddress = shippingAddress
                };

                // Tạo OrderDetails từ CartItems
                var orderDetails = new List<OrderDetail>();
                foreach (var cartItem in cartItems)
                {
                    var orderDetail = new OrderDetail
                    {
                        ProductId = cartItem.ProductId,
                        Quantity = cartItem.Quantity,
                        Price = (cartItem.Product?.SellPrice ?? 0) * cartItem.Quantity
                    };
                    orderDetails.Add(orderDetail);
                }

                order.OrderDetails = orderDetails;

                // Lưu Order vào database
                var success = await _orderRepository.CreateOrderAsync(order);
                if (success)
                {
                    // Xóa giỏ hàng sau khi tạo order thành công
                    await _cartService.ClearCartAsync(userId);
                }

                return success;
            }
            catch (Exception)
            {
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
