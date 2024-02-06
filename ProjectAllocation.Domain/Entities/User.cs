using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAllocation.Domain.Entities
{
    public class User : BaseIdentity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Inactive { get; set; }
        public Guid ProfileId { get; set; }
        public Guid CollaboratorId { get; set; }
        public virtual Profile Profile { get; set; }
        public virtual Collaborator Collaborator { get; set; }
    }
}
