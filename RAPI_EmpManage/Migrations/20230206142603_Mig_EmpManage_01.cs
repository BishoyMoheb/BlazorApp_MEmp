using Microsoft.EntityFrameworkCore.Migrations;

namespace RAPI_EmpManage.Migrations
{
    public partial class Mig_EmpManage_01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "DbS_MEmp",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "DbS_MEmp",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DbS_MEmp_DeptID",
                table: "DbS_MEmp",
                column: "DeptID");

            migrationBuilder.AddForeignKey(
                name: "FK_DbS_MEmp_DbS_MDep_DeptID",
                table: "DbS_MEmp",
                column: "DeptID",
                principalTable: "DbS_MDep",
                principalColumn: "DepID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DbS_MEmp_DbS_MDep_DeptID",
                table: "DbS_MEmp");

            migrationBuilder.DropIndex(
                name: "IX_DbS_MEmp_DeptID",
                table: "DbS_MEmp");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "DbS_MEmp",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "DbS_MEmp",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
