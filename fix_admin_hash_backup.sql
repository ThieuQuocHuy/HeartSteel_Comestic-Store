-- Script cập nhật mật khẩu admin với hash từ UserRepository
USE [shopdb]
GO

-- Test hash của "admin123" bằng C# (SHA256 + Base64)
-- Hash này được tính bằng C#: Convert.ToBase64String(SHA256.ComputeHash(Encoding.UTF8.GetBytes("admin123")))

DECLARE @correctHash NVARCHAR(255)
-- Hash của "admin123" tính bằng UserRepository method
SET @correctHash = 'JAvlGPq9JyTdtvBO6x2llnRI1+gxwIyPqCKAn3TMIKk='

-- Cập nhật user admin
UPDATE [dbo].[users] 
SET [password_hash] = @correctHash
WHERE [username] = 'admin';

-- Kiểm tra kết quả
SELECT [user_id], [username], [fullname], [password_hash], [role_id]
FROM [dbo].[users] 
WHERE [username] = 'admin';

-- Thông báo
PRINT 'Đã cập nhật hash password cho admin!'
PRINT 'Hash sử dụng: ' + @correctHash
PRINT 'Thử đăng nhập: admin/admin123'

GO