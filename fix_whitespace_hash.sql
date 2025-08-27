-- Script khắc phục whitespace trong password hash
USE [shopdb]
GO

-- Cập nhật để loại bỏ whitespace thừa
UPDATE [dbo].[users] 
SET [password_hash] = RTRIM(LTRIM([password_hash]))
WHERE [username] = 'admin';

-- Set lại hash chính xác (không có whitespace)
UPDATE [dbo].[users] 
SET [password_hash] = 'JAvlGPq9JyTdtvBO6x2llnRI1+gxwIyPqCKAn3TMIKk='
WHERE [username] = 'admin';

-- Kiểm tra kết quả
SELECT [user_id], [username], [fullname], 
       [password_hash],
       LEN([password_hash]) as hash_length,
       ASCII(LEFT([password_hash], 1)) as first_char_ascii,
       ASCII(RIGHT([password_hash], 1)) as last_char_ascii
FROM [dbo].[users] 
WHERE [username] = 'admin';

-- Thông báo
PRINT 'Đã xóa whitespace và cập nhật hash cho admin!'
PRINT 'Hash length should be 44 characters'

GO