using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLibrary.Migrations
{
    public partial class MatchesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Hamsters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImgName",
                table: "Hamsters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hamster1Id = table.Column<int>(type: "int", nullable: false),
                    Hamster2Id = table.Column<int>(type: "int", nullable: false),
                    Hamster1Win = table.Column<int>(type: "int", nullable: false),
                    Hamster2Win = table.Column<int>(type: "int", nullable: false),
                    HamsterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matches_Hamsters_HamsterId",
                        column: x => x.HamsterId,
                        principalTable: "Hamsters",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImgName",
                value: "/images/hamsters/hamster-9.jpg");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImgName",
                value: "/images/hamsters/hamster-8.jpg");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImgName",
                value: "/images/hamsters/hamster-7.jpg");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FavFood", "Loves", "Name" },
                values: new object[] { "Korv", "Korvar", "Korven" });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FavFood", "Loves" },
                values: new object[] { "Sallad", "Jumping" });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FavFood", "Loves" },
                values: new object[] { "Bark", "Kvivksilver" });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FavFood", "Loves" },
                values: new object[] { "Popcorn", "Berras Bio" });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FavFood", "Loves", "Name" },
                values: new object[] { "Bark", "Träd", "Bävern" });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FavFood", "Loves", "Name" },
                values: new object[] { "Blötmat", "Lekar", "Kattis" });

            migrationBuilder.CreateIndex(
                name: "IX_Matches_HamsterId",
                table: "Matches",
                column: "HamsterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Hamsters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImgName",
                table: "Hamsters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImgName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImgName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImgName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FavFood", "Loves", "Name" },
                values: new object[] { null, null, "Rasmus" });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FavFood", "Loves" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FavFood", "Loves" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FavFood", "Loves" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FavFood", "Loves", "Name" },
                values: new object[] { null, null, "Claes" });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FavFood", "Loves", "Name" },
                values: new object[] { null, null, "Jimmy" });
        }
    }
}
