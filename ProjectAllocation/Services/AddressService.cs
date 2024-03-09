using AutoMapper;
using ProjectAllocation.API.Interfaces.Service;
using ProjectAllocation.API.ViewModel;
using ProjectAllocation.Domain.Entities;
using ProjectAllocation.Domain.Interfaces.Repository;

namespace ProjectAllocation.API.Services
{
    public class AddressService : IAddressService
    {

        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IMapper _mapper;

        public AddressService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Task<AddressDTO> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AddressDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Address Add(Address entity)
        {
            entity.Create();

            _unitOfWork.AddressRepository.Add(entity);

            return entity;
        }

        public Task<bool> Update(AddressDTO entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(AddressDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
