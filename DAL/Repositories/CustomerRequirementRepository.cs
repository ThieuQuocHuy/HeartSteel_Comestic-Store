using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class CustomerRequirementRepository : ICustomerRequirementRepository
    {
        public async Task<List<CustomerRequirement>> GetAllAsync()
        {
            using var db = new shopdbContext();
            return await db.CustomerRequirements
                .Include(c => c.User)
                .Include(c => c.Status)
                .OrderByDescending(c => c.RequestDate)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<List<CustomerRequirement>> SearchByCustomerNameAsync(string keyword)
        {
            using var db = new shopdbContext();
            if (string.IsNullOrWhiteSpace(keyword)) return await GetAllAsync();
            var k = keyword.ToLower();
            return await db.CustomerRequirements
                .Include(c => c.User)
                .Include(c => c.Status)
                .Where(c => c.CustomerName.ToLower().Contains(k))
                .OrderByDescending(c => c.RequestDate)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<List<CustomerRequirement>> GetByLatestDateAsync(DateTime fromDateInclusive)
        {
            using var db = new shopdbContext();
            return await db.CustomerRequirements
                .Include(c => c.User)
                .Include(c => c.Status)
                .Where(c => c.RequestDate >= fromDateInclusive)
                .OrderByDescending(c => c.RequestDate)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<CustomerRequirement?> GetByIdAsync(int requirementId)
        {
            using var db = new shopdbContext();
            return await db.CustomerRequirements
                .Include(c => c.User)
                .Include(c => c.Status)
                .FirstOrDefaultAsync(c => c.RequirementId == requirementId);
        }

        public async Task<bool> UpdateStatusAsync(int requirementId, int statusId)
        {
            using var db = new shopdbContext();
            var entity = await db.CustomerRequirements.FirstOrDefaultAsync(c => c.RequirementId == requirementId);
            if (entity == null) return false;
            entity.StatusId = statusId;
            db.Entry(entity).State = EntityState.Modified;
            return await db.SaveChangesAsync() > 0;
        }

        public async Task<bool> AddResponseAndMarkAnsweredAsync(int requirementId, string responseContent)
        {
            // DB schema does not include response storage; mimic by appending to content and updating status.
            using var db = new shopdbContext();
            var entity = await db.CustomerRequirements.FirstOrDefaultAsync(c => c.RequirementId == requirementId);
            if (entity == null) return false;

            // Append response
            var separator = "\n--- Phản hồi ---\n";
            entity.Content = (entity.Content ?? string.Empty) + separator + responseContent;

            // Find status id for "Đã trả lời"
            var answered = await db.RequirementStatuses.AsNoTracking().FirstOrDefaultAsync(s => s.StatusName == "Đã trả lời");
            if (answered == null) return false;
            entity.StatusId = answered.StatusId;

            db.Entry(entity).State = EntityState.Modified;
            return await db.SaveChangesAsync() > 0;
        }
    }
}


