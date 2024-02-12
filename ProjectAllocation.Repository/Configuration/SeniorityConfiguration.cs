using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectAllocation.Domain.Entities;
using ProjectAllocation.Domain.Enums;

namespace ProjectAllocation.Repository.Configuration
{
    internal class SeniorityConfiguration : IEntityTypeConfiguration<Seniority>
    {
        public void Configure(EntityTypeBuilder<Seniority> builder)
        {
            builder.ToTable("Seniority");
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Description).IsRequired().HasMaxLength((int)MaxStringLength.MINIMUM);
        }
    }
}
