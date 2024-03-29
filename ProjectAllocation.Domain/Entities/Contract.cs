﻿namespace ProjectAllocation.Domain.Entities
{
    public class Contract : BaseEntity
    {
        public float WorkingHours { get; set; }
        public DateTime Admission { get; set; }
        public Guid ContractTypeId { get; set; }
        public Guid SeniorityId { get; set; }
        public Guid JobFunctionId { get; set; }
        public virtual ContractType ContractType { get; set; }
        public virtual Seniority Seniority { get; set; }
        public virtual JobFunction JobFunction { get; set; }
    }
}
