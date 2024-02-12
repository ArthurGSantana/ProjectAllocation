using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectAllocation.Domain.Entities;
using ProjectAllocation.Domain.Enums;

namespace ProjectAllocation.Repository.Configuration
{
    internal class AllocationStatusConfiguration : IEntityTypeConfiguration<AllocationStatus>
    {
        public void Configure(EntityTypeBuilder<AllocationStatus> builder)
        {
            builder.ToTable("AllocationStatus");
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Description).IsRequired().HasMaxLength((int)MaxStringLength.SMALL);
        }
    }
}
