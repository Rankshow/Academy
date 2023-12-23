using Academy.Core.Entities;

namespace Academy.Core.Interfaces
{
    public interface IInstitutionRepository
    {
        Task<Institution> Add(Institution Institution);
        Task<Institution> GetById(Institution institutionId);
        Task<Institution> Update(Institution institution);
        Task<List<Institution>> GetAll();
        Task<bool> Delete(Guid institutionIdId);
    }
}