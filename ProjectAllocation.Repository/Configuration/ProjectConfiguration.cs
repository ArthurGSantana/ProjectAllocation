using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectAllocation.Domain.Entities;
using ProjectAllocation.Domain.Enums;

namespace ProjectAllocation.Repository.Configuration
{
    internal class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Project");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name).IsRequired().HasMaxLength((int)MaxStringLength.SMALL);
            builder.Property(p => p.ClientName).IsRequired().HasMaxLength((int)MaxStringLength.MEDIUM);
            builder.Property(p => p.ProjectInitiation).IsRequired();
            builder.Property(p => p.ProjectConclusion).IsRequired();

            builder.HasOne(c => c.ProjectStatus)
               .WithMany()
               .HasForeignKey(c => c.ProjectStatusId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
