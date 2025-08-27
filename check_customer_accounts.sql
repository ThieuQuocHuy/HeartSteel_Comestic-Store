-- Script kiểm tra thông tin tài khoản khách hàng
USE [shopdb]
GO

-- Xem tất cả tài khoản khách hàng
SELECT 
    u.[user_id],
    u.[username],
    u.[fullname],
    u.[email],
    u.[phone],
    u.[password_hash],
    LEN(u.[password_hash]) as hash_length,
    r.[role_name]
FROM [dbo].[users] u
INNER JOIN [dbo].[roles] r ON u.[role_id] = r.[role_id]
WHERE r.[role_name] = 'Customer'
ORDER BY u.[user_id];

-- Thông tin chi tiết
PRINT '=== DANH SÁCH TÀI KHOẢN KHÁCH HÀNG ==='
PRINT 'Username: tuancuong | Fullname: Dang Ho Tuan Cuong'
PRINT 'Username: huy | Fullname: thieu quoc huy'
PRINT 'Username: minhtuan | Fullname: nguyen minh tuan'
PRINT ''
PRINT 'ĐỂ VÀO GIAO DIỆN KHÁCH HÀNG:'
PRINT '1. Thử đăng nhập với username ở trên + password của họ'
PRINT '2. Hoặc tạo tài khoản mới qua nút "Đăng ký"'
PRINT '3. Hoặc test với tài khoản demo (nếu có)'

GO