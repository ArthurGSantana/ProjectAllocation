namespace ProjectAllocation.API.ViewModel
{
    public class ContractDTO : BaseDTO
    {
        public float WorkingHours { get; set; }
        public DateTime Admission { get; set; }
        public Guid ContractTypeId { get; set; }
        public Guid SeniorityId { get; set; }
        public Guid JobFunctionId { get; set; }
    }
}
