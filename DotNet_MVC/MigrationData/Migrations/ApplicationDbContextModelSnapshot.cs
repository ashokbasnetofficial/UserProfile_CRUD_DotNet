﻿// <auto-generated />
using Dotnet_Mvc.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DotnetMvc.MigrationData.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Dotnet_Mvc.Models.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("UserProfile");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmailAddress = "ashoknbasnetofficial@gmail.com",
                            FullName = "Ashok Basnet",
                            JobTitle = "Jonior Developer",
                            PhoneNumber = "9863614474"
                        },
                        new
                        {
                            Id = 2,
                            EmailAddress = "ashoknbasnetofficial@gmail.com",
                            FullName = "Rajan Rijal",
                            JobTitle = "Jonior Developer",
                            PhoneNumber = "9863614474"
                        },
                        new
                        {
                            Id = 3,
                            EmailAddress = "ashoknbasnetofficial@gmail.com",
                            FullName = "Anu Thapa",
                            JobTitle = "Techhincal Advistor",
                            PhoneNumber = "9863614474"
                        },
                        new
                        {
                            Id = 4,
                            EmailAddress = "rashikabhattarai59@gmail.com",
                            FullName = "Rashika Bhattarai",
                            JobTitle = "Student",
                            PhoneNumber = "9863614474"
                        },
                        new
                        {
                            Id = 5,
                            EmailAddress = "basnetpurna560@gmail.com",
                            FullName = "Purna Bahadur Basnet",
                            JobTitle = "Branch Manager",
                            PhoneNumber = "9844666715"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}