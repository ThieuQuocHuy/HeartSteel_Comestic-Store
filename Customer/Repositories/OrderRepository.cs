using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Customer.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly shopdbContext _context;

        public OrderRepository()
        {
            _context = new shopdbContext();
        }

        public async Task<Order?> GetByIdAsync(int orderId)
        {
            try
            {
                return await _context.Orders
                    .Include(o => o.OrderDetails)
                    .ThenInclude(od => od.Product)
                    .Include(o => o.OrderStatuses)
                    .FirstOrDefaultAsync(o => o.OrderId == orderId);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<List<Order>> GetOrdersByUserIdAsync(int userId)
        {
            try
            {
                return await _context.Orders
                    .Include(o => o.OrderDetails)
                    .ThenInclude(od => od.Product)
                    .Include(o => o.OrderStatuses)
                    .Where(o => o.UserId == userId)
                    .OrderByDescending(o => o.OrderDate)
                    .ToListAsync();
            }
            catch (Exception)
            {
                return new List<Order>();
            }
        }

        public async Task<bool> CreateOrderAsync(Order order)
        {
            try
            {
                _context.Orders.Add(order);
                var result = await _context.SaveChangesAsync();
                return result > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdateOrderAsync(Order order)
        {
            try
            {
                _context.Orders.Update(order);
                var result = await _context.SaveChangesAsync();
                return result > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteOrderAsync(int orderId)
        {
            try
            {
                var order = await _context.Orders.FindAsync(orderId);
                if (order != null)
                {
                    _context.Orders.Remove(order);
                    var result = await _context.SaveChangesAsync();
                    return result > 0;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<int> GetNextOrderIdAsync()
        {
            try
            {
                var maxOrderId = await _context.Orders.MaxAsync(o => (int?)o.OrderId) ?? 0;
                return maxOrderId + 1;
            }
            catch (Exception)
            {
                return 1;
            }
        }
    }
}
