using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLibrary.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hamsters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    FavFood = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Loves = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wins = table.Column<int>(type: "int", nullable: false),
                    Defeats = table.Column<int>(type: "int", nullable: false),
                    Games = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hamsters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WinnerId = table.Column<int>(type: "int", nullable: false),
                    LoserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Hamsters",
                columns: new[] { "Id", "Age", "Defeats", "FavFood", "Games", "ImgName", "IsActive", "Loves", "Name", "Wins" },
                values: new object[,]
                {
                    { 1, 1, 0, "Pizza", 0, "/images/hamsters/hamster-9.jpg", true, "Hjulet", "Rasmus", 0 },
                    { 2, 2, 0, "Fika", 0, "/images/hamsters/hamster-8.jpg", true, "Meetings", "Jimmy", 0 },
                    { 3, 3, 0, "Pancakes", 0, "/images/hamsters/hamster-7.jpg", true, "Intellisense", "Claes", 0 },
                    { 4, 2, 0, "Korv", 0, "/images/hamsters/hamster-1.jpg", true, "Korvar", "Korven", 0 },
                    { 5, 2, 0, "Sallad", 0, "/images/hamsters/hamster-2.jpg", true, "Jumping", "Patrik", 0 },
                    { 6, 4, 0, "Bark", 0, "/images/hamsters/hamster-3.jpg", true, "Kvivksilver", "Pontus", 0 },
                    { 7, 7, 0, "Popcorn", 0, "/images/hamsters/hamster-4.jpg", true, "Berras Bio", "Mikael", 0 },
                    { 8, 10, 0, "Bark", 0, "/images/hamsters/hamster-5.jpg", true, "Träd", "Bävern", 0 },
                    { 9, 2, 0, "Blötmat", 0, "/images/hamsters/hamster-6.jpg", true, "Lekar", "Kattis", 0 },
                    { 10, 3, 0, "FUZEON", 0, "/images/hamsters/hamster-10.jpg", true, "Kids", "Hyaena", 0 },
                    { 11, 3, 0, "Sallad", 0, "/images/hamsters/hamster-11.jpg", true, "Lekar", "Kingfisher", 0 },
                    { 12, 4, 0, "Bark", 0, "/images/hamsters/hamster-12.jpg", true, "Hjulet", "Robin", 0 },
                    { 13, 1, 0, "Sallad", 0, "/images/hamsters/hamster-13.jpg", true, "Lekar", "Lynx", 0 },
                    { 14, 1, 0, "Bark", 0, "/images/hamsters/hamster-14.jpg", true, "Lekar", "Duck", 0 },
                    { 15, 2, 0, "Blötmat", 0, "/images/hamsters/hamster-15.jpg", true, "Hjulet", "Rhinoceros", 0 },
                    { 16, 3, 0, "Sallad", 0, "/images/hamsters/hamster-16.jpg", true, "Lekar", "Red", 0 },
                    { 17, 1, 0, "Bark", 0, "/images/hamsters/hamster-17.jpg", true, "Hjulet", "Gazelle", 0 },
                    { 18, 5, 0, "Sallad", 0, "/images/hamsters/hamster-18.jpg", true, "Lekar", "Dragon", 0 },
                    { 19, 4, 0, "Blötmat", 0, "/images/hamsters/hamster-19.jpg", true, "Lekar", "Lourie", 0 },
                    { 20, 3, 0, "Bark", 0, "/images/hamsters/hamster-20.jpg", true, "Hjulet", "Squirrel", 0 },
                    { 21, 2, 0, "Sallad", 0, "/images/hamsters/hamster-21.jpg", true, "Lekar", "Carmine", 0 },
                    { 22, 2, 0, "Popcorn", 0, "/images/hamsters/hamster-22.jpg", true, "Hjulet", "Snake", 0 },
                    { 23, 1, 0, "Sallad", 0, "/images/hamsters/hamster-23.jpg", true, "Lekar", "Bear", 0 },
                    { 24, 3, 0, "Bark", 0, "/images/hamsters/hamster-24.jpg", true, "Hjulet", "Chickadee", 0 },
                    { 25, 3, 0, "Sallad", 0, "/images/hamsters/hamster-25.jpg", true, "Lekar", "Vervet ", 0 },
                    { 26, 3, 0, "Bark", 0, "/images/hamsters/hamster-26.jpg", true, "Hjulet", "Malagasy ", 0 },
                    { 27, 3, 0, "Sallad", 0, "/images/hamsters/hamster-27.jpg", true, "Lekar", "Malleefowl", 0 },
                    { 28, 1, 0, "Bark", 0, "/images/hamsters/hamster-28.jpg", true, "Hjulet", "Desert", 0 },
                    { 29, 2, 0, "Popcorn", 0, "/images/hamsters/hamster-29.jpg", true, "Lekar", "Kaffir", 0 },
                    { 30, 1, 0, "Sallad", 0, "/images/hamsters/hamster-30.jpg", true, "Lekar", "Nubian ", 0 },
                    { 31, 2, 0, "Popcorn", 0, "/images/hamsters/hamster-31.jpg", true, "Hjulet", "Macaw", 0 },
                    { 32, 3, 0, "Blötmat", 0, "/images/hamsters/hamster-32.jpg", true, "Lekar", "Woodcock", 0 },
                    { 33, 4, 0, "Sallad", 0, "/images/hamsters/hamster-33.jpg", true, "Hjulet", "Eurasian", 0 },
                    { 34, 4, 0, "Gräs", 0, "/images/hamsters/hamster-34.jpg", true, "Lekar", "Mynah", 0 },
                    { 35, 4, 0, "Popcorn", 0, "/images/hamsters/hamster-35.jpg", true, "Lekar", "Sportive", 0 },
                    { 36, 3, 0, "Gräs", 0, "/images/hamsters/hamster-36.jpg", true, "Hjulet", "Marten", 0 },
                    { 37, 2, 0, "Sallad", 0, "/images/hamsters/hamster-37.jpg", true, "Lekar", "Malagasy", 0 },
                    { 38, 1, 0, "Popcorn", 0, "/images/hamsters/hamster-38.jpg", true, "Hjulet", "Grey ", 0 },
                    { 39, 1, 0, "Gräs", 0, "/images/hamsters/hamster-39.jpg", true, "Lekar", "Bear", 0 },
                    { 40, 2, 0, "Sallad", 0, "/images/hamsters/hamster-40.jpg", true, "Hjulet", "Four", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hamsters");

            migrationBuilder.DropTable(
                name: "Matches");
        }
    }
}
