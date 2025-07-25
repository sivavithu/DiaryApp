﻿// <auto-generated />
using System;
using DiaryApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DiaryApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DiaryApp.Models.DiaryEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Creation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DiaryEntries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "This is the content of the first diary entry.",
                            Creation = new DateTime(2025, 7, 22, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "First Entry"
                        },
                        new
                        {
                            Id = 2,
                            Content = "This is the content of the second diary entry.",
                            Creation = new DateTime(2025, 7, 22, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Second Entry"
                        },
                        new
                        {
                            Id = 3,
                            Content = "This is content of the third diary entry.",
                            Creation = new DateTime(2025, 7, 22, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Third Entry"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
