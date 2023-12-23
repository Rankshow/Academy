using Academy.Core.Entities;

namespace Academy.Core.Interfaces
{
    public interface IFacultyRepository
    {
        Task<Faculty> Add(Faculty faculty);
        Task<Faculty> GetById(Faculty facultyId);
        Task<Faculty> Update(Faculty faculty);
        Task<List<Faculty>> GetAll();
        Task<bool> Delete(Guid facultyId);
    }
}