using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public ProductRepository()
        {
        }

        public async Task<IReadOnlyList<Product>> GetAllAsync()
        {
            using var db = new shopdbContext();
            return await db.Products
                .AsNoTracking()
                .Include(p => p.Category)
                .ToListAsync();
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            using var db = new shopdbContext();
            return await db.Products
                .AsNoTracking()
                .Include(p => p.Category)
                .Include(p => p.Status)
                .FirstOrDefaultAsync(p => p.ProductId == id);
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            using var db = new shopdbContext();
            return await db.Products
                .AsNoTracking()
                .Include(p => p.Category)
                .OrderBy(p => p.ProductName)
                .ToListAsync();
        }

        public async Task<Product?> GetProductByIdAsync(int productId)
        {
            using var db = new shopdbContext();
            return await db.Products
                .AsNoTracking()
                .Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.ProductId == productId);
        }

        public async Task<bool> CreateProductAsync(Product product)
        {
            try
            {
                using var db = new shopdbContext();
                
                // Remove navigation properties to avoid conflicts
                product.Category = null;
                product.Status = null;
                
                db.Products.Add(product);
                var result = await db.SaveChangesAsync();
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> UpdateProductAsync(Product product)
        {
            try
            {
                using var db = new shopdbContext();
                
                var existingProduct = await db.Products.FindAsync(product.ProductId);
                if (existingProduct == null)
                {
                    return false;
                }

                // Update properties
                existingProduct.ProductName = product.ProductName;
                existingProduct.CategoryId = product.CategoryId;
                existingProduct.StockPrice = product.StockPrice;
                existingProduct.SellPrice = product.SellPrice;
                existingProduct.ProductInStock = product.ProductInStock;
                existingProduct.Description = product.Description;

                var result = await db.SaveChangesAsync();
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DeleteProductAsync(int productId)
        {
            try
            {
                using var db = new shopdbContext();
                
                var product = await db.Products.FindAsync(productId);
                if (product == null)
                {
                    return false;
                }

                // Check if product is used in any orders or cart items
                var hasOrderDetails = await db.OrderDetails.AnyAsync(od => od.ProductId == productId);
                var hasCartItems = await db.CartItems.AnyAsync(ci => ci.ProductId == productId);

                if (hasOrderDetails || hasCartItems)
                {
                    // Soft delete - just mark as inactive or set stock to 0
                    product.ProductInStock = 0;
                    // You could add an IsActive field for soft delete instead
                }
                else
                {
                    // Hard delete
                    db.Products.Remove(product);
                }

                var result = await db.SaveChangesAsync();
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<Product>> GetProductsByCategoryAsync(int categoryId)
        {
            using var db = new shopdbContext();
            return await db.Products
                .AsNoTracking()
                .Include(p => p.Category)
                .Where(p => p.CategoryId == categoryId)
                .OrderBy(p => p.ProductName)
                .ToListAsync();
        }

        public async Task<List<Product>> SearchProductsAsync(string searchTerm)
        {
            using var db = new shopdbContext();
            
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return await GetAllProductsAsync();
            }

            var lowercaseSearchTerm = searchTerm.ToLower();
            
            return await db.Products
                .AsNoTracking()
                .Include(p => p.Category)
                .Where(p => 
                    p.ProductName.ToLower().Contains(lowercaseSearchTerm) ||
                    (p.Description != null && p.Description.ToLower().Contains(lowercaseSearchTerm)) ||
                    (p.Category != null && p.Category.CategoryName.ToLower().Contains(lowercaseSearchTerm)))
                .OrderBy(p => p.ProductName)
                .ToListAsync();
        }

        public async Task<bool> UpdateProductStockAsync(int productId, int newStock)
        {
            try
            {
                using var db = new shopdbContext();
                
                var product = await db.Products.FindAsync(productId);
                if (product == null)
                {
                    return false;
                }

                product.ProductInStock = newStock;
                var tracking = db.ChangeTracker.Entries<Product>();
                await db.SaveChangesAsync();
                return true ;
            }
            catch
            {
                return false;
            }
        }
    }
}
