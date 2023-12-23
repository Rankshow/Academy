using Academy.Core.Entities;

namespace Academy.Core.Interfaces
{
    public interface IDepartmentRepository
    {
        Task<Department> Add(Department department);
        Task<Department> GetById(Department departmentId);
        Task<Department> Update(Department department);
        Task<List<Department>> GetAll();
        Task<bool> Delete(Guid departmentId);
    }
}