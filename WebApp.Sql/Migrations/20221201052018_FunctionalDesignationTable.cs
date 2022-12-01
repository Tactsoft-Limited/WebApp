using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Sql.Migrations
{
    public partial class FunctionalDesignationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FunctionalDesignation_AspNetUsers_UserId",
                table: "FunctionalDesignation");

            migrationBuilder.DropForeignKey(
                name: "FK_FunctionalDesignation_Employees_EmployeeId",
                table: "FunctionalDesignation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FunctionalDesignation",
                table: "FunctionalDesignation");

            migrationBuilder.RenameTable(
                name: "FunctionalDesignation",
                newName: "FunctionalDesignations");

            migrationBuilder.RenameIndex(
                name: "IX_FunctionalDesignation_UserId",
                table: "FunctionalDesignations",
                newName: "IX_FunctionalDesignations_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_FunctionalDesignation_EmployeeId",
                table: "FunctionalDesignations",
                newName: "IX_FunctionalDesignations_EmployeeId");

            migrationBuilder.AddColumn<long>(
                name: "UserInformationId",
                table: "FunctionalDesignations",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FunctionalDesignations",
                table: "FunctionalDesignations",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_FunctionalDesignations_UserInformationId",
                table: "FunctionalDesignations",
                column: "UserInformationId");

            migrationBuilder.AddForeignKey(
                name: "FK_FunctionalDesignations_AspNetUsers_UserId",
                table: "FunctionalDesignations",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FunctionalDesignations_Employees_EmployeeId",
                table: "FunctionalDesignations",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FunctionalDesignations_UserInformations_UserInformationId",
                table: "FunctionalDesignations",
                column: "UserInformationId",
                principalTable: "UserInformations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FunctionalDesignations_AspNetUsers_UserId",
                table: "FunctionalDesignations");

            migrationBuilder.DropForeignKey(
                name: "FK_FunctionalDesignations_Employees_EmployeeId",
                table: "FunctionalDesignations");

            migrationBuilder.DropForeignKey(
                name: "FK_FunctionalDesignations_UserInformations_UserInformationId",
                table: "FunctionalDesignations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FunctionalDesignations",
                table: "FunctionalDesignations");

            migrationBuilder.DropIndex(
                name: "IX_FunctionalDesignations_UserInformationId",
                table: "FunctionalDesignations");

            migrationBuilder.DropColumn(
                name: "UserInformationId",
                table: "FunctionalDesignations");

            migrationBuilder.RenameTable(
                name: "FunctionalDesignations",
                newName: "FunctionalDesignation");

            migrationBuilder.RenameIndex(
                name: "IX_FunctionalDesignations_UserId",
                table: "FunctionalDesignation",
                newName: "IX_FunctionalDesignation_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_FunctionalDesignations_EmployeeId",
                table: "FunctionalDesignation",
                newName: "IX_FunctionalDesignation_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FunctionalDesignation",
                table: "FunctionalDesignation",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FunctionalDesignation_AspNetUsers_UserId",
                table: "FunctionalDesignation",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FunctionalDesignation_Employees_EmployeeId",
                table: "FunctionalDesignation",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
