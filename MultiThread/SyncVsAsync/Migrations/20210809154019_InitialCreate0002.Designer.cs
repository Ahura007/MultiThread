﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SyncVsAsync.Context;

namespace SyncVsAsync.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210809154019_InitialCreate0002")]
    partial class InitialCreate0002
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SyncVsAsync.Model.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("GradeId")
                        .HasColumnType("int");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName15")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName16")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("SyncVsAsync.Model.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TeacherName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherId");

                    b.ToTable("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}
