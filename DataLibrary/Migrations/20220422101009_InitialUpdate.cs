using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLibrary.Migrations
{
    public partial class InitialUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Hamsters_HamsterId",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_HamsterId",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "HamsterId",
                table: "Matches");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HamsterId",
                table: "Matches",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Matches_HamsterId",
                table: "Matches",
                column: "HamsterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Hamsters_HamsterId",
                table: "Matches",
                column: "HamsterId",
                principalTable: "Hamsters",
                principalColumn: "Id");
        }
    }
}
