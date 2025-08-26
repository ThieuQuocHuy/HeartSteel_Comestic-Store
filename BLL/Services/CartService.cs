using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Repositories;
using DAL.Models;

namespace BLL.Services
{
    public class CartService : ICartService
    {
        private readonly ICartItemRepository _cartItemRepository;
        private readonly IProductRepository _productRepository;

        public CartService()
        {
            _cartItemRepository = new CartItemRepository();
            _productRepository = new ProductRepository();
        }

        public async Task<bool> AddToCartAsync(int userId, int productId, int quantity)
        {
            try
            {
                if (userId <= 0)
                {
                    throw new InvalidOperationException("User chưa đăng nhập hoặc userId không hợp lệ");
                }
                // Kiểm tra sản phẩm có tồn tại không
                var product = await _productRepository.GetByIdAsync(productId);
                if (product == null)
                {
                    throw new InvalidOperationException($"Sản phẩm với ID {productId} không tồn tại!");
                }

                // Kiểm tra số lượng tồn kho
                if (product.ProductInStock < quantity)
                {
                    throw new InvalidOperationException($"Tồn kho không đủ! Có {product.ProductInStock} nhưng cần {quantity}");
                }

                // Kiểm tra sản phẩm đã có trong giỏ hàng chưa
                var existingCartItem = await _cartItemRepository.GetCartItemByUserIdAndProductIdAsync(userId, productId);

                if (existingCartItem != null)
                {
                    // Nếu đã có, cập nhật số lượng
                    var newQuantity = existingCartItem.Quantity + quantity;
                    if (product.ProductInStock < newQuantity)
                    {
                        throw new InvalidOperationException($"Tồn kho không đủ sau khi cộng! Có {product.ProductInStock} nhưng cần {newQuantity}");
                    }

                    // Cập nhật số lượng trực tiếp
                    existingCartItem.Quantity = newQuantity;
                    var updateResult = await _cartItemRepository.UpdateCartItemAsync(existingCartItem);
                    
                    // Log success if needed
                    return updateResult;
                }
                else
                {
                    // Tạo mới CartItem
                    var newCartItem = new CartItem
                    {
                        UserId = userId,
                        ProductId = productId,
                        Quantity = quantity,
                        CreatedAt = DateTime.Now
                    };

                    var addResult = await _cartItemRepository.AddCartItemAsync(newCartItem);
                    // Log success if needed
                    return addResult;
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Lỗi thêm vào giỏ hàng: {ex.Message}", ex);
            }
        }

        public async Task<bool> UpdateCartItemQuantityAsync(int userId, int productId, int newQuantity)
        {
            try
            {
                var cartItem = await _cartItemRepository.GetCartItemByUserIdAndProductIdAsync(userId, productId);
                if (cartItem == null)
                {
                    return false;
                }

                // Kiểm tra số lượng tồn kho
                var product = await _productRepository.GetByIdAsync(productId);
                if (product != null && product.ProductInStock < newQuantity)
                {
                    return false;
                }

                cartItem.Quantity = newQuantity;

                return await _cartItemRepository.UpdateCartItemAsync(cartItem);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> RemoveFromCartAsync(int userId, int productId)
        {
            try
            {
                var cartItem = await _cartItemRepository.GetCartItemByUserIdAndProductIdAsync(userId, productId);
                if (cartItem == null)
                {
                    return false;
                }

                return await _cartItemRepository.RemoveCartItemAsync(cartItem.CartId);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<CartItem>> GetUserCartAsync(int userId)
        {
            try
            {
                return await _cartItemRepository.GetCartItemsByUserIdAsync(userId);
            }
            catch (Exception)
            {
                return new List<CartItem>();
            }
        }

        

        public async Task<bool> ClearCartAsync(int userId)
        {
            try
            {
                return await _cartItemRepository.ClearUserCartAsync(userId);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<int> GetCartItemCountAsync(int userId)
        {
            try
            {
                return await _cartItemRepository.GetCartItemCountAsync(userId);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public async Task<decimal> GetCartTotalAsync(int userId)
        {
            try
            {
                var cartItems = await _cartItemRepository.GetCartItemsByUserIdAsync(userId);
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
