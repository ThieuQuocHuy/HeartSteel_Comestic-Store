using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly shopdbContext _context;
        public OrderDetailRepository()
        {
            _context = new shopdbContext();
        }
        public async Task<OrderDetail> AddAsync(OrderDetail orderDetail)
        {
            if (orderDetail.Product != null)
            {
                _context.Products.Attach(orderDetail.Product);
            }

            _context.OrderDetails.Add(orderDetail);

            await _context.SaveChangesAsync();

            return orderDetail;
        }
    }
}