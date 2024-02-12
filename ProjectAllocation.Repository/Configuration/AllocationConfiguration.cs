using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectAllocation.Domain.Entities;
using ProjectAllocation.Domain.Enums;

namespace ProjectAllocation.Repository.Configuration
{
    internal class AllocationConfiguration : IEntityTypeConfiguration<Allocation>
    {
        public void Configure(EntityTypeBuilder<Allocation> builder)
        {
            builder.ToTable("Allocation");
            builder.HasKey(a => a.Id);

            builder.Property(a => a.StartDate).IsRequired();
            builder.Property(a => a.EndDate).IsRequired();
            builder.Property(a => a.Observations).HasMaxLength((int)MaxStringLength.XLARGE);
            builder.Property(a => a.HoursPerWeek).IsRequired();

            builder.HasOne(c => c.Project)
               .WithMany()
               .HasForeignKey(c => c.ProjectId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Collaborator)
               .WithMany()
               .HasForeignKey(c => c.CollaboratorId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.AllocationStatus)
               .WithMany()
               .HasForeignKey(c => c.AllocationStatusId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
