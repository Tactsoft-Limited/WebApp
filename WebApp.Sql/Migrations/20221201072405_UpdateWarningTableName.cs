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

            migrationBuilder.CreateTable(
                name: "BranchInfo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    CompanyId = table.Column<long>(type: "bigint", nullable: true),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<long>(type: "bigint", nullable: true),
                    CityId = table.Column<long>(type: "bigint", nullable: true),
                    CompanyStateId = table.Column<long>(type: "bigint", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BranchInfo_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BranchInfo_Citys_CityId",
                        column: x => x.CityId,
                        principalTable: "Citys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BranchInfo_Countrys_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countrys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BranchInfo_States_CompanyStateId",
                        column: x => x.CompanyStateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BranchInfo_CityId",
                table: "BranchInfo",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchInfo_CompanyStateId",
                table: "BranchInfo",
                column: "CompanyStateId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchInfo_CountryId",
                table: "BranchInfo",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchInfo_UserId",
                table: "BranchInfo",
                column: "UserId");

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

            migrationBuilder.DropTable(
                name: "BranchInfo");

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
