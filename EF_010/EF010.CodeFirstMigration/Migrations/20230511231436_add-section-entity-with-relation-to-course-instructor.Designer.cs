﻿// <auto-generated />
using System;
using EF010.CodeFirstMigration.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF010.CodeFirstMigration.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230511231436_add-section-entity-with-relation-to-course-instructor")]
    partial class addsectionentitywithrelationtocourseinstructor
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EF010.CodeFirstMigration.Entities.Course", b =>
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
                            CourseName = "Mathmatics",
                            Price = 1000m
                        },
                        new
                        {
                            Id = 2,
                            CourseName = "Physics",
                            Price = 2000m
                        },
                        new
                        {
                            Id = 3,
                            CourseName = "Chemistry",
                            Price = 1500m
                        },
                        new
                        {
                            Id = 4,
                            CourseName = "Biology",
                            Price = 1200m
                        },
                        new
                        {
                            Id = 5,
                            CourseName = "CS-50",
                            Price = 3000m
                        });
                });

            modelBuilder.Entity("EF010.CodeFirstMigration.Entities.Instructor", b =>
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
                            LName = "Yasmeen",
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
                            FName = "Ahmed",
                            LName = "Abdullah",
                            OfficeId = 5
                        });
                });

            modelBuilder.Entity("EF010.CodeFirstMigration.Entities.Office", b =>
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
                            OfficeLocation = "building A",
                            OfficeName = "Off_05"
                        },
                        new
                        {
                            Id = 2,
                            OfficeLocation = "building B",
                            OfficeName = "Off_12"
                        },
                        new
                        {
                            Id = 3,
                            OfficeLocation = "Adminstration",
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

            modelBuilder.Entity("EF010.CodeFirstMigration.Entities.Section", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int");

                    b.Property<string>("SectionName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("InstructorId");

                    b.ToTable("Sections", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            InstructorId = 1,
                            SectionName = "S_MA1"
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 1,
                            InstructorId = 2,
                            SectionName = "S_MA2"
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 2,
                            InstructorId = 1,
                            SectionName = "S_PH1"
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 2,
                            InstructorId = 3,
                            SectionName = "S_PH2"
                        },
                        new
                        {
                            Id = 5,
                            CourseId = 3,
                            InstructorId = 2,
                            SectionName = "S_CH1"
                        },
                        new
                        {
                            Id = 6,
                            CourseId = 3,
                            InstructorId = 3,
                            SectionName = "S_CH2"
                        },
                        new
                        {
                            Id = 7,
                            CourseId = 4,
                            InstructorId = 4,
                            SectionName = "S_BI1"
                        },
                        new
                        {
                            Id = 8,
                            CourseId = 4,
                            InstructorId = 5,
                            SectionName = "S_BI2"
                        },
                        new
                        {
                            Id = 9,
                            CourseId = 5,
                            InstructorId = 4,
                            SectionName = "S_CS1"
                        },
                        new
                        {
                            Id = 10,
                            CourseId = 5,
                            InstructorId = 5,
                            SectionName = "S_CS2"
                        },
                        new
                        {
                            Id = 11,
                            CourseId = 5,
                            InstructorId = 4,
                            SectionName = "S_CS3"
                        });
                });

            modelBuilder.Entity("EF010.CodeFirstMigration.Entities.Instructor", b =>
                {
                    b.HasOne("EF010.CodeFirstMigration.Entities.Office", "Office")
                        .WithOne("Instructor")
                        .HasForeignKey("EF010.CodeFirstMigration.Entities.Instructor", "OfficeId");

                    b.Navigation("Office");
                });

            modelBuilder.Entity("EF010.CodeFirstMigration.Entities.Section", b =>
                {
                    b.HasOne("EF010.CodeFirstMigration.Entities.Course", "Course")
                        .WithMany("Sections")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF010.CodeFirstMigration.Entities.Instructor", "Instructor")
                        .WithMany("Sections")
                        .HasForeignKey("InstructorId");

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("EF010.CodeFirstMigration.Entities.Course", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("EF010.CodeFirstMigration.Entities.Instructor", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("EF010.CodeFirstMigration.Entities.Office", b =>
                {
                    b.Navigation("Instructor");
                });
#pragma warning restore 612, 618
        }
    }
}
