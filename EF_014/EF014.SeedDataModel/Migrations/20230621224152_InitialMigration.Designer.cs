﻿// <auto-generated />
using System;
using EF014.SeedDataModel.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF014.SeedDataModel.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230621224152_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EF014.SeedDataModel.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<decimal>("Price")
                        .HasPrecision(15, 2)
                        .HasColumnType("decimal(15,2)");

                    b.HasKey("Id");

                    b.ToTable("Courses", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseName = "Mathematics",
                            Price = 1000.00m
                        },
                        new
                        {
                            Id = 2,
                            CourseName = "Physics",
                            Price = 2000.00m
                        },
                        new
                        {
                            Id = 3,
                            CourseName = "Chemistry",
                            Price = 1500.00m
                        },
                        new
                        {
                            Id = 4,
                            CourseName = "Biology",
                            Price = 1200.00m
                        },
                        new
                        {
                            Id = 5,
                            CourseName = "CS-50",
                            Price = 3000.00m
                        });
                });

            modelBuilder.Entity("EF014.SeedDataModel.Entities.Enrollment", b =>
                {
                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.Property<int>("ParticipantId")
                        .HasColumnType("int");

                    b.HasKey("SectionId", "ParticipantId");

                    b.HasIndex("ParticipantId");

                    b.ToTable("Enrollments", (string)null);

                    b.HasData(
                        new
                        {
                            SectionId = 6,
                            ParticipantId = 1
                        },
                        new
                        {
                            SectionId = 6,
                            ParticipantId = 2
                        },
                        new
                        {
                            SectionId = 7,
                            ParticipantId = 3
                        },
                        new
                        {
                            SectionId = 7,
                            ParticipantId = 4
                        },
                        new
                        {
                            SectionId = 8,
                            ParticipantId = 5
                        },
                        new
                        {
                            SectionId = 8,
                            ParticipantId = 6
                        },
                        new
                        {
                            SectionId = 9,
                            ParticipantId = 7
                        },
                        new
                        {
                            SectionId = 9,
                            ParticipantId = 8
                        },
                        new
                        {
                            SectionId = 10,
                            ParticipantId = 9
                        },
                        new
                        {
                            SectionId = 10,
                            ParticipantId = 10
                        });
                });

            modelBuilder.Entity("EF014.SeedDataModel.Entities.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<int?>("OfficeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId")
                        .IsUnique()
                        .HasFilter("[OfficeId] IS NOT NULL");

                    b.ToTable("Instructors", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FName = "Ahmed",
                            LName = "Abdullah",
                            OfficeId = 1
                        },
                        new
                        {
                            Id = 2,
                            FName = "Yasmeen",
                            LName = "Mohammed",
                            OfficeId = 2
                        },
                        new
                        {
                            Id = 3,
                            FName = "Khalid",
                            LName = "Hassan",
                            OfficeId = 3
                        },
                        new
                        {
                            Id = 4,
                            FName = "Nadia",
                            LName = "Ali",
                            OfficeId = 4
                        },
                        new
                        {
                            Id = 5,
                            FName = "Omar",
                            LName = "Ibrahim",
                            OfficeId = 5
                        });
                });

            modelBuilder.Entity("EF014.SeedDataModel.Entities.Office", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("OfficeLocation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("OfficeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.ToTable("Offices", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OfficeLocation = "Building A",
                            OfficeName = "Off_05"
                        },
                        new
                        {
                            Id = 2,
                            OfficeLocation = "Building B",
                            OfficeName = "Off_12"
                        },
                        new
                        {
                            Id = 3,
                            OfficeLocation = "Administration",
                            OfficeName = "Off_32"
                        },
                        new
                        {
                            Id = 4,
                            OfficeLocation = "IT Department",
                            OfficeName = "Off_44"
                        },
                        new
                        {
                            Id = 5,
                            OfficeLocation = "IT Department",
                            OfficeName = "Off_43"
                        });
                });

            modelBuilder.Entity("EF014.SeedDataModel.Entities.Participant", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.ToTable("Participants", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("EF014.SeedDataModel.Entities.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("FRI")
                        .HasColumnType("bit");

                    b.Property<bool>("MON")
                        .HasColumnType("bit");

                    b.Property<bool>("SAT")
                        .HasColumnType("bit");

                    b.Property<bool>("SUN")
                        .HasColumnType("bit");

                    b.Property<bool>("THU")
                        .HasColumnType("bit");

                    b.Property<bool>("TUE")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("WED")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Schedules", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FRI = false,
                            MON = true,
                            SAT = false,
                            SUN = true,
                            THU = true,
                            TUE = true,
                            Title = "Daily",
                            WED = true
                        },
                        new
                        {
                            Id = 2,
                            FRI = false,
                            MON = false,
                            SAT = false,
                            SUN = true,
                            THU = true,
                            TUE = true,
                            Title = "DayAfterDay",
                            WED = false
                        },
                        new
                        {
                            Id = 3,
                            FRI = false,
                            MON = true,
                            SAT = false,
                            SUN = false,
                            THU = false,
                            TUE = false,
                            Title = "TwiceAWeek",
                            WED = true
                        },
                        new
                        {
                            Id = 4,
                            FRI = true,
                            MON = false,
                            SAT = true,
                            SUN = false,
                            THU = false,
                            TUE = false,
                            Title = "Weekend",
                            WED = false
                        },
                        new
                        {
                            Id = 5,
                            FRI = true,
                            MON = true,
                            SAT = true,
                            SUN = true,
                            THU = true,
                            TUE = true,
                            Title = "Compact",
                            WED = true
                        });
                });

            modelBuilder.Entity("EF014.SeedDataModel.Entities.Section", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<string>("SectionName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("InstructorId");

                    b.HasIndex("ScheduleId");

                    b.ToTable("Sections", (string)null);
                });

            modelBuilder.Entity("EF014.SeedDataModel.Entities.Corporate", b =>
                {
                    b.HasBaseType("EF014.SeedDataModel.Entities.Participant");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Coporates", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 2,
                            FName = "Noor",
                            LName = "Saleh",
                            Company = "ABC",
                            JobTitle = "Developer"
                        },
                        new
                        {
                            Id = 4,
                            FName = "Huda",
                            LName = "Ahmed",
                            Company = "ABC",
                            JobTitle = "QA"
                        },
                        new
                        {
                            Id = 7,
                            FName = "Yousef",
                            LName = "Farid",
                            Company = "EFG",
                            JobTitle = "Developer"
                        },
                        new
                        {
                            Id = 8,
                            FName = "Layla",
                            LName = "Mustafa",
                            Company = "EFG",
                            JobTitle = "QA"
                        });
                });

            modelBuilder.Entity("EF014.SeedDataModel.Entities.Individual", b =>
                {
                    b.HasBaseType("EF014.SeedDataModel.Entities.Participant");

                    b.Property<bool>("IsIntern")
                        .HasColumnType("bit");

                    b.Property<string>("University")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearOfGraduation")
                        .HasColumnType("int");

                    b.ToTable("Individuals", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FName = "Fatima",
                            LName = "Ali",
                            IsIntern = false,
                            University = "XYZ",
                            YearOfGraduation = 2024
                        },
                        new
                        {
                            Id = 3,
                            FName = "Omar",
                            LName = "Youssef",
                            IsIntern = true,
                            University = "POQ",
                            YearOfGraduation = 2023
                        },
                        new
                        {
                            Id = 5,
                            FName = "Amira",
                            LName = "Tariq",
                            IsIntern = false,
                            University = "POQ",
                            YearOfGraduation = 2025
                        },
                        new
                        {
                            Id = 6,
                            FName = "Zainab",
                            LName = "Ismail",
                            IsIntern = true,
                            University = "POQ",
                            YearOfGraduation = 2023
                        },
                        new
                        {
                            Id = 9,
                            FName = "Mohammed",
                            LName = "Adel",
                            IsIntern = false,
                            University = "XYZ",
                            YearOfGraduation = 2024
                        },
                        new
                        {
                            Id = 10,
                            FName = "Samira",
                            LName = "Nabil",
                            IsIntern = false,
                            University = "XYZ",
                            YearOfGraduation = 2024
                        });
                });

            modelBuilder.Entity("EF014.SeedDataModel.Entities.Enrollment", b =>
                {
                    b.HasOne("EF014.SeedDataModel.Entities.Participant", "Participant")
                        .WithMany()
                        .HasForeignKey("ParticipantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF014.SeedDataModel.Entities.Section", "Section")
                        .WithMany()
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Participant");

                    b.Navigation("Section");
                });

            modelBuilder.Entity("EF014.SeedDataModel.Entities.Instructor", b =>
                {
                    b.HasOne("EF014.SeedDataModel.Entities.Office", "Office")
                        .WithOne("Instructor")
                        .HasForeignKey("EF014.SeedDataModel.Entities.Instructor", "OfficeId");

                    b.Navigation("Office");
                });

            modelBuilder.Entity("EF014.SeedDataModel.Entities.Section", b =>
                {
                    b.HasOne("EF014.SeedDataModel.Entities.Course", "Course")
                        .WithMany("Sections")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF014.SeedDataModel.Entities.Instructor", "Instructor")
                        .WithMany("Sections")
                        .HasForeignKey("InstructorId");

                    b.HasOne("EF014.SeedDataModel.Entities.Schedule", "Schedule")
                        .WithMany("Sections")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("EF014.SeedDataModel.Entities.TimeSlot", "TimeSlot", b1 =>
                        {
                            b1.Property<int>("SectionId")
                                .HasColumnType("int");

                            b1.Property<TimeSpan>("EndTime")
                                .HasColumnType("time")
                                .HasColumnName("EndTime");

                            b1.Property<TimeSpan>("StartTime")
                                .HasColumnType("time")
                                .HasColumnName("StartTime");

                            b1.HasKey("SectionId");

                            b1.ToTable("Sections");

                            b1.WithOwner()
                                .HasForeignKey("SectionId");
                        });

                    b.Navigation("Course");

                    b.Navigation("Instructor");

                    b.Navigation("Schedule");

                    b.Navigation("TimeSlot")
                        .IsRequired();
                });

            modelBuilder.Entity("EF014.SeedDataModel.Entities.Corporate", b =>
                {
                    b.HasOne("EF014.SeedDataModel.Entities.Participant", null)
                        .WithOne()
                        .HasForeignKey("EF014.SeedDataModel.Entities.Corporate", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EF014.SeedDataModel.Entities.Individual", b =>
                {
                    b.HasOne("EF014.SeedDataModel.Entities.Participant", null)
                        .WithOne()
                        .HasForeignKey("EF014.SeedDataModel.Entities.Individual", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EF014.SeedDataModel.Entities.Course", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("EF014.SeedDataModel.Entities.Instructor", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("EF014.SeedDataModel.Entities.Office", b =>
                {
                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("EF014.SeedDataModel.Entities.Schedule", b =>
                {
                    b.Navigation("Sections");
                });
#pragma warning restore 612, 618
        }
    }
}
