﻿// <auto-generated />
using System;
using LeaveManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LeaveManagementSystem.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.15");

            modelBuilder.Entity("LeaveManagementSystem.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("JoiningDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Department = "HR",
                            FullName = "rabii boughariou",
                            JoiningDate = new DateTime(2022, 4, 16, 11, 25, 10, 90, DateTimeKind.Local).AddTicks(6103)
                        },
                        new
                        {
                            Id = 2,
                            Department = "IT",
                            FullName = "ahmed rebai",
                            JoiningDate = new DateTime(2023, 4, 16, 11, 25, 10, 90, DateTimeKind.Local).AddTicks(6121)
                        },
                        new
                        {
                            Id = 3,
                            Department = "Finance",
                            FullName = "ala kammoun",
                            JoiningDate = new DateTime(2024, 4, 16, 11, 25, 10, 90, DateTimeKind.Local).AddTicks(6122)
                        },
                        new
                        {
                            Id = 4,
                            Department = "Marketing",
                            FullName = "yasmine abed",
                            JoiningDate = new DateTime(2021, 4, 16, 11, 25, 10, 90, DateTimeKind.Local).AddTicks(6124)
                        });
                });

            modelBuilder.Entity("LeaveManagementSystem.Models.LeaveRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("LeaveType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("LeaveRequests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2025, 4, 16, 11, 25, 10, 90, DateTimeKind.Local).AddTicks(6312),
                            EmployeeId = 1,
                            EndDate = new DateTime(2025, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LeaveType = 0,
                            Reason = "Vacation",
                            StartDate = new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2025, 4, 16, 11, 25, 10, 90, DateTimeKind.Local).AddTicks(6315),
                            EmployeeId = 1,
                            EndDate = new DateTime(2025, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LeaveType = 1,
                            Reason = "Flu",
                            StartDate = new DateTime(2025, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 0
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2025, 4, 16, 11, 25, 10, 90, DateTimeKind.Local).AddTicks(6316),
                            EmployeeId = 2,
                            EndDate = new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LeaveType = 2,
                            Reason = "Conference",
                            StartDate = new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 2
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2025, 4, 16, 11, 25, 10, 90, DateTimeKind.Local).AddTicks(6318),
                            EmployeeId = 2,
                            EndDate = new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LeaveType = 0,
                            Reason = "Family trip",
                            StartDate = new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2025, 4, 16, 11, 25, 10, 90, DateTimeKind.Local).AddTicks(6320),
                            EmployeeId = 3,
                            EndDate = new DateTime(2025, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LeaveType = 1,
                            Reason = "Flu symptoms",
                            StartDate = new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 0
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2025, 4, 16, 11, 25, 10, 90, DateTimeKind.Local).AddTicks(6321),
                            EmployeeId = 4,
                            EndDate = new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LeaveType = 2,
                            Reason = "Workshop",
                            StartDate = new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2025, 4, 16, 11, 25, 10, 90, DateTimeKind.Local).AddTicks(6323),
                            EmployeeId = 3,
                            EndDate = new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LeaveType = 0,
                            Reason = "Holiday",
                            StartDate = new DateTime(2025, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2025, 4, 16, 11, 25, 10, 90, DateTimeKind.Local).AddTicks(6325),
                            EmployeeId = 4,
                            EndDate = new DateTime(2025, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LeaveType = 1,
                            Reason = "Flu",
                            StartDate = new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 2
                        });
                });

            modelBuilder.Entity("LeaveManagementSystem.Models.LeaveRequest", b =>
                {
                    b.HasOne("LeaveManagementSystem.Models.Employee", "Employee")
                        .WithMany("LeaveRequests")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("LeaveManagementSystem.Models.Employee", b =>
                {
                    b.Navigation("LeaveRequests");
                });
#pragma warning restore 612, 618
        }
    }
}
