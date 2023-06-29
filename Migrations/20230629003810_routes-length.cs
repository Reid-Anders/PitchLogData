using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PitchLogData.Migrations
{
    public partial class routeslength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LengthUnits",
                table: "Routes");

            migrationBuilder.AlterColumn<int>(
                name: "Length",
                table: "Routes",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Length",
                table: "Routes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "LengthUnits",
                table: "Routes",
                type: "int",
                nullable: true);
        }
    }
}
