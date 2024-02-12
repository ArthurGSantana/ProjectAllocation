using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectAllocation.Domain.Entities;
using ProjectAllocation.Domain.Enums;

namespace ProjectAllocation.Repository.Configuration
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Name).IsRequired().HasMaxLength((int)MaxStringLength.SMALL);
            builder.Property(u => u.Email).IsRequired().HasMaxLength((int)MaxStringLength.MEDIUM);
            builder.Property(u => u.Password).IsRequired().HasMaxLength((int)MaxStringLength.SMALL);

            builder.HasOne(c => c.Profile)
               .WithMany()
               .HasForeignKey(c => c.ProfileId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Collaborator)
               .WithOne()
               .HasForeignKey<User>(c => c.CollaboratorId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
