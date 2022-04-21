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
            #region AddHamstrar
                new Hamster
                {
                    Id = 1,
                    Name = "Rasmus",
                    Age = 1,
                    ImgName = "/images/hamsters/hamster-9.jpg",
                    Loves = "Wheels",
                    FavFood = "Pizza"
                },
                new Hamster
                {
                    Id=2,
                    Name = "Jimmy",
                    Age = 2,
                    ImgName = "/images/hamsters/hamster-8.jpg",
                    Loves = "Meetings",
                    FavFood = "Fika"
                },
                new Hamster
                {
                    Id = 3,
                    Name = "Claes",
                    Age = 3,
                    ImgName = "/images/hamsters/hamster-7.jpg",
                    Loves = "Intellisense",
                    FavFood = "Pancakes"
                },
                new Hamster
                {
                    Id = 4,
                    Name = "Korven",
                    Age = 2,
                    ImgName = "/images/hamsters/hamster-1.jpg",
                    Loves = "Korvar",
                    FavFood = "Korv"
                },
                new Hamster
                {
                    Id = 5,
                    Name = "Patrik",
                    Age = 2,
                    ImgName = "/images/hamsters/hamster-2.jpg",
                    Loves = "Jumping",
                    FavFood = "Sallad"
                },
                new Hamster
                {
                    Id = 6,
                    Name = "Pontus",
                    Age = 4,
                    ImgName = "/images/hamsters/hamster-3.jpg",
                    Loves = "Kvivksilver",
                    FavFood = "Bark"
                },
                new Hamster
                {
                    Id = 7,
                    Name = "Mikael",
                    Age = 7,
                    ImgName = "/images/hamsters/hamster-4.jpg",
                    Loves = "Berras Bio",
                    FavFood = "Popcorn"
                },
                new Hamster
                {
                    Id= 8,
                    Name = "Bävern",
                    Age = 10,
                    ImgName = "/images/hamsters/hamster-5.jpg",
                    Loves = "Träd",
                    FavFood = "Bark"
                },
                new Hamster
                {
                    Id = 9,
                    Name = "Kattis",
                    Age = 6,
                    ImgName = "/images/hamsters/hamster-6.jpg",
                    Loves = "Lekar",
                    FavFood = "Blötmat"
                }
                ) ;
            #endregion
            
        }
        public DbSet<Hamster> Hamsters { get; set; }
        public DbSet<Match> Matches { get; set; }
    }
}
