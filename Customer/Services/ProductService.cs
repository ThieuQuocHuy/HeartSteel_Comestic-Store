using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Customer.Repositories;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Customer.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        // Constructor tương thích với code cũ
        public ProductService()
        {
            _repository = new ProductRepository();
        }

        // API mới (async)
        public Task<IReadOnlyList<Product>> GetAllAsync()
        {
            return _repository.GetAllAsync();
        }

        public Task<Product?> GetByIdAsync(int id)
        {
            return _repository.GetByIdAsync(id);
        }

        // Các API tương thích cũ (sync)
        public List<Product> GetAllProducts()
        {
            using var db = new shopdbContext();
            return db.Products.AsNoTracking().ToList();
        }

        public List<Product> GetActiveProducts()
        {
            // Chưa có cờ IsActive trong schema -> tạm coi tất cả là active
            using var db = new shopdbContext();
            return db.Products.AsNoTracking().ToList();
        }

        public Product? GetProductById(int id)
        {
            using var db = new shopdbContext();
            return db.Products.AsNoTracking().FirstOrDefault(p => p.ProductId == id);
        }

        public bool AddProduct(Product product)
        {
            try
            {
                using var db = new shopdbContext();
                db.Products.Add(product);
                db.SaveChanges();
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
                using var db = new shopdbContext();
                var existing = db.Products.FirstOrDefault(p => p.ProductId == product.ProductId);
                if (existing == null) return false;

                existing.ProductName = product.ProductName;
                existing.Description = product.Description;
                existing.SellPrice = product.SellPrice;
                existing.ProductInStock = product.ProductInStock;
                existing.CategoryId = product.CategoryId;
                existing.Img = product.Img;
                existing.StatusId = product.StatusId;
                db.SaveChanges();
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
                using var db = new shopdbContext();
                var product = db.Products.FirstOrDefault(p => p.ProductId == id);
                if (product == null) return false;
                db.Products.Remove(product);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateStock(int productId, int quantityDelta)
        {
            try
            {
                using var db = new shopdbContext();
                var product = db.Products.FirstOrDefault(p => p.ProductId == productId);
                if (product == null) return false;
                product.ProductInStock = Math.Max(0, product.ProductInStock + quantityDelta);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int GetTotalProducts()
        {
            using var db = new shopdbContext();
            return db.Products.Count();
        }

        public int GetLowStockCount()
        {
            using var db = new shopdbContext();
            return db.Products.Count(p => p.ProductInStock <= 10);
        }

        public decimal GetTotalInventoryValue()
        {
            using var db = new shopdbContext();
            return db.Products.Sum(p => (p.SellPrice ?? 0) * p.ProductInStock);
        }

        public List<int?> GetCategories()
        {
            using var db = new shopdbContext();
            return db.Products.Select(p => p.CategoryId).Distinct().ToList();
        }
    }
}


