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

        public AddressDTO? Add(AddressDTO entity)
        {
            var address = _mapper.Map<Address>(entity);

            address.Create();

            _unitOfWork.AddressRepository.Add(address);

            var result = _mapper.Map<AddressDTO>(address);

            return _unitOfWork.Commit() ? result : null;
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
