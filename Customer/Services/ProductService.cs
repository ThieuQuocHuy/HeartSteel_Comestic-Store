using Customer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Customer.Services
{
    public class ProductService
    {
        private static List<Product> _products = new List<Product>();
        private static int _nextId = 1;

        static ProductService()
        {
            // Dữ liệu mẫu
            InitializeSampleData();
        }

        private static void InitializeSampleData()
        {
            _products.AddRange(new List<Product>
            {
                // Son môi
                new Product(_nextId++, "Son Môi Rouge Luxury", "Son môi màu đỏ sang trọng, lâu trôi", 250000, 45, "Son môi"),
                new Product(_nextId++, "Son Môi Pink Velvet", "Son môi hồng nhung mềm mại", 220000, 8, "Son môi"), // Sắp hết hàng
                new Product(_nextId++, "Son Môi Coral Sunset", "Son môi cam san hô tự nhiên", 280000, 35, "Son môi"),
                new Product(_nextId++, "Son Môi Classic Red", "Son môi đỏ cổ điển thanh lịch", 300000, 2, "Son môi"), // Sắp hết hàng
                
                // Kem nền
                new Product(_nextId++, "Kem Nền BB Cream Natural", "Kem nền tự nhiên che khuyết điểm", 350000, 25, "Kem nền"),
                new Product(_nextId++, "Kem Nền Full Coverage", "Kem nền che phủ hoàn hảo", 420000, 30, "Kem nền"),
                new Product(_nextId++, "Kem Nền Light Touch", "Kem nền nhẹ mát, không bí da", 380000, 5, "Kem nền"), // Sắp hết hàng
                
                // Mascara
                new Product(_nextId++, "Mascara Volume Max", "Mascara tạo độ dày tối đa cho lông mi", 180000, 40, "Mascara"),
                new Product(_nextId++, "Mascara Lengthening", "Mascara làm dài lông mi", 200000, 7, "Mascara"), // Sắp hết hàng
                new Product(_nextId++, "Mascara Waterproof", "Mascara chống nước", 250000, 0, "Mascara"), // Hết hàng
                
                // Phấn phủ
                new Product(_nextId++, "Phấn Phủ Mịn Màng", "Phấn phủ kiềm dầu lâu trôi", 200000, 50, "Phấn phủ"),
                new Product(_nextId++, "Phấn Phủ Trong Suốt", "Phấn phủ trong suốt tự nhiên", 180000, 15, "Phấn phủ"),
                new Product(_nextId++, "Phấn Phủ Compact", "Phấn phủ nén tiện lợi", 220000, 3, "Phấn phủ"), // Sắp hết hàng
                
                // Skincare
                new Product(_nextId++, "Nước Hoa Hồng Dưỡng Ẩm", "Nước hoa hồng cân bằng độ ẩm", 150000, 60, "Skincare"),
                new Product(_nextId++, "Serum Vitamin C", "Serum dưỡng sáng da với Vitamin C", 450000, 25, "Skincare"),
                new Product(_nextId++, "Kem Dưỡng Ẩm Ban Đêm", "Kem dưỡng ẩm phục hồi ban đêm", 380000, 9, "Skincare"), // Sắp hết hàng
                new Product(_nextId++, "Sữa Rửa Mặt Gentle", "Sữa rửa mặt dịu nhẹ cho mọi loại da", 120000, 35, "Skincare"),
                
                // Tẩy trang
                new Product(_nextId++, "Nước Tẩy Trang Micellar", "Nước tẩy trang làm sạch hoàn hảo", 180000, 42, "Tẩy trang"),
                new Product(_nextId++, "Dầu Tẩy Trang Deep Clean", "Dầu tẩy trang làm sạch sâu", 220000, 6, "Tẩy trang"), // Sắp hết hàng
                new Product(_nextId++, "Khăn Tẩy Trang Gentle", "Khăn tẩy trang dịu nhẹ", 80000, 55, "Tẩy trang"),
                
                // Kem dưỡng
                new Product(_nextId++, "Kem Dưỡng Mặt SPF 30", "Kem dưỡng có chống nắng", 320000, 28, "Kem dưỡng"),
                new Product(_nextId++, "Kem Dưỡng Mắt Anti-Age", "Kem dưỡng mắt chống lão hóa", 480000, 1, "Kem dưỡng"), // Sắp hết hàng
                new Product(_nextId++, "Kem Dưỡng Thể Luxury", "Kem dưỡng thể cao cấp", 250000, 38, "Kem dưỡng"),
                
                // Serum
                new Product(_nextId++, "Serum Hyaluronic Acid", "Serum cấp ẩm tức thì", 520000, 20, "Serum"),
                new Product(_nextId++, "Serum Retinol Night", "Serum retinol dùng ban đêm", 680000, 4, "Serum"), // Sắp hết hàng
                new Product(_nextId++, "Serum Niacinamide", "Serum thu nhỏ lỗ chân lông", 380000, 32, "Serum")
            });
        }

        public List<Product> GetAllProducts()
        {
            return _products.ToList();
        }

        public List<Product> GetActiveProducts()
        {
            return _products.Where(p => p.IsActive).ToList();
        }

        public Product? GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public List<Product> SearchProducts(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return GetActiveProducts();

            return _products.Where(p => p.IsActive && 
                (p.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                 p.Category.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                 p.Description.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)))
                .ToList();
        }

        public bool AddProduct(Product product)
        {
            try
            {
                product.Id = _nextId++;
                product.CreatedDate = DateTime.Now;
                product.UpdatedDate = DateTime.Now;
                _products.Add(product);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateProduct(Product product)
        {
            try
            {
                var existingProduct = GetProductById(product.Id);
                if (existingProduct == null) return false;

                existingProduct.Name = product.Name;
                existingProduct.Description = product.Description;
                existingProduct.Price = product.Price;
                existingProduct.Stock = product.Stock;
                existingProduct.Category = product.Category;
                existingProduct.ImagePath = product.ImagePath;
                existingProduct.IsActive = product.IsActive;
                existingProduct.UpdatedDate = DateTime.Now;

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteProduct(int id)
        {
            try
            {
                var product = GetProductById(id);
                if (product == null) return false;

                // Soft delete - chỉ đánh dấu là không hoạt động
                product.IsActive = false;
                product.UpdatedDate = DateTime.Now;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateStock(int productId, int quantity)
        {
            try
            {
                var product = GetProductById(productId);
                if (product == null) return false;

                product.UpdateStock(quantity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<string> GetCategories()
        {
            return _products.Where(p => p.IsActive)
                           .Select(p => p.Category)
                           .Distinct()
                           .OrderBy(c => c)
                           .ToList();
        }

        public int GetTotalProducts() => _products.Count(p => p.IsActive);
        public int GetLowStockCount() => _products.Count(p => p.IsActive && p.Stock < 10);
        public decimal GetTotalInventoryValue() => _products.Where(p => p.IsActive).Sum(p => p.Price * p.Stock);
    }
}