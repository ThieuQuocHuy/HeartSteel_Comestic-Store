using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IOrderStatusRepository
    {
        Task AddAsync(OrderStatus newStatusRecord);
        Task<List<OrderStatus>> GetAllAsync();
    }
}