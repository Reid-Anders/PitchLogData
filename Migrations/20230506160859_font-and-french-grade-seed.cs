using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PitchLogData.Migrations
{
    public partial class fontandfrenchgradeseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "ID", "Type", "Value" },
                values: new object[,]
                {
                    { 48, 5, "3" },
                    { 49, 5, "4" },
                    { 50, 5, "5" },
                    { 51, 5, "5+" },
                    { 52, 5, "6a" },
                    { 53, 5, "6a+" },
                    { 54, 5, "6b" },
                    { 55, 5, "6b+" },
                    { 56, 5, "6c" },
                    { 57, 5, "6c+" },
                    { 58, 5, "7a" },
                    { 59, 5, "7a+" },
                    { 60, 5, "7b" },
                    { 61, 5, "7b+" },
                    { 62, 5, "7c" },
                    { 63, 5, "7c+" },
                    { 64, 5, "8a" },
                    { 65, 5, "8a+" },
                    { 66, 5, "8b" },
                    { 67, 5, "8b+" },
                    { 68, 5, "8c" },
                    { 69, 5, "8c+" },
                    { 70, 5, "9a" },
                    { 71, 2, "4c" },
                    { 72, 2, "5a" },
                    { 73, 2, "5b" },
                    { 74, 2, "5c" },
                    { 75, 2, "6a" },
                    { 76, 2, "6a+" },
                    { 77, 2, "6b" },
                    { 78, 2, "6b+" },
                    { 79, 2, "6c" },
                    { 80, 2, "6c+" },
                    { 81, 2, "7a" },
                    { 82, 2, "7a+" },
                    { 83, 2, "7b" },
                    { 84, 2, "7b+" },
                    { 85, 2, "7c" },
                    { 86, 2, "7c+" },
                    { 87, 2, "8a" },
                    { 88, 2, "8a+" },
                    { 89, 2, "8b" }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "ID", "Type", "Value" },
                values: new object[,]
                {
                    { 90, 2, "8b+" },
                    { 91, 2, "8c" },
                    { 92, 2, "8c+" },
                    { 93, 2, "9a" },
                    { 94, 2, "9a+" },
                    { 95, 2, "9b" },
                    { 96, 2, "9b+" },
                    { 97, 2, "9c" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 97);
        }
    }
}
