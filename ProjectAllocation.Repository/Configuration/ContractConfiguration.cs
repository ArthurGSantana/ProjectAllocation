using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectAllocation.Domain.Entities;
using ProjectAllocation.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAllocation.Repository.Configuration
{
    internal class ContractConfiguration : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.ToTable("Contract");
            builder.HasKey(a => a.Id);

            builder.Property(a => a.WorkingHours).IsRequired();
            builder.Property(a => a.Admission).IsRequired();

            builder.HasOne(c => c.ContractType)
               .WithMany()
               .HasForeignKey(c => c.ContractTypeId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Seniority)
               .WithMany()
               .HasForeignKey(c => c.SeniorityId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.JobFunction)
               .WithMany()
               .HasForeignKey(c => c.JobFunctionId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
