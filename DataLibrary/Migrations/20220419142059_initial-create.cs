using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLibrary.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hamsters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    FavFood = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Loves = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wins = table.Column<int>(type: "int", nullable: false),
                    Defeats = table.Column<int>(type: "int", nullable: false),
                    Games = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hamsters", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Hamsters",
                columns: new[] { "Id", "Age", "Defeats", "FavFood", "Games", "ImgName", "Loves", "Name", "Wins" },
                values: new object[,]
                {
                    { 1, 1, 0, "Pizza", 0, "", "Wheels", "Rasmus", 0 },
                    { 2, 2, 0, "Fika", 0, "", "Meetings", "Jimmy", 0 },
                    { 3, 3, 0, "Pancakes", 0, "", "Intellisense", "Claes", 0 },
                    { 4, 2, 0, null, 0, "/images/hamsters/hamster-1.jpg", null, "Rasmus", 0 },
                    { 5, 2, 0, null, 0, "/images/hamsters/hamster-2.jpg", null, "Patrik", 0 },
                    { 6, 4, 0, null, 0, "/images/hamsters/hamster-3.jpg", null, "Pontus", 0 },
                    { 7, 7, 0, null, 0, "/images/hamsters/hamster-4.jpg", null, "Mikael", 0 },
                    { 8, 10, 0, null, 0, "/images/hamsters/hamster-5.jpg", null, "Claes", 0 },
                    { 9, 6, 0, null, 0, "/images/hamsters/hamster-6.jpg", null, "Jimmy", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hamsters");
        }
    }
}
