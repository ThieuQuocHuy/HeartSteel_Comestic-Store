using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Models;
namespace BLL.Services
{
    public interface IUserService
    {
        Task<List<User>> GetCustomersAsync(string? keyword = null);
        Task<User?> GetByIdAsync(int userId);
        Task<bool> UpdateAsync(User user);
        Task<bool> DeleteAsync(int userId);
    }
}