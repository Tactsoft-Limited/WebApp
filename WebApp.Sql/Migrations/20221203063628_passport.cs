using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Sql.Migrations
{
    public partial class passport : Migration
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

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: true),
                    ProficencyId = table.Column<long>(type: "bigint", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Languages_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Languages_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Languages_Proficiencies_ProficencyId",
                        column: x => x.ProficencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Passports",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: true),
                    PassportNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<long>(type: "bigint", nullable: true),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Passports_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Passports_Countrys_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countrys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Passports_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Warnings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: true),
                    WarningByEmployeeId = table.Column<long>(type: "bigint", nullable: true),
                    WarningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WarningType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarningDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warnings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Warnings_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Warnings_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FunctionalDesignations_UserInformationId",
                table: "FunctionalDesignations",
                column: "UserInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_EmployeeId",
                table: "Languages",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_ProficencyId",
                table: "Languages",
                column: "ProficencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_UserId",
                table: "Languages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Passports_CountryId",
                table: "Passports",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Passports_EmployeeId",
                table: "Passports",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Passports_UserId",
                table: "Passports",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Warnings_EmployeeId",
                table: "Warnings",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Warnings_UserId",
                table: "Warnings",
                column: "UserId");

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

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Passports");

            migrationBuilder.DropTable(
                name: "Warnings");

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
