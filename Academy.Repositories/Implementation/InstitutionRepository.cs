using Academy.Core.Entities;
using Academy.Core.Interfaces;
using Academy.Repositories.Data;

namespace Academy.Repositories.Implementation
{
    public class InstitutionRepository : IInstitutionRepository
    {
        private readonly AcademyContext _academyContext;
        public InstitutionRepository(AcademyContext academyContext)
        {
            _academyContext = academyContext;   
        }
        public Task<Institution> Add(Institution Institution)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid institutionIdId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Institution>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Institution> GetById(Institution institutionId)
        {
            throw new NotImplementedException();
        }

        public Task<Institution> Update(Institution institution)
        {
            throw new NotImplementedException();
        }
    }
}