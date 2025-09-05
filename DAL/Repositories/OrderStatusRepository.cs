using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class OrderStatusRepository : IOrderStatusRepository
    {
        private readonly shopdbContext _context;

        public OrderStatusRepository()
        {
            _context = new shopdbContext();
        }

        public async Task<List<OrderStatus>> GetAllAsync()
        {
            return await _context.OrderStatuses.ToListAsync();
        }

        public async Task AddAsync(OrderStatus newStatusRecord)
        {
            await _context.OrderStatuses.AddAsync(newStatusRecord);
            await _context.SaveChangesAsync();
        }
    }
}