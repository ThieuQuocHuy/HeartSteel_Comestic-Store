using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class OrderRepository : IOrderRepository
    {
      
        public OrderRepository()
        {
            
        }

        public async Task<List<Order>> GetAllOrdersAsync()
        {
            using (var context = new shopdbContext())
            {
                return await context.Orders
                                     .Include(o => o.User)
                                     .Include(o => o.OrderStatuses)
                                     .Include(o => o.OrderDetails)
                                     .ThenInclude(od => od.Product)
                                     .ToListAsync();
            }
        }

        public async Task<Order?> GetOrderByIdAsync(int orderId)
        {
            using (var context = new shopdbContext())
            {
                return await context.Orders
                                     .Include(o => o.User)
                                     .Include(o => o.OrderStatuses)
                                     .Include(o => o.OrderDetails)
                                     .ThenInclude(od => od.Product)
                                     .FirstOrDefaultAsync(o => o.OrderId == orderId);
            }
        }

        public async Task<Order> AddOrderAsync(Order order)
        {
            using (var context = new shopdbContext())
            {
                await context.Orders.AddAsync(order);
                await context.SaveChangesAsync();
                return order;
            }
        }

        public async Task<bool> CreateOrderAsync(Order order)
        {
            try
            {
                using (var context = new shopdbContext())
                {
                    await context.Orders.AddAsync(order);
                    await context.SaveChangesAsync();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> UpdateOrderAsync(Order order)
        {
            try
            {
                using (var context = new shopdbContext())
                {
                    context.Orders.Update(order);
                    await context.SaveChangesAsync();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DeleteOrderAsync(int orderId)
        {
            try
            {
                using (var context = new shopdbContext())
                {
                    var order = await context.Orders
                                             .Include(o => o.OrderDetails)
                                             .Include(o => o.OrderStatuses)
                                             .FirstOrDefaultAsync(o => o.OrderId == orderId);

                    if (order != null)
                    {
                        context.OrderDetails.RemoveRange(order.OrderDetails);
                        context.OrderStatuses.RemoveRange(order.OrderStatuses);
                        context.Orders.Remove(order);
                        await context.SaveChangesAsync();
                        return true;
                    }
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<Order>> GetOrdersByUserIdAsync(int userId)
        {
            using (var context = new shopdbContext())
            {
                return await context.Orders
                                     .Where(o => o.UserId == userId)
                                     .Include(o => o.OrderStatuses)
                                     .Include(o => o.OrderDetails)
                                     .ThenInclude(od => od.Product)
                                     .ToListAsync();
            }
        }
        public async Task<Order?> GetByIdAsync(int orderId)
        {
            return await GetOrderByIdAsync(orderId);
        }

        public async Task<List<Order>> GetOrdersByDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            using (var context = new shopdbContext())
            {
                return await context.Orders
                                     .Where(o => o.OrderDate >= startDate && o.OrderDate <= endDate)
                                     .Where(o => o.CancelReasonId == null) // Chỉ lấy đơn hàng không bị hủy
                                     .Include(o => o.User)
                                     .Include(o => o.OrderStatuses)
                                     .Include(o => o.OrderDetails)
                                     .ThenInclude(od => od.Product)
                                     .OrderByDescending(o => o.OrderDate)
                                     .ToListAsync();
            }
        }
    }
}