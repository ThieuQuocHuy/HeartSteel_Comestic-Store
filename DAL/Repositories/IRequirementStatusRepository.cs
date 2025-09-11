using DAL.Models;

namespace DAL.Repositories
{
    public interface IRequirementStatusRepository
    {
        Task<List<RequirementStatus>> GetAllAsync();
        Task<RequirementStatus?> GetByNameAsync(string statusName);
    }
}


