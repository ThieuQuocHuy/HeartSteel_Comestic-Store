using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IOrderRepository
    {
        Task<List<Order>> GetAllOrdersAsync();
        Task<Order?> GetOrderByIdAsync(int orderId);
        Task<bool> CreateOrderAsync(Order order);
        Task<bool> UpdateOrderAsync(Order order);
        Task<bool> DeleteOrderAsync(int orderId);
        Task<List<Order>> GetOrdersByUserIdAsync(int userId);
        Task<Order?> GetByIdAsync(int orderId);
        Task UpdateAsync(Order orderToUpdate);
        Task<Order> AddOrderAsync(Order order);
    }
}