using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectAllocation.Domain.Entities;
using ProjectAllocation.Domain.Enums;

namespace ProjectAllocation.Repository.Configuration
{
    internal class PermissionConfiguration : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.ToTable("Permission");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name).IsRequired().HasMaxLength((int)MaxStringLength.SMALL);
            builder.Property(p => p.Process).IsRequired().HasMaxLength((int)MaxStringLength.SMALL);
            builder.Property(p => p.PermissionControl).IsRequired().HasMaxLength((int)MaxStringLength.SMALL);
            builder.Property(p => p.ProcessControl).IsRequired().HasMaxLength((int)MaxStringLength.SMALL);
            builder.Property(p => p.PermissionName).IsRequired().HasMaxLength((int)MaxStringLength.SMALL);
        }
    }
}
