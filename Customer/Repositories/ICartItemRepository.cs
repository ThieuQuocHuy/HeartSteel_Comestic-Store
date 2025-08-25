using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Models;

namespace Customer.Repositories
{
    public interface ICartItemRepository
    {
        Task<List<CartItem>> GetCartItemsByUserIdAsync(int userId);
        Task<CartItem?> GetCartItemByUserIdAndProductIdAsync(int userId, int productId);
        Task<bool> AddCartItemAsync(CartItem cartItem);
        Task<bool> UpdateCartItemAsync(CartItem cartItem);
        Task<bool> RemoveCartItemAsync(int cartItemId);
        Task<bool> ClearUserCartAsync(int userId);
        Task<int> GetCartItemCountAsync(int userId);
    }
}
