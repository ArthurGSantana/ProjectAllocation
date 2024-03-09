using Microsoft.EntityFrameworkCore;
using ProjectAllocation.Domain.Interfaces.Repository;
using ProjectAllocation.Repository.Repository;

namespace ProjectAllocation.Repository.UnitOfWork
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;

        public ICollaboratorRepository CollaboratorRepository => new CollaboratorRepository(_context);
        public IAddressRepository AddressRepository => new AddressRepository(_context);

        public UnitOfWork(DbContext context)
        {
            _context = context;
        }

        public bool Commit()
        {
            throw new NotImplementedException();
        }
    }
}
