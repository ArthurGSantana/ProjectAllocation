namespace ProjectAllocation.Domain.Entities
{
    public class Project : BaseEntity
    {
        public string Name { get; set; }
        public string ClientName { get; set; }
        public DateTime ProjectInitiation { get; set; }
        public DateTime ProjectConclusion { get; set; }
        public bool Inactive { get; set; }
        public Guid ProjectStatusId { get; set; }
        public virtual ProjectStatus ProjectStatus { get; set; }
    }
}
