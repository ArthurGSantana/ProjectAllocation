using AutoMapper;
using ProjectAllocation.API.Interfaces.Service;
using ProjectAllocation.API.ViewModel;
using ProjectAllocation.Domain.Entities;
using ProjectAllocation.Domain.Interfaces.Repository;

namespace ProjectAllocation.API.Services
{
    public class CollaboratorService : ICollaboratorService
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

        public async Task<IEnumerable<CollaboratorDTO>> GetAll()
        {
            var collaborators = await _unitOfWork.CollaboratorRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<CollaboratorDTO>>(collaborators);
        }

        public CollaboratorDTO? Add(CollaboratorDTO entity)
        {
            var collaborator = _mapper.Map<Collaborator>(entity);

            collaborator.Create();

            _unitOfWork.CollaboratorRepository.Add(collaborator);

            var result = _mapper.Map<CollaboratorDTO>(collaborator);

            return _unitOfWork.Commit() ? result : null;
        }

        public async Task<bool> Update(CollaboratorDTO entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(CollaboratorDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
