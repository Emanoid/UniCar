using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniCar.Data.Migrations
{
    public partial class initialsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Job",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    NoOfApplicants = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    InterviewDate = table.Column<DateTime>(nullable: false),
                    PreferredSkills = table.Column<string>(nullable: true),
                    Salary = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    ApplicationId = table.Column<int>(nullable: false),
                    EmployerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Job");
        }
    }
}
