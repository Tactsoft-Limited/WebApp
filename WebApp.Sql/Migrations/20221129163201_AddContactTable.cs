using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Sql.Migrations
{
    public partial class AddContactTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: true),
                    OfficeMobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalMobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficeEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PresentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PresentCountryId = table.Column<long>(type: "bigint", nullable: true),
                    PresentStateId = table.Column<long>(type: "bigint", nullable: true),
                    PresentCityId = table.Column<long>(type: "bigint", nullable: true),
                    PresentZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermanentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermanentCountryId = table.Column<long>(type: "bigint", nullable: true),
                    PermanentStateId = table.Column<long>(type: "bigint", nullable: true),
                    PermanentCityId = table.Column<long>(type: "bigint", nullable: true),
                    PermanentZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contact_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contact_City_PermanentCityId",
                        column: x => x.PermanentCityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contact_Country_PermanentCountryId",
                        column: x => x.PermanentCountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contact_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contact_State_PermanentStateId",
                        column: x => x.PermanentStateId,
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contact_EmployeeId",
                table: "Contact",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_PermanentCityId",
                table: "Contact",
                column: "PermanentCityId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_PermanentCountryId",
                table: "Contact",
                column: "PermanentCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_PermanentStateId",
                table: "Contact",
                column: "PermanentStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_UserId",
                table: "Contact",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contact");
        }
    }
}
