using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Models;

namespace Customer.Services
{
    public interface IOrderService
    {
        Task<Order?> GetOrderByIdAsync(int orderId);
        Task<List<Order>> GetUserOrdersAsync(int userId);
        Task<bool> CreateOrderFromCartAsync(int userId, List<CartItem> cartItems, string shippingAddress);
        Task<bool> UpdateOrderStatusAsync(int orderId, string newStatus);
        Task<bool> CancelOrderAsync(int orderId);
        Task<decimal> CalculateOrderTotalAsync(List<CartItem> cartItems);
    }
}
