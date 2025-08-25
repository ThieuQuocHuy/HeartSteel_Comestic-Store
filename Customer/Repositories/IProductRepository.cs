using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Models;

namespace Customer.Repositories
{
    public interface IProductRepository
    {
        Task<IReadOnlyList<Product>> GetAllAsync();
        Task<Product?> GetByIdAsync(int id);
    }
}


