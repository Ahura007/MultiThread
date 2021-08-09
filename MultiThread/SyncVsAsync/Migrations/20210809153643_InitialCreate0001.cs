using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SyncVsAsync.Migrations
{
    public partial class InitialCreate0001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    GradeId = table.Column<int>(type: "int", nullable: false),
                    StudentName1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentName2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentName3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentName4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentName5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentName6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentName7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentName8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentName9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentName10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentName11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentName12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentName13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentName14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentName15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentName16 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
