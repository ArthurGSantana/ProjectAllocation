using AutoMapper;
using ProjectAllocation.API.Interfaces.Service;
using ProjectAllocation.API.ViewModel;
using ProjectAllocation.Domain.Interfaces.Repository;
using ProjectAllocation.Domain.Interfaces.Service;

namespace ProjectAllocation.API.Services
{
    public class CollaboratorService : ICollaboratorService<CollaboratorDTO>
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IMapper _mapper;

        public CollaboratorService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<CollaboratorDTO> GetById(Guid id)
        {
            var collaborator = await _unitOfWork.CollaboratorRepository.GetByIdAsync(id);

            return _mapper.Map<CollaboratorDTO>(collaborator);
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
