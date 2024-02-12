using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectAllocation.Domain.Entities;
using ProjectAllocation.Domain.Enums;

namespace ProjectAllocation.Repository.Configuration
{
    internal class JobFunctionConfiguration : IEntityTypeConfiguration<JobFunction>
    {
        public void Configure(EntityTypeBuilder<JobFunction> builder)
        {
            builder.ToTable("JobFunction");
            builder.HasKey(j => j.Id);

            builder.Property(j => j.Description).IsRequired().HasMaxLength((int)MaxStringLength.MINIMUM);
        }
    }
}
