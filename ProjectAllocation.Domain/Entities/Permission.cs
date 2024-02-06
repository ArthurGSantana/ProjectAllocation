namespace ProjectAllocation.Domain.Entities
{
    public class Permission : BaseEntity
    {
        public string Name { get; set; }
        public string Process { get; set; }
        public string PermissionControl { get; set; }
        public string ProcessControl { get; set; }
        public string PermissionName { get; set; }
    }
}
