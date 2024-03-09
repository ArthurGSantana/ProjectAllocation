using ProjectAllocation.API.Interfaces.Services;
using ProjectAllocation.API.ViewModel;

namespace ProjectAllocation.API.Services
{
    public class ContractService : IContractService
    {
        public Task<ContractDTO> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ContractDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public ContractDTO Add(ContractDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(ContractDTO entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ContractDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
