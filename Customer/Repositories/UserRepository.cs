using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Customer.Repositories
{
    public class UserRepository : IUserRepository
    {
        public async Task<User?> AuthenticateAsync(string username, string password)
        {
            try
            {
                using var db = new shopdbContext();
                var hashedPassword = HashPassword(password);
                
                return await db.Users
                    .Include(u => u.Role)
                    .AsNoTracking()
                    .FirstOrDefaultAsync(u => 
                        u.Username == username && 
                        u.PasswordHash == hashedPassword);
            }
            catch
            {
                return null;
            }
        }

        public async Task<User?> GetByIdAsync(int userId)
        {
            try
            {
                using var db = new shopdbContext();
                return await db.Users
                    .Include(u => u.Role)
                    .AsNoTracking()
                    .FirstOrDefaultAsync(u => u.UserId == userId);
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> CreateUserAsync(User user)
        {
            try
            {
                using var db = new shopdbContext();
                user.PasswordHash = HashPassword(user.PasswordHash); // Giả sử PasswordHash chứa plain password
                db.Users.Add(user);
                await db.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(hashedBytes);
        }
    }
}
