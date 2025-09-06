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
                .Include(c => c.Products)
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
                
                // Check if category name already exists
                var existingCategory = await db.Categories
                    .AsNoTracking()
                    .FirstOrDefaultAsync(c => c.CategoryName.ToLower() == category.CategoryName.ToLower());
                    
                if (existingCategory != null)
                {
                    System.Diagnostics.Debug.WriteLine($"CreateCategoryAsync: Category name '{category.CategoryName}' already exists");
                    return false; // Category name already exists
                }
                
                System.Diagnostics.Debug.WriteLine($"CreateCategoryAsync: Creating new category '{category.CategoryName}'");
                
                // Create a new category object without ID for auto-generation
                var newCategory = new Category
                {
                    CategoryName = category.CategoryName
                };
                
                db.Categories.Add(newCategory);
                var result = await db.SaveChangesAsync();
                System.Diagnostics.Debug.WriteLine($"CreateCategoryAsync: SaveChanges result: {result}");
                
                // Update the original category with the generated ID
                if (result > 0)
                {
                    category.CategoryId = newCategory.CategoryId;
                    System.Diagnostics.Debug.WriteLine($"CreateCategoryAsync: New category created with ID: {newCategory.CategoryId}");
                    return true;
                }
                
                System.Diagnostics.Debug.WriteLine($"CreateCategoryAsync: SaveChanges returned {result}, which is <= 0");
                return false;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"CreateCategoryAsync Error: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"CreateCategoryAsync StackTrace: {ex.StackTrace}");
                return false;
            }
        }

        public async Task<bool> UpdateCategoryAsync(Category category)
        {
            try
            {
                using var db = new shopdbContext();
                
                // Check if category name already exists (excluding current category)
                var duplicateCategory = await db.Categories
                    .AsNoTracking()
                    .FirstOrDefaultAsync(c => c.CategoryName.ToLower() == category.CategoryName.ToLower() 
                                           && c.CategoryId != category.CategoryId);
                    
                if (duplicateCategory != null)
                {
                    System.Diagnostics.Debug.WriteLine($"UpdateCategoryAsync: Category name '{category.CategoryName}' already exists");
                    return false; // Category name already exists
                }
                
                // Get the entity to update with tracking enabled
                var existingCategory = await db.Categories
                    .FirstOrDefaultAsync(c => c.CategoryId == category.CategoryId);
                    
                if (existingCategory == null)
                {
                    System.Diagnostics.Debug.WriteLine($"UpdateCategoryAsync: Category with ID {category.CategoryId} not found");
                    return false;
                }

                System.Diagnostics.Debug.WriteLine($"UpdateCategoryAsync: Found category '{existingCategory.CategoryName}' (ID: {existingCategory.CategoryId})");
                System.Diagnostics.Debug.WriteLine($"UpdateCategoryAsync: Updating to '{category.CategoryName}'");

                existingCategory.CategoryName = category.CategoryName;

                var result = await db.SaveChangesAsync();
                System.Diagnostics.Debug.WriteLine($"UpdateCategoryAsync: SaveChanges result: {result}");
                return result > 0;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"UpdateCategoryAsync Error: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"UpdateCategoryAsync StackTrace: {ex.StackTrace}");
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