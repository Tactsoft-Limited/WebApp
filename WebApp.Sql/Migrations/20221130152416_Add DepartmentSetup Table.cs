using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Sql.Migrations
{
    public partial class AddDepartmentSetupTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_AspNetUsers_UserId",
                table: "Contact");

            migrationBuilder.DropForeignKey(
                name: "FK_Contact_City_PermanentCityId",
                table: "Contact");

            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Country_PermanentCountryId",
                table: "Contact");

            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Employees_EmployeeId",
                table: "Contact");

            migrationBuilder.DropForeignKey(
                name: "FK_Contact_State_PermanentStateId",
                table: "Contact");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Gender_GenderId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_FamilyInfo_AspNetUsers_UserId",
                table: "FamilyInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_FamilyInfo_Gender_GenderId",
                table: "FamilyInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_Supervisor_AspNetUsers_UserId",
                table: "Supervisor");

            migrationBuilder.DropForeignKey(
                name: "FK_Supervisor_Employees_EmployeeId",
                table: "Supervisor");

            migrationBuilder.DropForeignKey(
                name: "FK_Supervisor_UserInformations_UserInformationId",
                table: "Supervisor");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInformations_Gender_GenderId",
                table: "UserInformations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Supervisor",
                table: "Supervisor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MeritalStatus",
                table: "MeritalStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gender",
                table: "Gender");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FamilyInfo",
                table: "FamilyInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contact",
                table: "Contact");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BloodGroup",
                table: "BloodGroup");

            migrationBuilder.RenameTable(
                name: "Supervisor",
                newName: "Supervisors");

            migrationBuilder.RenameTable(
                name: "MeritalStatus",
                newName: "MeritalStatuses");

            migrationBuilder.RenameTable(
                name: "Gender",
                newName: "Genders");

            migrationBuilder.RenameTable(
                name: "FamilyInfo",
                newName: "FamilyInfos");

            migrationBuilder.RenameTable(
                name: "Contact",
                newName: "Contacts");

            migrationBuilder.RenameTable(
                name: "BloodGroup",
                newName: "BloodGroups");

            migrationBuilder.RenameIndex(
                name: "IX_Supervisor_UserInformationId",
                table: "Supervisors",
                newName: "IX_Supervisors_UserInformationId");

            migrationBuilder.RenameIndex(
                name: "IX_Supervisor_UserId",
                table: "Supervisors",
                newName: "IX_Supervisors_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Supervisor_EmployeeId",
                table: "Supervisors",
                newName: "IX_Supervisors_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_FamilyInfo_UserId",
                table: "FamilyInfos",
                newName: "IX_FamilyInfos_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_FamilyInfo_GenderId",
                table: "FamilyInfos",
                newName: "IX_FamilyInfos_GenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Contact_UserId",
                table: "Contacts",
                newName: "IX_Contacts_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Contact_PermanentStateId",
                table: "Contacts",
                newName: "IX_Contacts_PermanentStateId");

            migrationBuilder.RenameIndex(
                name: "IX_Contact_PermanentCountryId",
                table: "Contacts",
                newName: "IX_Contacts_PermanentCountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Contact_PermanentCityId",
                table: "Contacts",
                newName: "IX_Contacts_PermanentCityId");

            migrationBuilder.RenameIndex(
                name: "IX_Contact_EmployeeId",
                table: "Contacts",
                newName: "IX_Contacts_EmployeeId");

            migrationBuilder.AlterColumn<long>(
                name: "ReligionId",
                table: "UserInformations",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Supervisors",
                table: "Supervisors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MeritalStatuses",
                table: "MeritalStatuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genders",
                table: "Genders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FamilyInfos",
                table: "FamilyInfos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BloodGroups",
                table: "BloodGroups",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "DepartmentSetups",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: true),
                    DepartmentId = table.Column<long>(type: "bigint", nullable: true),
                    EffectedDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentSetups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepartmentSetups_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DepartmentSetups_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DepartmentSetups_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HobbyTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HobbyTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HobbyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Religions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReligionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Religions", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentSetups_DepartmentId",
                table: "DepartmentSetups",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentSetups_EmployeeId",
                table: "DepartmentSetups",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentSetups_UserId",
                table: "DepartmentSetups",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_AspNetUsers_UserId",
                table: "Contacts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_City_PermanentCityId",
                table: "Contacts",
                column: "PermanentCityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Country_PermanentCountryId",
                table: "Contacts",
                column: "PermanentCountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Employees_EmployeeId",
                table: "Contacts",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_State_PermanentStateId",
                table: "Contacts",
                column: "PermanentStateId",
                principalTable: "State",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Genders_GenderId",
                table: "Employees",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FamilyInfos_AspNetUsers_UserId",
                table: "FamilyInfos",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FamilyInfos_Genders_GenderId",
                table: "FamilyInfos",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Supervisors_AspNetUsers_UserId",
                table: "Supervisors",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Supervisors_Employees_EmployeeId",
                table: "Supervisors",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Supervisors_UserInformations_UserInformationId",
                table: "Supervisors",
                column: "UserInformationId",
                principalTable: "UserInformations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInformations_Genders_GenderId",
                table: "UserInformations",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_AspNetUsers_UserId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_City_PermanentCityId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Country_PermanentCountryId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Employees_EmployeeId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_State_PermanentStateId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Genders_GenderId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_FamilyInfos_AspNetUsers_UserId",
                table: "FamilyInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_FamilyInfos_Genders_GenderId",
                table: "FamilyInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_Supervisors_AspNetUsers_UserId",
                table: "Supervisors");

            migrationBuilder.DropForeignKey(
                name: "FK_Supervisors_Employees_EmployeeId",
                table: "Supervisors");

            migrationBuilder.DropForeignKey(
                name: "FK_Supervisors_UserInformations_UserInformationId",
                table: "Supervisors");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInformations_Genders_GenderId",
                table: "UserInformations");

            migrationBuilder.DropTable(
                name: "DepartmentSetups");

            migrationBuilder.DropTable(
                name: "HobbyTypes");

            migrationBuilder.DropTable(
                name: "Religions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Supervisors",
                table: "Supervisors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MeritalStatuses",
                table: "MeritalStatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genders",
                table: "Genders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FamilyInfos",
                table: "FamilyInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BloodGroups",
                table: "BloodGroups");

            migrationBuilder.RenameTable(
                name: "Supervisors",
                newName: "Supervisor");

            migrationBuilder.RenameTable(
                name: "MeritalStatuses",
                newName: "MeritalStatus");

            migrationBuilder.RenameTable(
                name: "Genders",
                newName: "Gender");

            migrationBuilder.RenameTable(
                name: "FamilyInfos",
                newName: "FamilyInfo");

            migrationBuilder.RenameTable(
                name: "Contacts",
                newName: "Contact");

            migrationBuilder.RenameTable(
                name: "BloodGroups",
                newName: "BloodGroup");

            migrationBuilder.RenameIndex(
                name: "IX_Supervisors_UserInformationId",
                table: "Supervisor",
                newName: "IX_Supervisor_UserInformationId");

            migrationBuilder.RenameIndex(
                name: "IX_Supervisors_UserId",
                table: "Supervisor",
                newName: "IX_Supervisor_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Supervisors_EmployeeId",
                table: "Supervisor",
                newName: "IX_Supervisor_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_FamilyInfos_UserId",
                table: "FamilyInfo",
                newName: "IX_FamilyInfo_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_FamilyInfos_GenderId",
                table: "FamilyInfo",
                newName: "IX_FamilyInfo_GenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_UserId",
                table: "Contact",
                newName: "IX_Contact_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_PermanentStateId",
                table: "Contact",
                newName: "IX_Contact_PermanentStateId");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_PermanentCountryId",
                table: "Contact",
                newName: "IX_Contact_PermanentCountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_PermanentCityId",
                table: "Contact",
                newName: "IX_Contact_PermanentCityId");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_EmployeeId",
                table: "Contact",
                newName: "IX_Contact_EmployeeId");

            migrationBuilder.AlterColumn<int>(
                name: "ReligionId",
                table: "UserInformations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Supervisor",
                table: "Supervisor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MeritalStatus",
                table: "MeritalStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gender",
                table: "Gender",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FamilyInfo",
                table: "FamilyInfo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contact",
                table: "Contact",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BloodGroup",
                table: "BloodGroup",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_AspNetUsers_UserId",
                table: "Contact",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_City_PermanentCityId",
                table: "Contact",
                column: "PermanentCityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Country_PermanentCountryId",
                table: "Contact",
                column: "PermanentCountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Employees_EmployeeId",
                table: "Contact",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_State_PermanentStateId",
                table: "Contact",
                column: "PermanentStateId",
                principalTable: "State",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Gender_GenderId",
                table: "Employees",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FamilyInfo_AspNetUsers_UserId",
                table: "FamilyInfo",
                column: "UserId",
                principalTable: "AspNetUsers",
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
                name: "FK_Supervisor_AspNetUsers_UserId",
                table: "Supervisor",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Supervisor_Employees_EmployeeId",
                table: "Supervisor",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Supervisor_UserInformations_UserInformationId",
                table: "Supervisor",
                column: "UserInformationId",
                principalTable: "UserInformations",
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
    }
}
