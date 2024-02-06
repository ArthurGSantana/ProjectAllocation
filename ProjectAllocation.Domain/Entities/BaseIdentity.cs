using System.ComponentModel.DataAnnotations.Schema;

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
