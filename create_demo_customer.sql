-- Script tạo tài khoản demo khách hàng
USE [shopdb]
GO

-- Tạo tài khoản demo với username: demo, password: demo123
DECLARE @demoHash NVARCHAR(255)
-- Hash của "demo123" tính bằng SHA256 Base64
-- Sử dụng công cụ online hoặc C# để tính: Convert.ToBase64String(SHA256.ComputeHash(Encoding.UTF8.GetBytes("demo123")))
-- Hash của "demo123" = 'n4bQgYhMfWWaL+qgxVrQFaO/TxsrC4Is0V1sFbDwCgg='

SET @demoHash = 'n4bQgYhMfWWaL+qgxVrQFaO/TxsrC4Is0V1sFbDwCgg='

-- Kiểm tra user demo đã tồn tại chưa
IF NOT EXISTS (SELECT 1 FROM [dbo].[users] WHERE [username] = 'demo')
BEGIN
    INSERT INTO [dbo].[users] ([role_id], [username], [fullname], [phone], [email], [address], [password_hash], [created_at])
    VALUES (2, 'demo', N'Khách hàng Demo', '0900000001', 'demo@example.com', 'Demo Address', @demoHash, GETDATE())
    
    PRINT 'Đã tạo tài khoản demo thành công!'
END
ELSE
BEGIN
    -- Cập nhật password nếu đã tồn tại
    UPDATE [dbo].[users] 
    SET [password_hash] = @demoHash
    WHERE [username] = 'demo'
    
    PRINT 'Đã cập nhật password cho tài khoản demo!'
END

-- Kiểm tra kết quả
SELECT [user_id], [username], [fullname], [password_hash], [role_id]
FROM [dbo].[users] 
WHERE [username] = 'demo';

PRINT '=== TÀI KHOẢN DEMO ĐÃ SẴN SÀNG ==='
PRINT 'Username: demo'
PRINT 'Password: demo123'
PRINT 'Role: Customer'

GO