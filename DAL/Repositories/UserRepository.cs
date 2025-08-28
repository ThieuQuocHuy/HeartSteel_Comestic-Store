using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
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

        public async Task<List<User>> GetCustomersAsync(string? keyword = null)
        {
            try
            {
                using var db = new shopdbContext();
                var query = db.Users
                .Include(u => u.Role)
                .AsNoTracking()
                .Where(u => u.Role.RoleName == "Customer");
                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    var kw = keyword.Trim().ToLower();
                    query = query.Where(u =>
                    u.Username.ToLower().Contains(kw) ||
                    u.Fullname.ToLower().Contains(kw) ||
                    u.Email.ToLower().Contains(kw) ||
                    u.Phone.ToLower().Contains(kw));
                }
                return await query
                .OrderByDescending(u => u.CreatedAt)
                .ToListAsync();
            }
            catch
            {
                return new List<User>();
            }
        }

        public async Task<bool> UpdateUserAsync(User user)
        {
            try
            {
                using var db = new shopdbContext();
                db.Users.Update(user);
                var result = await db.SaveChangesAsync();
                return result > 0;
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> DeleteUserAsync(int userId)
        {
            try
            {
                using var db = new shopdbContext();
                var user = await db.Users.FindAsync(userId);
                if (user == null) return false;
                db.Users.Remove(user);
                var result = await db.SaveChangesAsync();
                return result > 0;
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
