using DAL.Models;

namespace DAL.Repositories
{
    public interface ICustomerRequirementRepository
    {
        Task<List<CustomerRequirement>> GetAllAsync();
        Task<List<CustomerRequirement>> GetByUserIdAsync(int userId);
        Task<List<CustomerRequirement>> SearchByCustomerNameAsync(string keyword);
        Task<List<CustomerRequirement>> GetByLatestDateAsync(DateTime fromDateInclusive);
        Task<CustomerRequirement?> GetByIdAsync(int requirementId);
        Task<bool> UpdateStatusAsync(int requirementId, int statusId);
        Task<bool> AddResponseAndMarkAnsweredAsync(int requirementId, string responseContent);
        Task<bool> CreateAsync(CustomerRequirement requirement);
    }
}


