using DAL.Models; 
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class InventoryRepository
    {
        private readonly ProductRepository _productRepository;
        public InventoryRepository()
        {
            _productRepository = new ProductRepository();
        }
        public async Task<IReadOnlyList<Product>> GetInventoryProductsAsync()
        {
            using var db = new shopdbContext();
            return await db.Products
                .AsNoTracking()
                .OrderBy(p => p.ProductName)
                .ToListAsync();
        }

        public async Task<IReadOnlyList<Product>> GetStockAlertsAsync(int threshold)
        {
            using var db = new shopdbContext();
            return await db.Products
                .AsNoTracking()
                .Where(p => p.ProductInStock < threshold && p.StatusId != 3)
                .OrderBy(p => p.ProductInStock)
                .ToListAsync();
        }

        public async Task<bool> UpdateStockAsync(int productId, int newStock)
        {
            return await _productRepository.UpdateProductStockAsync(productId, newStock);
        }
    }
}