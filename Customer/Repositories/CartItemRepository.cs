using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Customer.Repositories
{
    public class CartItemRepository : ICartItemRepository
    {
        private readonly shopdbContext _context;

        public CartItemRepository()
        {
            _context = new shopdbContext();
        }

        public async Task<List<CartItem>> GetCartItemsByUserIdAsync(int userId)
        {
            try
            {
                return await _context.CartItems
                    .Include(ci => ci.Product)
                    .Where(ci => ci.UserId == userId)
                    .ToListAsync();
            }
            catch (Exception)
            {
                return new List<CartItem>();
            }
        }

        public async Task<CartItem?> GetCartItemByUserIdAndProductIdAsync(int userId, int productId)
        {
            try
            {
                return await _context.CartItems
                    .Include(ci => ci.Product)
                    .FirstOrDefaultAsync(ci => ci.UserId == userId && ci.ProductId == productId);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<bool> AddCartItemAsync(CartItem cartItem)
        {
            try
            {
                cartItem.CreatedAt = DateTime.Now;
                _context.CartItems.Add(cartItem);
                var result = await _context.SaveChangesAsync();
                return result > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdateCartItemAsync(CartItem cartItem)
        {
            try
            {
                // Sử dụng raw SQL để tránh entity tracking conflict
                var sql = "UPDATE cart_items SET quantity = @quantity WHERE cart_id = @cartId";
                var parameters = new[] 
                {
                    new Microsoft.Data.SqlClient.SqlParameter("@quantity", cartItem.Quantity),
                    new Microsoft.Data.SqlClient.SqlParameter("@cartId", cartItem.CartId)
                };

                var result = await _context.Database.ExecuteSqlRawAsync(sql, parameters);
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi cập nhật CartItem: {ex.Message}\nStackTrace: {ex.StackTrace}", "Debug Repository Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<bool> UpdateCartItemQuantityAsync(int cartId, int newQuantity)
        {
            try
            {
                var cartItem = await _context.CartItems.FindAsync(cartId);
                if (cartItem != null)
                {
                    cartItem.Quantity = newQuantity;
                    var result = await _context.SaveChangesAsync();
                    return result > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi cập nhật số lượng CartItem: {ex.Message}\nStackTrace: {ex.StackTrace}", "Debug Repository Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<bool> RemoveCartItemAsync(int cartItemId)
        {
            try
            {
                var cartItem = await _context.CartItems.FindAsync(cartItemId);
                if (cartItem != null)
                {
                    _context.CartItems.Remove(cartItem);
                    var result = await _context.SaveChangesAsync();
                    return result > 0;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> ClearUserCartAsync(int userId)
        {
            try
            {
                var cartItems = await _context.CartItems
                    .Where(ci => ci.UserId == userId)
                    .ToListAsync();

                if (cartItems.Any())
                {
                    _context.CartItems.RemoveRange(cartItems);
                    var result = await _context.SaveChangesAsync();
                    return result > 0;
                }
                return true;
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
                return await _context.CartItems
                    .Where(ci => ci.UserId == userId)
                    .SumAsync(ci => ci.Quantity);
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
