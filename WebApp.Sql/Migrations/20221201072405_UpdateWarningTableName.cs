using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Sql.Migrations
{
    public partial class UpdateWarningTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Warning_AspNetUsers_UserId",
                table: "Warning");

            migrationBuilder.DropForeignKey(
                name: "FK_Warning_Employees_EmployeeId",
                table: "Warning");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Warning",
                table: "Warning");

            migrationBuilder.RenameTable(
                name: "Warning",
                newName: "Warnings");

            migrationBuilder.RenameIndex(
                name: "IX_Warning_UserId",
                table: "Warnings",
                newName: "IX_Warnings_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Warning_EmployeeId",
                table: "Warnings",
                newName: "IX_Warnings_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Warnings",
                table: "Warnings",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Warnings_AspNetUsers_UserId",
                table: "Warnings",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Warnings_Employees_EmployeeId",
                table: "Warnings",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Warnings_AspNetUsers_UserId",
                table: "Warnings");

            migrationBuilder.DropForeignKey(
                name: "FK_Warnings_Employees_EmployeeId",
                table: "Warnings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Warnings",
                table: "Warnings");

            migrationBuilder.RenameTable(
                name: "Warnings",
                newName: "Warning");

            migrationBuilder.RenameIndex(
                name: "IX_Warnings_UserId",
                table: "Warning",
                newName: "IX_Warning_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Warnings_EmployeeId",
                table: "Warning",
                newName: "IX_Warning_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Warning",
                table: "Warning",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Warning_AspNetUsers_UserId",
                table: "Warning",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Warning_Employees_EmployeeId",
                table: "Warning",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
