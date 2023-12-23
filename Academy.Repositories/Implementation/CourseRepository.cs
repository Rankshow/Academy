using Academy.Core.Entities;
using Academy.Core.Interfaces;

namespace Academy.Repositories.Implementation
{
    public class CourseRepository : ICourseRepository
    {
        public Task<Course> Add(Course course)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid courseId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Course>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Course> GetById(Course courseId)
        {
            throw new NotImplementedException();
        }

        public Task<Course> Update(Course course)
        {
            throw new NotImplementedException();
        }
    }
}