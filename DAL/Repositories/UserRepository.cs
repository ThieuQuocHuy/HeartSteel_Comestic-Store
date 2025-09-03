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
                System.Diagnostics.Debug.WriteLine($"[AUTH] Starting AuthenticateAsync");
                System.Diagnostics.Debug.WriteLine($"[AUTH] Username: {username}");
                System.Diagnostics.Debug.WriteLine($"[AUTH] Password: {password}");

                var hashedPassword = HashPassword(password);
                System.Diagnostics.Debug.WriteLine($"[AUTH] Hashed: {hashedPassword}");

                System.Diagnostics.Debug.WriteLine($"[AUTH] Creating database context...");
                using var db = new shopdbContext();

                System.Diagnostics.Debug.WriteLine($"[AUTH] Testing database connection...");

                // Test connection trước
                try
                {
                    await db.Database.CanConnectAsync();
                    System.Diagnostics.Debug.WriteLine($"[AUTH] ✅ Database connection successful");
                }
                catch (Exception connEx)
                {
                    System.Diagnostics.Debug.WriteLine($"[AUTH] ❌ Database connection failed: {connEx.Message}");
                    return null;
                }

                System.Diagnostics.Debug.WriteLine($"[AUTH] Checking if user exists...");

                // Kiểm tra user có tồn tại không
                var userExists = await db.Users.AnyAsync(u => u.Username == username);
                System.Diagnostics.Debug.WriteLine($"[AUTH] User exists: {userExists}");

                if (userExists)
                {
                    System.Diagnostics.Debug.WriteLine($"[AUTH] Getting user details...");
                    var user = await db.Users.FirstOrDefaultAsync(u => u.Username == username);
                    if (user != null)
                    {
                        // TRIM whitespace từ database password hash
                        var dbHashTrimmed = user.PasswordHash?.Trim();

                        System.Diagnostics.Debug.WriteLine($"[AUTH] Found user: {user.Username}");
                        System.Diagnostics.Debug.WriteLine($"[AUTH] DB Password Hash (raw): '{user.PasswordHash}'");
                        System.Diagnostics.Debug.WriteLine($"[AUTH] DB Password Hash (trimmed): '{dbHashTrimmed}'");
                        System.Diagnostics.Debug.WriteLine($"[AUTH] Calculated Hash: '{hashedPassword}'");
                        System.Diagnostics.Debug.WriteLine($"[AUTH] Raw hash length: {user.PasswordHash?.Length ?? 0}");
                        System.Diagnostics.Debug.WriteLine($"[AUTH] Trimmed hash length: {dbHashTrimmed?.Length ?? 0}");
                        System.Diagnostics.Debug.WriteLine($"[AUTH] Calculated hash length: {hashedPassword.Length}");
                        System.Diagnostics.Debug.WriteLine($"[AUTH] Hash match (raw): {user.PasswordHash == hashedPassword}");
                        System.Diagnostics.Debug.WriteLine($"[AUTH] Hash match (trimmed): {dbHashTrimmed == hashedPassword}");
                    }
                }

                System.Diagnostics.Debug.WriteLine($"[AUTH] Performing final authentication query with TRIM...");

                // SỬA: Sử dụng SQL TRIM để loại bỏ whitespace
                var result = await db.Users
                    .Include(u => u.Role)
                    .AsNoTracking()
                    .Where(u => u.Username == username)
                    .Where(u => u.PasswordHash.Trim() == hashedPassword)
                    .FirstOrDefaultAsync();

                System.Diagnostics.Debug.WriteLine($"[AUTH] Query result: {(result != null ? "SUCCESS" : "FAILED")}");

                if (result != null)
                {
                    System.Diagnostics.Debug.WriteLine($"[AUTH] ✅ Login successful for user: {result.Username} (ID: {result.UserId})");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"[AUTH] ❌ Login failed - no matching user found");
                }

                return result;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"[AUTH] ❌ Exception occurred: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"[AUTH] Stack trace: {ex.StackTrace}");
                return null;
            }
        }

        public async Task<List<User>> GetAllAsync()
        {
            using var db = new shopdbContext();
            return await db.Users
                .Include(u => u.Role)
                .AsNoTracking()
                .ToListAsync();
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
                user.PasswordHash = HashPassword(user.PasswordHash); 
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
