using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PitchLogData.Migrations
{
    public partial class addgradesdbset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boulders_Grade_GradeID",
                table: "Boulders");

            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Grade_GradeID",
                table: "Routes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Grade",
                table: "Grade");

            migrationBuilder.RenameTable(
                name: "Grade",
                newName: "Grades");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Grades",
                table: "Grades",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Boulders_Grades_GradeID",
                table: "Boulders",
                column: "GradeID",
                principalTable: "Grades",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_Grades_GradeID",
                table: "Routes",
                column: "GradeID",
                principalTable: "Grades",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boulders_Grades_GradeID",
                table: "Boulders");

            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Grades_GradeID",
                table: "Routes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Grades",
                table: "Grades");

            migrationBuilder.RenameTable(
                name: "Grades",
                newName: "Grade");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Grade",
                table: "Grade",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Boulders_Grade_GradeID",
                table: "Boulders",
                column: "GradeID",
                principalTable: "Grade",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_Grade_GradeID",
                table: "Routes",
                column: "GradeID",
                principalTable: "Grade",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
