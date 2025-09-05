using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class OrderItemRepository : IOrderItemRepository
    {
        private readonly shopdbContext _context;

        public OrderItemRepository()
        {
            _context = new shopdbContext();
        }

        public async Task<IEnumerable<OrderDetail>> GetOrderItemsByOrderIdAsync(int orderId)
        {
            // Dùng Include để lấy thông tin sản phẩm liên quan
            return await _context.OrderDetails
                                 .Include(od => od.Product)
                                 .Where(od => od.OrderId == orderId)
                                 .ToListAsync();
        }
    }
}