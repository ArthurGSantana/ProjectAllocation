using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAllocation.Domain.Entities
{
    public class Allocation : BaseEntity
    {
        public Guid ProjectId { get; set; }
        public Guid CollaboratorId { get; set; }
        public Guid AllocationStatusId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Observations { get; set; }
        public float HoursPerWeek { get; set; }
        public bool Inactive { get; set; }
        public virtual Project Project { get; set; }
        public virtual Collaborator Collaborator { get; set; }
        public virtual AllocationStatus AllocationStatus { get; set; }
    }
}
