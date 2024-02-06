namespace ProjectAllocation.Domain.Entities
{
    public class ProfilePermission : BaseEntity
    {
        public Guid ProfileId { get; set; }
        public Guid PermissionId { get; set; }
        public virtual Profile Profile { get; set; }
        public virtual Permission Permission { get; set; }
    }
}
