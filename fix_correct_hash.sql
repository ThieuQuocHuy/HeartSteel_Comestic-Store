-- Script sửa hash với giá trị CHÍNH XÁC từ debug log
USE [shopdb]
GO

-- Cập nhật với hash CHÍNH XÁC từ ứng dụng (chữ H, không phải M)
UPDATE [dbo].[users] 
SET [password_hash] = 'JAvlGPq9JyTdtvBO6x2llnRI1+gxwIyPqCKAn3THIKk=' -- Chú ý: HIKk (không phải MIKk)
WHERE [username] = 'admin';

-- Kiểm tra kết quả
SELECT [user_id], [username], [fullname], 
       [password_hash],
       LEN([password_hash]) as hash_length
FROM [dbo].[users] 
WHERE [username] = 'admin';

-- So sánh với hash tính toán
PRINT 'DB Hash:     JAvlGPq9JyTdtvBO6x2llnRI1+gxwIyPqCKAn3TMIKk= (cũ - sai)'
PRINT 'App Hash:    JAvlGPq9JyTdtvBO6x2llnRI1+gxwIyPqCKAn3THIKk= (mới - đúng)'
PRINT 'Khác biệt ở vị trí 41: M vs H'
PRINT 'Đã cập nhật hash CHÍNH XÁC cho admin!'

GO