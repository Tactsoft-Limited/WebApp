using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Sql.Migrations
{
    public partial class RenameRelationFamilyInfoTableColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FamilyInfos_Employees_EmployeesId",
                table: "FamilyInfos");

            migrationBuilder.DropIndex(
                name: "IX_FamilyInfos_EmployeesId",
                table: "FamilyInfos");

            migrationBuilder.DropColumn(
                name: "EmployeesId",
                table: "FamilyInfos");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyInfos_EmployeeId",
                table: "FamilyInfos",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_FamilyInfos_Employees_EmployeeId",
                table: "FamilyInfos",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FamilyInfos_Employees_EmployeeId",
                table: "FamilyInfos");

            migrationBuilder.DropIndex(
                name: "IX_FamilyInfos_EmployeeId",
                table: "FamilyInfos");

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
    }
}
