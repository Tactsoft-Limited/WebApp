using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Sql.Migrations
{
    public partial class AddMeritalStatusTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaritalStatusId",
                table: "UserInformations");

            migrationBuilder.AddColumn<long>(
                name: "GenderId",
                table: "UserInformations",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "GenderId",
                table: "FamilyInfo",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "GenderId",
                table: "Employees",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MeritalStatus",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeritalStatusName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeritalStatus", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserInformations_GenderId",
                table: "UserInformations",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyInfo_GenderId",
                table: "FamilyInfo",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_GenderId",
                table: "Employees",
                column: "GenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Gender_GenderId",
                table: "Employees",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FamilyInfo_Gender_GenderId",
                table: "FamilyInfo",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInformations_Gender_GenderId",
                table: "UserInformations",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Gender_GenderId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_FamilyInfo_Gender_GenderId",
                table: "FamilyInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInformations_Gender_GenderId",
                table: "UserInformations");

            migrationBuilder.DropTable(
                name: "MeritalStatus");

            migrationBuilder.DropIndex(
                name: "IX_UserInformations_GenderId",
                table: "UserInformations");

            migrationBuilder.DropIndex(
                name: "IX_FamilyInfo_GenderId",
                table: "FamilyInfo");

            migrationBuilder.DropIndex(
                name: "IX_Employees_GenderId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "UserInformations");

            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "FamilyInfo");

            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "MaritalStatusId",
                table: "UserInformations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
