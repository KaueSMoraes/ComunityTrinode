﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Trinode.Infrastructure.Data;

#nullable disable

namespace Trinode.Infrastructure.Data.Migrations
{
    [DbContext(typeof(TrinodeDbContext))]
    partial class TrinodeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Trinode.Domain.Entities.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INT")
                        .HasColumnName("CategoryId");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DATETIME")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("DATETIME")
                        .HasColumnName("DeletedDate");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Description");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("ImageUrl");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Name");

                    b.Property<double>("Price")
                        .HasColumnType("FLOAT")
                        .HasColumnName("Price");

                    b.Property<string>("Technology")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Technology");

                    b.Property<double>("TotalHours")
                        .HasColumnType("FLOAT")
                        .HasColumnName("TotalHours");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("DATETIME")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id")
                        .HasName("PK_Courses");

                    b.ToTable("Courses", (string)null);
                });

            modelBuilder.Entity("Trinode.Domain.Entities.Lecture", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DATETIME")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("DATETIME")
                        .HasColumnName("DeletedDate");

                    b.Property<string>("GithubUrl")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("GithubUrl");

                    b.Property<Guid>("ModuleGuid")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ModuleGuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Name");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("DATETIME")
                        .HasColumnName("UpdatedDate");

                    b.Property<string>("VideoUrl")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("VideoUrl");

                    b.HasKey("Id")
                        .HasName("PK_Lectures");

                    b.ToTable("Lectures", (string)null);
                });

            modelBuilder.Entity("Trinode.Domain.Entities.Module", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DATETIME")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("DATETIME")
                        .HasColumnName("DeletedDate");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Description");

                    b.Property<Guid>("FK_Courses_Modules")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Lectures")
                        .HasColumnType("INT")
                        .HasColumnName("Lectures");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Name");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("DATETIME")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id")
                        .HasName("PK_Modules");

                    b.HasIndex("FK_Courses_Modules");

                    b.ToTable("Modules", (string)null);
                });

            modelBuilder.Entity("Trinode.Domain.Entities.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("CEP");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("CPF");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DATETIME")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("DATETIME")
                        .HasColumnName("DeletedDate");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Description");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Email");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Endereco");

                    b.Property<string>("HashPassword")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Password");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("ImageUrl");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Phone");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Salt");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("DATETIME")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id")
                        .HasName("PK_Teachers");

                    b.ToTable("Teachers", (string)null);
                });

            modelBuilder.Entity("Trinode.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("CEP");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("CPF");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DATETIME")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("DATETIME")
                        .HasColumnName("DeletedDate");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Email");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Endereco");

                    b.Property<string>("HashPassword")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Password");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Phone");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Salt");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("DATETIME")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id")
                        .HasName("PK_Users");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("TeacherCourse", b =>
                {
                    b.Property<Guid>("Courses")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Courses", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("TeacherCourse");
                });

            modelBuilder.Entity("UserRole", b =>
                {
                    b.Property<Guid>("Courses")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Courses", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("Trinode.Domain.Entities.Module", b =>
                {
                    b.HasOne("Trinode.Domain.Entities.Course", "Course")
                        .WithMany("Modules")
                        .HasForeignKey("FK_Courses_Modules")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("TeacherCourse", b =>
                {
                    b.HasOne("Trinode.Domain.Entities.Teacher", null)
                        .WithMany()
                        .HasForeignKey("Courses")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Teacher_CourseId");

                    b.HasOne("Trinode.Domain.Entities.Course", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Course_TeacherId");
                });

            modelBuilder.Entity("UserRole", b =>
                {
                    b.HasOne("Trinode.Domain.Entities.Course", null)
                        .WithMany()
                        .HasForeignKey("Courses")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_UserRole_CourseId");

                    b.HasOne("Trinode.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_UserRole_UserId");
                });

            modelBuilder.Entity("Trinode.Domain.Entities.Course", b =>
                {
                    b.Navigation("Modules");
                });
#pragma warning restore 612, 618
        }
    }
}
