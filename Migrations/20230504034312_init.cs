using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PitchLogData.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NearestTown = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Grade",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grade", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sectors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approach = table.Column<int>(type: "int", nullable: true),
                    Aspect = table.Column<int>(type: "int", nullable: false),
                    AreaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectors", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sectors_Areas_AreaID",
                        column: x => x.AreaID,
                        principalTable: "Areas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BoulderSessions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionLength = table.Column<int>(type: "int", nullable: false),
                    Send = table.Column<bool>(type: "bit", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoulderSessions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BoulderSessions_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pitches",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Partner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pitches", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Pitches_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Boulders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PadsRequired = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GradeID = table.Column<int>(type: "int", nullable: false),
                    SectorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boulders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Boulders_Grade_GradeID",
                        column: x => x.GradeID,
                        principalTable: "Grade",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Boulders_Sectors_SectorID",
                        column: x => x.SectorID,
                        principalTable: "Sectors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Length = table.Column<int>(type: "int", nullable: true),
                    LengthUnits = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GradeID = table.Column<int>(type: "int", nullable: false),
                    SectorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Routes_Grade_GradeID",
                        column: x => x.GradeID,
                        principalTable: "Grade",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Routes_Sectors_SectorID",
                        column: x => x.SectorID,
                        principalTable: "Sectors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "ID", "Type", "Value" },
                values: new object[,]
                {
                    { 1, 1, "5.5" },
                    { 2, 1, "5.6" },
                    { 3, 1, "5.7" },
                    { 4, 1, "5.8" },
                    { 5, 1, "5.9" },
                    { 6, 1, "5.10a" },
                    { 7, 1, "5.10b" },
                    { 8, 1, "5.10c" },
                    { 9, 1, "5.10d" },
                    { 10, 1, "5.11a" },
                    { 11, 1, "5.11b" },
                    { 12, 1, "5.11c" },
                    { 13, 1, "5.11d" },
                    { 14, 1, "5.12a" },
                    { 15, 1, "5.12b" },
                    { 16, 1, "5.12c" },
                    { 17, 1, "5.12d" },
                    { 18, 1, "5.13a" },
                    { 19, 1, "5.13b" },
                    { 20, 1, "5.13c" },
                    { 21, 1, "5.13d" },
                    { 22, 1, "5.14a" },
                    { 23, 1, "5.14b" },
                    { 24, 1, "5.14c" },
                    { 25, 1, "5.14d" },
                    { 26, 1, "5.15a" },
                    { 27, 1, "5.15b" },
                    { 28, 1, "5.15c" },
                    { 29, 1, "5.15d" },
                    { 30, 4, "V0" },
                    { 31, 4, "V1" },
                    { 32, 4, "V2" },
                    { 33, 4, "V3" },
                    { 34, 4, "V4" },
                    { 35, 4, "V5" },
                    { 36, 4, "V6" },
                    { 37, 4, "V7" },
                    { 38, 4, "V8" },
                    { 39, 4, "V9" },
                    { 40, 4, "V10" },
                    { 41, 4, "V11" },
                    { 42, 4, "V12" }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "ID", "Type", "Value" },
                values: new object[,]
                {
                    { 43, 4, "V13" },
                    { 44, 4, "V14" },
                    { 45, 4, "V15" },
                    { 46, 4, "V16" },
                    { 47, 4, "V17" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Boulders_GradeID",
                table: "Boulders",
                column: "GradeID");

            migrationBuilder.CreateIndex(
                name: "IX_Boulders_SectorID",
                table: "Boulders",
                column: "SectorID");

            migrationBuilder.CreateIndex(
                name: "IX_BoulderSessions_UserID",
                table: "BoulderSessions",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Pitches_UserID",
                table: "Pitches",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_GradeID",
                table: "Routes",
                column: "GradeID");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_SectorID",
                table: "Routes",
                column: "SectorID");

            migrationBuilder.CreateIndex(
                name: "IX_Sectors_AreaID",
                table: "Sectors",
                column: "AreaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boulders");

            migrationBuilder.DropTable(
                name: "BoulderSessions");

            migrationBuilder.DropTable(
                name: "Pitches");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Grade");

            migrationBuilder.DropTable(
                name: "Sectors");

            migrationBuilder.DropTable(
                name: "Areas");
        }
    }
}
