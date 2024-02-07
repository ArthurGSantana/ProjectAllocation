using Microsoft.EntityFrameworkCore;
using ProjectAllocation.Domain.Entities;
namespace ProjectAllocation.Repository.Context
{
    public class ProjectAllocationContext : DbContext
    {
        public ProjectAllocationContext(DbContextOptions<ProjectAllocationContext> options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Collaborator> Collaborator { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<JobFunction> JobFunction { get; set; }
        public DbSet<Seniority> Seniority { get; set; }
        public DbSet<Contract> Contract { get; set; }
        public DbSet<ContractType> ContractType { get; set; }
        public DbSet<Allocation> Allocation { get; set; }
        public DbSet<AllocationStatus> AllocationStatus { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<ProjectStatus> ProjectStatus { get; set; }
        public DbSet<Profile> Profile { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<ProfilePermission> ProfilePermission { get; set; }
    }
}
