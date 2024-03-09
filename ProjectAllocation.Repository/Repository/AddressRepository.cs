using Microsoft.EntityFrameworkCore;
using ProjectAllocation.Domain.Entities;
using ProjectAllocation.Domain.Interfaces.Repository;

namespace ProjectAllocation.Repository.Repository
{
    internal class AddressRepository : BaseRepository<Address>, IAddressRepository
    {
        public AddressRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
