﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ProjectAllocation.Repository.Context;

#nullable disable

namespace ProjectAllocation.Repository.Migrations
{
    [DbContext(typeof(ProjectAllocationContext))]
    partial class ProjectAllocationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ProjectAllocation.Domain.Entities.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreatedAt");

                    b.Property<bool>("Inactive")
                        .HasColumnType("boolean")
                        .HasColumnName("Inactive");

                    b.Property<string>("Neighborhood")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("UpdatedAt");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("ProjectAllocation.Domain.Entities.Allocation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<Guid>("AllocationStatusId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("CollaboratorId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreatedAt");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<float>("HoursPerWeek")
                        .HasColumnType("real");

                    b.Property<bool>("Inactive")
                        .HasColumnType("boolean");

                    b.Property<string>("Observations")
                        .HasColumnType("text");

                    b.Property<Guid>("ProjectId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("AllocationStatusId");

                    b.HasIndex("CollaboratorId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Allocation");
                });

            modelBuilder.Entity("ProjectAllocation.Domain.Entities.AllocationStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreatedAt");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Inactive")
                        .HasColumnType("boolean")
                        .HasColumnName("Inactive");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("AllocationStatus");
                });

            modelBuilder.Entity("ProjectAllocation.Domain.Entities.Collaborator", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<Guid>("AddressId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("ContractId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Inactive")
                        .HasColumnType("boolean");

                    b.Property<int>("MaritalStatus")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("UpdatedAt");

                    b.Property<bool>("isLeader")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("ContractId");

                    b.ToTable("Collaborator");
                });

            modelBuilder.Entity("ProjectAllocation.Domain.Entities.Contract", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<DateTime>("Admission")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("ContractTypeId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreatedAt");

                    b.Property<bool>("Inactive")
                        .HasColumnType("boolean")
                        .HasColumnName("Inactive");

                    b.Property<Guid>("JobFunctionId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("SeniorityId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("UpdatedAt");

                    b.Property<float>("WorkingHours")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ContractTypeId");

                    b.HasIndex("JobFunctionId");

                    b.HasIndex("SeniorityId");

                    b.ToTable("Contract");
                });

            modelBuilder.Entity("ProjectAllocation.Domain.Entities.ContractType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreatedAt");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Inactive")
                        .HasColumnType("boolean")
                        .HasColumnName("Inactive");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("ContractType");
                });

            modelBuilder.Entity("ProjectAllocation.Domain.Entities.JobFunction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreatedAt");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Inactive")
                        .HasColumnType("boolean")
                        .HasColumnName("Inactive");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("JobFunction");
                });

            modelBuilder.Entity("ProjectAllocation.Domain.Entities.Permission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreatedAt");

                    b.Property<bool>("Inactive")
                        .HasColumnType("boolean")
                        .HasColumnName("Inactive");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PermissionControl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PermissionName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Process")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProcessControl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Permission");
                });

            modelBuilder.Entity("ProjectAllocation.Domain.Entities.Profile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreatedAt");

                    b.Property<bool>("Inactive")
                        .HasColumnType("boolean")
                        .HasColumnName("Inactive");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Profile");
                });

            modelBuilder.Entity("ProjectAllocation.Domain.Entities.ProfilePermission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreatedAt");

                    b.Property<bool>("Inactive")
                        .HasColumnType("boolean")
                        .HasColumnName("Inactive");

                    b.Property<Guid>("PermissionId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("PermissionId");

                    b.HasIndex("ProfileId");

                    b.ToTable("ProfilePermission");
                });

            modelBuilder.Entity("ProjectAllocation.Domain.Entities.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreatedAt");

                    b.Property<bool>("Inactive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ProjectConclusion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ProjectInitiation")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("ProjectStatusId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("ProjectStatusId");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("ProjectAllocation.Domain.Entities.ProjectStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreatedAt");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Inactive")
                        .HasColumnType("boolean")
                        .HasColumnName("Inactive");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("ProjectStatus");
                });

            modelBuilder.Entity("ProjectAllocation.Domain.Entities.Seniority", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreatedAt");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Inactive")
                        .HasColumnType("boolean")
                        .HasColumnName("Inactive");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Seniority");
                });

            modelBuilder.Entity("ProjectAllocation.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<Guid>("CollaboratorId")
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Inactive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CollaboratorId")
                        .IsUnique();

                    b.HasIndex("ProfileId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ProjectAllocation.Domain.Entities.Allocation", b =>
                {
                    b.HasOne("ProjectAllocation.Domain.Entities.AllocationStatus", "AllocationStatus")
                        .WithMany()
                        .HasForeignKey("AllocationStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectAllocation.Domain.Entities.Collaborator", "Collaborator")
                        .WithMany()
                        .HasForeignKey("CollaboratorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectAllocation.Domain.Entities.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AllocationStatus");

                    b.Navigation("Collaborator");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("ProjectAllocation.Domain.Entities.Collaborator", b =>
                {
                    b.HasOne("ProjectAllocation.Domain.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectAllocation.Domain.Entities.Contract", "Contract")
                        .WithMany()
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Contract");
                });

            modelBuilder.Entity("ProjectAllocation.Domain.Entities.Contract", b =>
                {
                    b.HasOne("ProjectAllocation.Domain.Entities.ContractType", "ContractType")
                        .WithMany()
                        .HasForeignKey("ContractTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectAllocation.Domain.Entities.JobFunction", "JobFunction")
                        .WithMany()
                        .HasForeignKey("JobFunctionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectAllocation.Domain.Entities.Seniority", "Seniority")
                        .WithMany()
                        .HasForeignKey("SeniorityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ContractType");

                    b.Navigation("JobFunction");

                    b.Navigation("Seniority");
                });

            modelBuilder.Entity("ProjectAllocation.Domain.Entities.ProfilePermission", b =>
                {
                    b.HasOne("ProjectAllocation.Domain.Entities.Permission", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectAllocation.Domain.Entities.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("ProjectAllocation.Domain.Entities.Project", b =>
                {
                    b.HasOne("ProjectAllocation.Domain.Entities.ProjectStatus", "ProjectStatus")
                        .WithMany()
                        .HasForeignKey("ProjectStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProjectStatus");
                });

            modelBuilder.Entity("ProjectAllocation.Domain.Entities.User", b =>
                {
                    b.HasOne("ProjectAllocation.Domain.Entities.Collaborator", "Collaborator")
                        .WithOne("User")
                        .HasForeignKey("ProjectAllocation.Domain.Entities.User", "CollaboratorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectAllocation.Domain.Entities.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Collaborator");

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("ProjectAllocation.Domain.Entities.Collaborator", b =>
                {
                    b.Navigation("User")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
