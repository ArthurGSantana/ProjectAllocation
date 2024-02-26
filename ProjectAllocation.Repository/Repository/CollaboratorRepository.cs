using Microsoft.EntityFrameworkCore;
using ProjectAllocation.Domain.Entities;
using ProjectAllocation.Domain.Interfaces.Repository;

namespace ProjectAllocation.Repository.Repository
{
    internal class CollaboratorRepository : BaseRepository<Collaborator>, ICollaboratorRepository
    {
        public CollaboratorRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
