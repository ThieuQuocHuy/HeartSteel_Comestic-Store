using System;
using System.Threading.Tasks;
using Customer.Repositories;
using DAL.Models;

namespace Customer.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private User? _currentUser;

        public AuthService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<(bool success, User? user, string message)> LoginAsync(string username, string password)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    return (false, null, "Vui lòng nhập đầy đủ thông tin đăng nhập");
                }

                var user = await _userRepository.AuthenticateAsync(username, password);
                if (user == null)
                {
                    return (false, null, "Tên đăng nhập hoặc mật khẩu không đúng");
                }

                _currentUser = user;
                return (true, user, "Đăng nhập thành công");
            }
            catch (Exception ex)
            {
                return (false, null, $"Lỗi đăng nhập: {ex.Message}");
            }
        }

        public async Task<bool> IsAdminAsync(int userId)
        {
            try
            {
                var user = await _userRepository.GetByIdAsync(userId);
                return user?.Role?.RoleName?.ToLower() == "admin";
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> IsCustomerAsync(int userId)
        {
            try
            {
                var user = await _userRepository.GetByIdAsync(userId);
                return user?.Role?.RoleName?.ToLower() == "customer" || user?.Role?.RoleName?.ToLower() == "user";
            }
            catch
            {
                return false;
            }
        }

        public void Logout()
        {
            _currentUser = null;
        }

        public User? GetCurrentUser()
        {
            return _currentUser;
        }
    }
}
