-- Script khắc phục mật khẩu admin cho ứng dụng (HASH CHÍNH XÁC)
USE [shopdb]
GO

-- Cập nhật mật khẩu admin với hash CHÍNH XÁC từ ứng dụng
UPDATE [dbo].[users] 
SET [password_hash] = 'JAvlGPq9JyTdtvBO6x2llnRI1+gxwIyPqCKAn3TMIKk=' -- Hash CHÍNH XÁC (MIKk thay vì KIKk)
WHERE [username] = 'admin';

-- Kiểm tra kết quả
SELECT [user_id], [username], [fullname], [password_hash], [role_id]
FROM [dbo].[users] 
WHERE [username] = 'admin';

-- Kiểm tra tất cả users và roles
SELECT u.[user_id], u.[username], u.[fullname], r.[role_name]
FROM [dbo].[users] u
INNER JOIN [dbo].[roles] r ON u.[role_id] = r.[role_id]
ORDER BY u.[user_id];

-- Thông báo thành công
PRINT 'Password "admin123" được hash thành: JAvlGPq9JyTdtvBO6x2llnRI1+gxwIyPqCKAn3TMIKk='
PRINT 'User admin đã được cập nhật mật khẩu CHÍNH XÁC thành công!'
PRINT 'Hash đã sửa lỗi typo: MIKk (đúng) thay vì KIKk (sai)'
PRINT 'Giờ có thể đăng nhập với: admin/admin123'

GO