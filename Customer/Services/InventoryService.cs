using Customer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Customer.Services
{
    public class InventoryService
    {
        private readonly ProductService _productService;

        public InventoryService()
        {
            try
            {
                _productService = new ProductService();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Lỗi khởi tạo ProductService: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Xử lý bán hàng - giảm số lượng tồn kho
        /// </summary>
        public bool ProcessSale(int productId, int quantity, out string errorMessage)
        {
            errorMessage = string.Empty;
            
            try
            {
                if (_productService == null)
                {
                    errorMessage = "ProductService chưa được khởi tạo!";
                    return false;
                }

                var product = _productService.GetProductById(productId);

                if (product == null)
                {
                    errorMessage = "Không tìm thấy sản phẩm!";
                    return false;
                }

                if (!product.IsActive)
                {
                    errorMessage = "Sản phẩm không còn kinh doanh!";
                    return false;
                }

                if (!product.CanSell(quantity))
                {
                    errorMessage = $"Không đủ hàng trong kho! Hiện tại chỉ còn {product.Stock} sản phẩm.";
                    return false;
                }

                // Giảm số lượng tồn kho
                return _productService.UpdateStock(productId, -quantity);
            }
            catch (Exception ex)
            {
                errorMessage = $"Lỗi xử lý bán hàng: {ex.Message}";
                return false;
            }
        }

        /// <summary>
        /// Xử lý nhập hàng - tăng số lượng tồn kho
        /// </summary>
        public bool ProcessRestock(int productId, int quantity, out string errorMessage)
        {
            errorMessage = string.Empty;
            
            try
            {
                if (_productService == null)
                {
                    errorMessage = "ProductService chưa được khởi tạo!";
                    return false;
                }

                var product = _productService.GetProductById(productId);

                if (product == null)
                {
                    errorMessage = "Không tìm thấy sản phẩm!";
                    return false;
                }

                if (quantity <= 0)
                {
                    errorMessage = "Số lượng nhập phải lớn hơn 0!";
                    return false;
                }

                // Tăng số lượng tồn kho
                return _productService.UpdateStock(productId, quantity);
            }
            catch (Exception ex)
            {
                errorMessage = $"Lỗi xử lý nhập hàng: {ex.Message}";
                return false;
            }
        }

        /// <summary>
        /// Lấy danh sách sản phẩm sắp hết hàng
        /// </summary>
        public List<Product> GetLowStockProducts(int threshold = 10)
        {
            try
            {
                if (_productService == null)
                {
                    return new List<Product>();
                }

                var activeProducts = _productService.GetActiveProducts();
                if (activeProducts == null)
                {
                    return new List<Product>();
                }

                return activeProducts
                    .Where(p => p != null && p.Stock <= threshold)
                    .OrderBy(p => p.Stock)
                    .ToList();
            }
            catch (Exception ex)
            {
                // Log error (in a real app, use proper logging)
                System.Diagnostics.Debug.WriteLine($"Error in GetLowStockProducts: {ex.Message}");
                return new List<Product>();
            }
        }

        /// <summary>
        /// Lấy báo cáo tồn kho
        /// </summary>
        public InventoryReport GetInventoryReport()
        {
            try
            {
                if (_productService == null)
                {
                    return new InventoryReport
                    {
                        TotalProducts = 0,
                        TotalValue = 0,
                        LowStockCount = 0,
                        OutOfStockCount = 0,
                        HighestStockProduct = null,
                        LowestStockProduct = null
                    };
                }

                var products = _productService.GetActiveProducts();
                if (products == null)
                {
                    return new InventoryReport
                    {
                        TotalProducts = 0,
                        TotalValue = 0,
                        LowStockCount = 0,
                        OutOfStockCount = 0,
                        HighestStockProduct = null,
                        LowestStockProduct = null
                    };
                }

                // Filter out null products
                var validProducts = products.Where(p => p != null).ToList();

                return new InventoryReport
                {
                    TotalProducts = validProducts.Count,
                    TotalValue = validProducts.Sum(p => p.Price * p.Stock),
                    LowStockCount = validProducts.Count(p => p.Stock < 10),
                    OutOfStockCount = validProducts.Count(p => p.Stock == 0),
                    HighestStockProduct = validProducts.OrderByDescending(p => p.Stock).FirstOrDefault(),
                    LowestStockProduct = validProducts.Where(p => p.Stock > 0).OrderBy(p => p.Stock).FirstOrDefault()
                };
            }
            catch (Exception ex)
            {
                // Log error (in a real app, use proper logging)
                System.Diagnostics.Debug.WriteLine($"Error in GetInventoryReport: {ex.Message}");
                return new InventoryReport
                {
                    TotalProducts = 0,
                    TotalValue = 0,
                    LowStockCount = 0,
                    OutOfStockCount = 0,
                    HighestStockProduct = null,
                    LowestStockProduct = null
                };
            }
        }
    }

    public class InventoryReport
    {
        public int TotalProducts { get; set; }
        public decimal TotalValue { get; set; }
        public int LowStockCount { get; set; }
        public int OutOfStockCount { get; set; }
        public Product? HighestStockProduct { get; set; }
        public Product? LowestStockProduct { get; set; }
    }
}