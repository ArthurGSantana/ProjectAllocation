﻿namespace ProjectAllocation.Domain.Entities
{
    public class Address : BaseEntity
    {
        public string ZipCode { get; set; }
        public string StreetName { get; set; }
        public string Number { get; set; }
        public string Neighborhood { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}
