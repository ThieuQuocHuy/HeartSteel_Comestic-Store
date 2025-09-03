using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            using var db = new shopdbContext();
            return await db.Categories
                .AsNoTracking()
                .OrderBy(c => c.CategoryName)
                .ToListAsync();
        }

        public async Task<Category?> GetCategoryByIdAsync(int categoryId)
        {
            using var db = new shopdbContext();
            return await db.Categories
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.CategoryId == categoryId);
        }

        public async Task<bool> CreateCategoryAsync(Category category)
        {
            try
            {
                using var db = new shopdbContext();
                db.Categories.Add(category);
                var result = await db.SaveChangesAsync();
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> UpdateCategoryAsync(Category category)
        {
            try
            {
                using var db = new shopdbContext();
                
                var existingCategory = await db.Categories.FindAsync(category.CategoryId);
                if (existingCategory == null)
                {
                    return false;
                }

                existingCategory.CategoryName = category.CategoryName;

                var result = await db.SaveChangesAsync();
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DeleteCategoryAsync(int categoryId)
        {
            try
            {
                using var db = new shopdbContext();
                
                // Check if category has products
                var hasProducts = await db.Products.AnyAsync(p => p.CategoryId == categoryId);
                if (hasProducts)
                {
                    return false; // Cannot delete category with products
                }

                var category = await db.Categories.FindAsync(categoryId);
                if (category == null)
                {
                    return false;
                }

                db.Categories.Remove(category);
                var result = await db.SaveChangesAsync();
                return result > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}