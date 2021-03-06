// <auto-generated />
using System;
using DataLibrary.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataLibrary.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220504131145_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Games")
                        .HasColumnType("int");

                    b.Property<string>("ImgName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Loves")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

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
                            ImgName = "/images/hamsters/hamster-9.jpg",
                            IsActive = true,
                            Loves = "Hjulet",
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
                            ImgName = "/images/hamsters/hamster-8.jpg",
                            IsActive = true,
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
                            ImgName = "/images/hamsters/hamster-7.jpg",
                            IsActive = true,
                            Loves = "Intellisense",
                            Name = "Claes",
                            Wins = 0
                        },
                        new
                        {
                            Id = 4,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Korv",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-1.jpg",
                            IsActive = true,
                            Loves = "Korvar",
                            Name = "Korven",
                            Wins = 0
                        },
                        new
                        {
                            Id = 5,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Sallad",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-2.jpg",
                            IsActive = true,
                            Loves = "Jumping",
                            Name = "Patrik",
                            Wins = 0
                        },
                        new
                        {
                            Id = 6,
                            Age = 4,
                            Defeats = 0,
                            FavFood = "Bark",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-3.jpg",
                            IsActive = true,
                            Loves = "Kvivksilver",
                            Name = "Pontus",
                            Wins = 0
                        },
                        new
                        {
                            Id = 7,
                            Age = 7,
                            Defeats = 0,
                            FavFood = "Popcorn",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-4.jpg",
                            IsActive = true,
                            Loves = "Berras Bio",
                            Name = "Mikael",
                            Wins = 0
                        },
                        new
                        {
                            Id = 8,
                            Age = 10,
                            Defeats = 0,
                            FavFood = "Bark",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-5.jpg",
                            IsActive = true,
                            Loves = "Träd",
                            Name = "Bävern",
                            Wins = 0
                        },
                        new
                        {
                            Id = 9,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Blötmat",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-6.jpg",
                            IsActive = true,
                            Loves = "Lekar",
                            Name = "Kattis",
                            Wins = 0
                        },
                        new
                        {
                            Id = 10,
                            Age = 3,
                            Defeats = 0,
                            FavFood = "FUZEON",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-10.jpg",
                            IsActive = true,
                            Loves = "Kids",
                            Name = "Hyaena",
                            Wins = 0
                        },
                        new
                        {
                            Id = 11,
                            Age = 3,
                            Defeats = 0,
                            FavFood = "Sallad",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-11.jpg",
                            IsActive = true,
                            Loves = "Lekar",
                            Name = "Kingfisher",
                            Wins = 0
                        },
                        new
                        {
                            Id = 12,
                            Age = 4,
                            Defeats = 0,
                            FavFood = "Bark",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-12.jpg",
                            IsActive = true,
                            Loves = "Hjulet",
                            Name = "Robin",
                            Wins = 0
                        },
                        new
                        {
                            Id = 13,
                            Age = 1,
                            Defeats = 0,
                            FavFood = "Sallad",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-13.jpg",
                            IsActive = true,
                            Loves = "Lekar",
                            Name = "Lynx",
                            Wins = 0
                        },
                        new
                        {
                            Id = 14,
                            Age = 1,
                            Defeats = 0,
                            FavFood = "Bark",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-14.jpg",
                            IsActive = true,
                            Loves = "Lekar",
                            Name = "Duck",
                            Wins = 0
                        },
                        new
                        {
                            Id = 15,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Blötmat",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-15.jpg",
                            IsActive = true,
                            Loves = "Hjulet",
                            Name = "Rhinoceros",
                            Wins = 0
                        },
                        new
                        {
                            Id = 16,
                            Age = 3,
                            Defeats = 0,
                            FavFood = "Sallad",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-16.jpg",
                            IsActive = true,
                            Loves = "Lekar",
                            Name = "Red",
                            Wins = 0
                        },
                        new
                        {
                            Id = 17,
                            Age = 1,
                            Defeats = 0,
                            FavFood = "Bark",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-17.jpg",
                            IsActive = true,
                            Loves = "Hjulet",
                            Name = "Gazelle",
                            Wins = 0
                        },
                        new
                        {
                            Id = 18,
                            Age = 5,
                            Defeats = 0,
                            FavFood = "Sallad",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-18.jpg",
                            IsActive = true,
                            Loves = "Lekar",
                            Name = "Dragon",
                            Wins = 0
                        },
                        new
                        {
                            Id = 19,
                            Age = 4,
                            Defeats = 0,
                            FavFood = "Blötmat",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-19.jpg",
                            IsActive = true,
                            Loves = "Lekar",
                            Name = "Lourie",
                            Wins = 0
                        },
                        new
                        {
                            Id = 20,
                            Age = 3,
                            Defeats = 0,
                            FavFood = "Bark",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-20.jpg",
                            IsActive = true,
                            Loves = "Hjulet",
                            Name = "Squirrel",
                            Wins = 0
                        },
                        new
                        {
                            Id = 21,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Sallad",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-21.jpg",
                            IsActive = true,
                            Loves = "Lekar",
                            Name = "Carmine",
                            Wins = 0
                        },
                        new
                        {
                            Id = 22,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Popcorn",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-22.jpg",
                            IsActive = true,
                            Loves = "Hjulet",
                            Name = "Snake",
                            Wins = 0
                        },
                        new
                        {
                            Id = 23,
                            Age = 1,
                            Defeats = 0,
                            FavFood = "Sallad",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-23.jpg",
                            IsActive = true,
                            Loves = "Lekar",
                            Name = "Bear",
                            Wins = 0
                        },
                        new
                        {
                            Id = 24,
                            Age = 3,
                            Defeats = 0,
                            FavFood = "Bark",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-24.jpg",
                            IsActive = true,
                            Loves = "Hjulet",
                            Name = "Chickadee",
                            Wins = 0
                        },
                        new
                        {
                            Id = 25,
                            Age = 3,
                            Defeats = 0,
                            FavFood = "Sallad",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-25.jpg",
                            IsActive = true,
                            Loves = "Lekar",
                            Name = "Vervet ",
                            Wins = 0
                        },
                        new
                        {
                            Id = 26,
                            Age = 3,
                            Defeats = 0,
                            FavFood = "Bark",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-26.jpg",
                            IsActive = true,
                            Loves = "Hjulet",
                            Name = "Malagasy ",
                            Wins = 0
                        },
                        new
                        {
                            Id = 27,
                            Age = 3,
                            Defeats = 0,
                            FavFood = "Sallad",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-27.jpg",
                            IsActive = true,
                            Loves = "Lekar",
                            Name = "Malleefowl",
                            Wins = 0
                        },
                        new
                        {
                            Id = 28,
                            Age = 1,
                            Defeats = 0,
                            FavFood = "Bark",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-28.jpg",
                            IsActive = true,
                            Loves = "Hjulet",
                            Name = "Desert",
                            Wins = 0
                        },
                        new
                        {
                            Id = 29,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Popcorn",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-29.jpg",
                            IsActive = true,
                            Loves = "Lekar",
                            Name = "Kaffir",
                            Wins = 0
                        },
                        new
                        {
                            Id = 30,
                            Age = 1,
                            Defeats = 0,
                            FavFood = "Sallad",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-30.jpg",
                            IsActive = true,
                            Loves = "Lekar",
                            Name = "Nubian ",
                            Wins = 0
                        },
                        new
                        {
                            Id = 31,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Popcorn",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-31.jpg",
                            IsActive = true,
                            Loves = "Hjulet",
                            Name = "Macaw",
                            Wins = 0
                        },
                        new
                        {
                            Id = 32,
                            Age = 3,
                            Defeats = 0,
                            FavFood = "Blötmat",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-32.jpg",
                            IsActive = true,
                            Loves = "Lekar",
                            Name = "Woodcock",
                            Wins = 0
                        },
                        new
                        {
                            Id = 33,
                            Age = 4,
                            Defeats = 0,
                            FavFood = "Sallad",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-33.jpg",
                            IsActive = true,
                            Loves = "Hjulet",
                            Name = "Eurasian",
                            Wins = 0
                        },
                        new
                        {
                            Id = 34,
                            Age = 4,
                            Defeats = 0,
                            FavFood = "Gräs",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-34.jpg",
                            IsActive = true,
                            Loves = "Lekar",
                            Name = "Mynah",
                            Wins = 0
                        },
                        new
                        {
                            Id = 35,
                            Age = 4,
                            Defeats = 0,
                            FavFood = "Popcorn",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-35.jpg",
                            IsActive = true,
                            Loves = "Lekar",
                            Name = "Sportive",
                            Wins = 0
                        },
                        new
                        {
                            Id = 36,
                            Age = 3,
                            Defeats = 0,
                            FavFood = "Gräs",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-36.jpg",
                            IsActive = true,
                            Loves = "Hjulet",
                            Name = "Marten",
                            Wins = 0
                        },
                        new
                        {
                            Id = 37,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Sallad",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-37.jpg",
                            IsActive = true,
                            Loves = "Lekar",
                            Name = "Malagasy",
                            Wins = 0
                        },
                        new
                        {
                            Id = 38,
                            Age = 1,
                            Defeats = 0,
                            FavFood = "Popcorn",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-38.jpg",
                            IsActive = true,
                            Loves = "Hjulet",
                            Name = "Grey ",
                            Wins = 0
                        },
                        new
                        {
                            Id = 39,
                            Age = 1,
                            Defeats = 0,
                            FavFood = "Gräs",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-39.jpg",
                            IsActive = true,
                            Loves = "Lekar",
                            Name = "Bear",
                            Wins = 0
                        },
                        new
                        {
                            Id = 40,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Sallad",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-40.jpg",
                            IsActive = true,
                            Loves = "Hjulet",
                            Name = "Four",
                            Wins = 0
                        });
                });

            modelBuilder.Entity("DataLibrary.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("LoserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<int>("WinnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Matches");
                });
#pragma warning restore 612, 618
        }
    }
}
