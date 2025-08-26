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
            return await db.Products.AsNoTracking().ToListAsync();
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            using var db = new shopdbContext();
            return await db.Products.AsNoTracking().FirstOrDefaultAsync(p => p.ProductId == id);
        }
    }
}
