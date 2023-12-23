using Academy.Core.Entities;

namespace Academy.Core.Interfaces
{
    public interface ICourseRepository
    {
        Task<Course> Add(Course course);
        Task<Course> GetById(Course courseId);
        Task<Course> Update(Course course);
        Task<List<Course>> GetAll();
        Task<bool> Delete(Guid courseId);
    }
}