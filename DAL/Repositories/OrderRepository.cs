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
        private readonly shopdbContext _context;

        public OrderRepository()
        {
            _context = new shopdbContext();
        }

        public async Task<List<Order>> GetAllOrdersAsync()
        {
            return await _context.Orders
                                 .Include(o => o.User)
                                 .Include(o => o.OrderStatuses) 
                                 .Include(o => o.OrderDetails)
                                 .ThenInclude(od => od.Product)
                                 .ToListAsync();
        }

        public async Task<Order?> GetOrderByIdAsync(int orderId)
        {
            return await _context.Orders
                                 .Include(o => o.User)
                                 .Include(o => o.OrderStatuses)
                                 .Include(o => o.OrderDetails)
                                 .ThenInclude(od => od.Product)
                                 .FirstOrDefaultAsync(o => o.OrderId == orderId);
        }

        public async Task<Order> AddOrderAsync(Order order)
        {
            using var db = new shopdbContext();
            await db.Set<Order>().AddAsync(order);
            await db.SaveChangesAsync();
            return order;
        }


        public async Task<Order?> GetByIdAsync(int orderId)
        {
            return await GetOrderByIdAsync(orderId);
        }

        public async Task<bool> CreateOrderAsync(Order order)
        {
            try
            {
                await _context.Orders.AddAsync(order);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task UpdateAsync(Order orderToUpdate)
        {
            _context.Orders.Update(orderToUpdate);
            await _context.SaveChangesAsync();
        }

        public async Task AddAsync(OrderStatus newStatusRecord)
        {
            await _context.OrderStatuses.AddAsync(newStatusRecord);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateOrderAsync(Order order)
        {
            try
            {
                _context.Orders.Update(order);
                await _context.SaveChangesAsync();
                return true;
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
                var order = await GetOrderByIdAsync(orderId);
                if (order != null)
                {
                    _context.OrderDetails.RemoveRange(order.OrderDetails);
                    _context.OrderStatuses.RemoveRange(order.OrderStatuses);
                    _context.Orders.Remove(order);
                    await _context.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<Order>> GetOrdersByUserIdAsync(int userId)
        {
            return await _context.Orders
                                 .Where(o => o.UserId == userId)
                                 .Include(o => o.OrderStatuses) 
                                 .Include(o => o.OrderDetails)
                                 .ThenInclude(od => od.Product)
                                 .ToListAsync();
        }
    }
}