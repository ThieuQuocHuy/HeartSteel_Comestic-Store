using DAL.Models;

namespace DAL.Repositories
{
    public interface ICancelReasonRepository
    {
        Task<CancelReason> CreateAsync(string description);
    }
}


