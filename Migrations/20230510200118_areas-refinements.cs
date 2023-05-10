using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PitchLogData.Migrations
{
    public partial class areasrefinements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NearestTown",
                table: "Areas",
                newName: "Region");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Areas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Municipality",
                table: "Areas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Areas");

            migrationBuilder.DropColumn(
                name: "Municipality",
                table: "Areas");

            migrationBuilder.RenameColumn(
                name: "Region",
                table: "Areas",
                newName: "NearestTown");
        }
    }
}
