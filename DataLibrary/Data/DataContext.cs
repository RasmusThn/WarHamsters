global using DataLibrary.Models;
global using Microsoft.EntityFrameworkCore;
global using DataLibrary.Services;
global using DataLibrary.Data;
global using DataLibrary.Repository;

namespace DataLibrary.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hamster>().HasData(
                new Hamster
                {
                    Id = 1,
                    Name = "Rasmus",
                    Age = 1,
                    ImgName = "",
                    Loves = "Wheels",
                    FavFood = "Pizza"
                },
                new Hamster
                {
                    Id = 2,
                    Name = "Jimmy",
                    Age = 2,
                    ImgName = "",
                    Loves = "Meetings",
                    FavFood = "Fika"
                },
                new Hamster
                {
                    Id = 3,
                    Name = "Claes",
                    Age = 3,
                    ImgName = "",
                    Loves = "Intellisense",
                    FavFood = "Pancakes"
                }, new Hamster
                {
                    Id = 4,
                    Name = "Rasmus",
                    Age = 2,
                    ImgName = "/images/hamsters/hamster-1.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 5,
                    Name = "Patrik",
                    Age = 2,
                    ImgName = "/images/hamsters/hamster-2.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 6,
                    Name = "Pontus",
                    Age = 4,
                    ImgName = "/images/hamsters/hamster-3.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 7,
                    Name = "Mikael",
                    Age = 7,
                    ImgName = "/images/hamsters/hamster-4.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 8,
                    Name = "Claes",
                    Age = 10,
                    ImgName = "/images/hamsters/hamster-5.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 9,
                    Name = "Jimmy",
                    Age = 6,
                    ImgName = "/images/hamsters/hamster-6.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }
                );
        }
        public DbSet<Hamster> Hamsters { get; set; }
    }
}
