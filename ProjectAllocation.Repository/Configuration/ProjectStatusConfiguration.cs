using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectAllocation.Domain.Entities;
using ProjectAllocation.Domain.Enums;

namespace ProjectAllocation.Repository.Configuration
{
    internal class ProjectStatusConfiguration : IEntityTypeConfiguration<ProjectStatus>
    {
        public void Configure(EntityTypeBuilder<ProjectStatus> builder)
        {
            builder.ToTable("ProjectStatus");
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Description).IsRequired().HasMaxLength((int)MaxStringLength.SMALL);
        }
    }
}
