using ProjectAllocation.API.ViewModel;
using ProjectAllocation.Domain.Entities;
using ProjectAllocation.Domain.Interfaces.Repository;
using ProjectAllocation.Domain.Interfaces.Service;

namespace ProjectAllocation.API.Services
{
    public class CollaboratorService : ICollaboratorService<CollaboratorDTO>
    {
        public Task<CollaboratorDTO> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CollaboratorDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CollaboratorDTO> Add(CollaboratorDTO entity)
        {
            throw new NotImplementedException();
        }

        public void Update(CollaboratorDTO entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(CollaboratorDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
