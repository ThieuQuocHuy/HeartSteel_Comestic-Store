using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Repositories
{
    public interface IOrderRepository
    {
        Task<Order?> GetByIdAsync(int orderId);
        Task<List<Order>> GetOrdersByUserIdAsync(int userId);
        Task<bool> CreateOrderAsync(Order order);
        Task<bool> UpdateOrderAsync(Order order);
        Task<bool> DeleteOrderAsync(int orderId);
        Task<int> GetNextOrderIdAsync();
    }
}
