using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Repositories;
using DAL.Models;

namespace BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService()
        {
            _userRepository = new UserRepository();
        }
        public Task<List<User>> GetCustomersAsync(string? keyword = null)
        {
            return _userRepository.GetCustomersAsync(keyword);
        }
        public Task<User?> GetByIdAsync(int userId)
        {
            return _userRepository.GetByIdAsync(userId);
        }
        public Task<bool> UpdateAsync(User user)
        {
            return _userRepository.UpdateUserAsync(user);
        }
        public Task<bool> DeleteAsync(int userId)
        {
            return _userRepository.DeleteUserAsync(userId);
        }
    }
}