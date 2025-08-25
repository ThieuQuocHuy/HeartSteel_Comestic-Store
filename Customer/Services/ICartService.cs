using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Models;

namespace Customer.Services
{
    public interface ICartService
    {
        Task<bool> AddToCartAsync(int userId, int productId, int quantity);
        Task<bool> UpdateCartItemQuantityAsync(int userId, int productId, int newQuantity);
        Task<bool> RemoveFromCartAsync(int userId, int productId);
        Task<List<CartItem>> GetUserCartAsync(int userId);
        Task<bool> ClearCartAsync(int userId);
        Task<int> GetCartItemCountAsync(int userId);
        Task<decimal> GetCartTotalAsync(int userId);
    }
}
