using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Models;

namespace BLL.Services
{
    public interface IProductService
    {
        Task<IReadOnlyList<Product>> GetAllAsync();
        Task<Product?> GetByIdAsync(int id);
    }
}
