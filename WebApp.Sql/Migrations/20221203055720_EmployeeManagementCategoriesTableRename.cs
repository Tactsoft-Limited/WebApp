using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Sql.Migrations
{
    public partial class EmployeeManagementCategoriesTableRename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeManagementCategory_AspNetUsers_UserId",
                table: "EmployeeManagementCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeManagementCategory_Employees_EmployeeId",
                table: "EmployeeManagementCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeManagementCategory_UserInformations_UserInformationId",
                table: "EmployeeManagementCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeManagementCategory",
                table: "EmployeeManagementCategory");

            migrationBuilder.RenameTable(
                name: "EmployeeManagementCategory",
                newName: "EmployeeManagementCategories");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeManagementCategory_UserInformationId",
                table: "EmployeeManagementCategories",
                newName: "IX_EmployeeManagementCategories_UserInformationId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeManagementCategory_UserId",
                table: "EmployeeManagementCategories",
                newName: "IX_EmployeeManagementCategories_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeManagementCategory_EmployeeId",
                table: "EmployeeManagementCategories",
                newName: "IX_EmployeeManagementCategories_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeManagementCategories",
                table: "EmployeeManagementCategories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeManagementCategories_AspNetUsers_UserId",
                table: "EmployeeManagementCategories",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeManagementCategories_Employees_EmployeeId",
                table: "EmployeeManagementCategories",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeManagementCategories_UserInformations_UserInformationId",
                table: "EmployeeManagementCategories",
                column: "UserInformationId",
                principalTable: "UserInformations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeManagementCategories_AspNetUsers_UserId",
                table: "EmployeeManagementCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeManagementCategories_Employees_EmployeeId",
                table: "EmployeeManagementCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeManagementCategories_UserInformations_UserInformationId",
                table: "EmployeeManagementCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeManagementCategories",
                table: "EmployeeManagementCategories");

            migrationBuilder.RenameTable(
                name: "EmployeeManagementCategories",
                newName: "EmployeeManagementCategory");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeManagementCategories_UserInformationId",
                table: "EmployeeManagementCategory",
                newName: "IX_EmployeeManagementCategory_UserInformationId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeManagementCategories_UserId",
                table: "EmployeeManagementCategory",
                newName: "IX_EmployeeManagementCategory_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeManagementCategories_EmployeeId",
                table: "EmployeeManagementCategory",
                newName: "IX_EmployeeManagementCategory_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeManagementCategory",
                table: "EmployeeManagementCategory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeManagementCategory_AspNetUsers_UserId",
                table: "EmployeeManagementCategory",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeManagementCategory_Employees_EmployeeId",
                table: "EmployeeManagementCategory",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeManagementCategory_UserInformations_UserInformationId",
                table: "EmployeeManagementCategory",
                column: "UserInformationId",
                principalTable: "UserInformations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
