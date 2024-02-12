using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectAllocation.Domain.Entities;
using ProjectAllocation.Domain.Enums;

namespace ProjectAllocation.Repository.Configuration
{
    internal class CollaboratorConfiguration : IEntityTypeConfiguration<Collaborator>
    {
        public void Configure(EntityTypeBuilder<Collaborator> builder)
        {
            builder.ToTable("Collaborator");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name).IsRequired().HasMaxLength((int)MaxStringLength.SMALL);
            builder.Property(c => c.Surname).IsRequired().HasMaxLength((int)MaxStringLength.SMALL);
            builder.Property(c => c.Email).IsRequired().HasMaxLength((int)MaxStringLength.MEDIUM);
            builder.Property(c => c.BirthDate).IsRequired();
            builder.Property(c => c.Gender).IsRequired().HasMaxLength((int)MaxStringLength.MINIMUM);
            builder.Property(c => c.MaritalStatus).IsRequired();
            builder.Property(c => c.isLeader).IsRequired();

            builder.HasOne(c => c.Address)
               .WithOne()
               .HasForeignKey<Collaborator>(c => c.AddressId)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(c => c.User)
               .WithOne()
               .HasForeignKey<Collaborator>(c => c.UserId)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(c => c.Contract)
               .WithOne()
               .HasForeignKey<Collaborator>(c => c.ContractId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
