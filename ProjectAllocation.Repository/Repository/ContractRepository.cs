using Microsoft.EntityFrameworkCore;
using ProjectAllocation.Domain.Entities;
using ProjectAllocation.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAllocation.Repository.Repository
{
    internal class ContractRepository : BaseRepository<Contract>, IContractRepository
    {
        public ContractRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
