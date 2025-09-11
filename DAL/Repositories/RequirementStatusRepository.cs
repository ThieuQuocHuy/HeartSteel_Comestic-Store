using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class RequirementStatusRepository : IRequirementStatusRepository
    {
        public async Task<List<RequirementStatus>> GetAllAsync()
        {
            using var db = new shopdbContext();
            return await db.RequirementStatuses.AsNoTracking().OrderBy(s => s.StatusName).ToListAsync();
        }

        public async Task<RequirementStatus?> GetByNameAsync(string statusName)
        {
            using var db = new shopdbContext();
            return await db.RequirementStatuses.AsNoTracking().FirstOrDefaultAsync(s => s.StatusName == statusName);
        }
    }
}


