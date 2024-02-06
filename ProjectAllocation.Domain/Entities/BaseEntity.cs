using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectAllocation.Domain.Entities
{
    public abstract class BaseEntity : BaseIdentity
    {
        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }

        [Column("UpdatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [Column("Inactive")]
        public bool Inactive { get; set; }
        public void Create(Guid userId)
        {
            base.Create();
            this.CreatedAt = DateTime.Now;
            this.Inactive = false;
        }

        public void Update(Guid userId)
        {
            this.UpdatedAt = DateTime.Now;
        }
    }
}
