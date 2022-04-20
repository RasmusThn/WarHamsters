﻿// <auto-generated />
using DataLibrary.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataLibrary.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DataLibrary.Models.Hamster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Defeats")
                        .HasColumnType("int");

                    b.Property<string>("FavFood")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Games")
                        .HasColumnType("int");

                    b.Property<string>("ImgName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Loves")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Wins")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Hamsters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 1,
                            Defeats = 0,
                            FavFood = "Pizza",
                            Games = 0,
                            ImgName = "",
                            Loves = "Wheels",
                            Name = "Rasmus",
                            Wins = 0
                        },
                        new
                        {
                            Id = 2,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Fika",
                            Games = 0,
                            ImgName = "",
                            Loves = "Meetings",
                            Name = "Jimmy",
                            Wins = 0
                        },
                        new
                        {
                            Id = 3,
                            Age = 3,
                            Defeats = 0,
                            FavFood = "Pancakes",
                            Games = 0,
                            ImgName = "",
                            Loves = "Intellisense",
                            Name = "Claes",
                            Wins = 0
                        },
                        new
                        {
                            Id = 4,
                            Age = 2,
                            Defeats = 0,
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-1.jpg",
                            Name = "Rasmus",
                            Wins = 0
                        },
                        new
                        {
                            Id = 5,
                            Age = 2,
                            Defeats = 0,
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-2.jpg",
                            Name = "Patrik",
                            Wins = 0
                        },
                        new
                        {
                            Id = 6,
                            Age = 4,
                            Defeats = 0,
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-3.jpg",
                            Name = "Pontus",
                            Wins = 0
                        },
                        new
                        {
                            Id = 7,
                            Age = 7,
                            Defeats = 0,
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-4.jpg",
                            Name = "Mikael",
                            Wins = 0
                        },
                        new
                        {
                            Id = 8,
                            Age = 10,
                            Defeats = 0,
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-5.jpg",
                            Name = "Claes",
                            Wins = 0
                        },
                        new
                        {
                            Id = 9,
                            Age = 6,
                            Defeats = 0,
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-6.jpg",
                            Name = "Jimmy",
                            Wins = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
