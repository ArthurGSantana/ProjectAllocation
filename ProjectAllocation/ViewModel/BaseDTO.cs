namespace ProjectAllocation.API.ViewModel
{
    public class BaseDTO : BaseIdentityDTO
    {
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool Inactive { get; set; }
    }
}
