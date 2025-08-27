-- Script để cập nhật mật khẩu admin
-- Mật khẩu sẽ là "admin123" được hash bằng SHA256

USE [shopdb]
GO

-- Hash của "admin123" bằng SHA256: 240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9
-- Nhưng repository sử dụng Base64, nên chúng ta cần chuyển đổi

-- Cập nhật mật khẩu admin
UPDATE [dbo].[users] 
SET [password_hash] = 'sPJJaGAfP3I3PbF5SuW0fPRiEh0+eIj6Xo8tLRE2n+E=' -- "admin123" trong SHA256 Base64
WHERE [username] = 'admin';

-- Kiểm tra kết quả
SELECT [user_id], [username], [fullname], [password_hash], [role_id]
FROM [dbo].[users] 
WHERE [username] = 'admin';

GO