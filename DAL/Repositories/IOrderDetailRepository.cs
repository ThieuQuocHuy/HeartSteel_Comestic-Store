using DAL.Models;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IOrderDetailRepository
    {
        Task<OrderDetail> AddAsync(OrderDetail orderDetail);
    }
}