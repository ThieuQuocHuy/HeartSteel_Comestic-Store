using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Repositories
{
    public interface IUserRepository
    {
        Task<User?> AuthenticateAsync(string username, string password);
        Task<User?> GetByIdAsync(int userId);
        Task<bool> CreateUserAsync(User user);
        Task<List<User>> GetAllAsync();
    }
}
