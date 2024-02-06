using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAllocation.Domain.Entities
{
    public abstract class BaseIdentity
    {
        [Column("Id")]
        public Guid Id { get; set; }

        public void Create()
        {
            this.Id = Guid.NewGuid();
        }
    }
}
