namespace ProjectAllocation.Domain.Entities
{
    public class Collaborator : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public int MaritalStatus { get; set; }
        public bool isLeader { get; set; }
        public string ImageURL { get; set; }
        public Guid AddressId { get; set; }
        public Guid ContractId { get; set; }
        public bool Inactive { get; set; }
        public virtual Address Address { get; set; }
        public virtual User User { get; set; }
        public virtual Contract Contract { get; set; }
    }
}
