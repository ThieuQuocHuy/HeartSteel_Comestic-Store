using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IOrderItemRepository
    {
        Task<IEnumerable<OrderDetail>> GetOrderItemsByOrderIdAsync(int orderId);
    }
}