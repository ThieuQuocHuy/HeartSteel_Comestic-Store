using System.Threading.Tasks;
using DAL.Models;

namespace BLL.Services
{
    public interface IAuthService
    {
        Task<(bool success, User? user, string message)> LoginAsync(string username, string password);
        Task<bool> IsAdminAsync(int userId);
        Task<bool> IsCustomerAsync(int userId);
        void Logout();
        User? GetCurrentUser();
    }
}
