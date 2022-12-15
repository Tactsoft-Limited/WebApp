using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Sql.Migrations
{
    public partial class updateFamilyInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmoloyeeId",
                table: "FamilyInfos");

            migrationBuilder.AddColumn<long>(
                name: "EmployeeId",
                table: "FamilyInfos",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "EmployeesId",
                table: "FamilyInfos",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FamilyInfos_EmployeesId",
                table: "FamilyInfos",
                column: "EmployeesId");

            migrationBuilder.AddForeignKey(
                name: "FK_FamilyInfos_Employees_EmployeesId",
                table: "FamilyInfos",
                column: "EmployeesId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FamilyInfos_Employees_EmployeesId",
                table: "FamilyInfos");

            migrationBuilder.DropIndex(
                name: "IX_FamilyInfos_EmployeesId",
                table: "FamilyInfos");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "FamilyInfos");

            migrationBuilder.DropColumn(
                name: "EmployeesId",
                table: "FamilyInfos");

            migrationBuilder.AddColumn<int>(
                name: "EmoloyeeId",
                table: "FamilyInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
