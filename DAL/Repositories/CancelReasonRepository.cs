using DAL.Models;

namespace DAL.Repositories
{
    public class CancelReasonRepository : ICancelReasonRepository
    {
        public async Task<CancelReason> CreateAsync(string description)
        {
            using var db = new shopdbContext();
            var reason = new CancelReason { Description = description };
            db.CancelReasons.Add(reason);
            await db.SaveChangesAsync();
            return reason;
        }
    }
}


