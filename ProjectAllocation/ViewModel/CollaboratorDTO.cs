using ProjectAllocation.Domain.Entities;

namespace ProjectAllocation.API.ViewModel
{
    public class CollaboratorDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public int MaritalStatus { get; set; }
        public bool isLeader { get; set; }
        public string ImageURL { get; set; }
        public bool Inactive { get; set; }
        public AddressDTO Address { get; set; }
        public Contract Contract { get; set; }
    }
}
