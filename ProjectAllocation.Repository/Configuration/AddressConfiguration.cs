using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectAllocation.Domain.Entities;
using ProjectAllocation.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAllocation.Repository.Configuration
{
    internal class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Address");
            builder.HasKey(a => a.Id);

            builder.Property(a => a.ZipCode).IsRequired().HasMaxLength((int)MaxStringLength.MINIMUM);
            builder.Property(a => a.StreetName).IsRequired().HasMaxLength((int)MaxStringLength.SMALL);
            builder.Property(a => a.Number).IsRequired().HasMaxLength((int)MaxStringLength.MINIMUM);
            builder.Property(a => a.Neighborhood).IsRequired().HasMaxLength((int)MaxStringLength.MINIMUM);
            builder.Property(a => a.State).IsRequired().HasMaxLength((int)MaxStringLength.MINIMUM);
            builder.Property(a => a.Country).IsRequired().HasMaxLength((int)MaxStringLength.MINIMUM);
        }
    }
}
