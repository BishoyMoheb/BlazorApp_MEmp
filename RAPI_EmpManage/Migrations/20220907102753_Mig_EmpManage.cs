using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RAPI_EmpManage.Migrations
{
    public partial class Mig_EmpManage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DbS_MDep",
                columns: table => new
                {
                    DepID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbS_MDep", x => x.DepID);
                });

            migrationBuilder.CreateTable(
                name: "DbS_MEmp",
                columns: table => new
                {
                    EmpID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DOBirth = table.Column<DateTime>(nullable: false),
                    GenderSex = table.Column<int>(nullable: false),
                    DeptID = table.Column<int>(nullable: false),
                    PhotoPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbS_MEmp", x => x.EmpID);
                });

            migrationBuilder.InsertData(
                table: "DbS_MDep",
                columns: new[] { "DepID", "DepName" },
                values: new object[,]
                {
                    { 1, "IT" },
                    { 2, "PayRoll" },
                    { 3, "HR" }
                });

            migrationBuilder.InsertData(
                table: "DbS_MEmp",
                columns: new[] { "EmpID", "DOBirth", "DeptID", "Email", "FirstName", "GenderSex", "LastName", "PhotoPath" },
                values: new object[,]
                {
                    { 1, new DateTime(1977, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Samy.Hanna@PBTech.com", "Samy", 0, "Hanna", "Images/Emp_Samy.png" },
                    { 2, new DateTime(1987, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Etve.Samy@PBTech.com", "Etve", 1, "Samy", "Images/Emp_Etve.png" },
                    { 3, new DateTime(1997, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Parthy.Pisho@PBTech.com", "Parthy", 1, "Pisho", "Images/Emp_Parthy.png" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DbS_MDep");

            migrationBuilder.DropTable(
                name: "DbS_MEmp");
        }
    }
}
