using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectAllocation.Domain.Entities;

namespace ProjectAllocation.Repository.Configuration
{
    internal class ProfilePermissionConfiguration : IEntityTypeConfiguration<ProfilePermission>
    {
        public void Configure(EntityTypeBuilder<ProfilePermission> builder)
        {
            builder.ToTable("ProfilePermission");
            builder.HasKey(pp => new { pp.ProfileId, pp.PermissionId });

            builder.HasOne(pp => pp.Profile)
                .WithMany()
                .HasForeignKey(pp => pp.ProfileId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(pp => pp.Permission)
                .WithMany()
                .HasForeignKey(pp => pp.PermissionId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
