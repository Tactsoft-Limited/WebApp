using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Sql.Migrations
{
    public partial class UpdateTableNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_State_StateId",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_City_PermanentCityId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Country_PermanentCountryId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_State_PermanentStateId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_State_Country_CountryId",
                table: "State");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAddressInformation_City_CityId",
                table: "UserAddressInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAddressInformation_Country_CountryId",
                table: "UserAddressInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAddressInformation_State_StateId",
                table: "UserAddressInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInformations_City_CityId",
                table: "UserInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInformations_Country_CountryId",
                table: "UserInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInformations_Country_NationalityId",
                table: "UserInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInformations_State_StateId",
                table: "UserInformations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_State",
                table: "State");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Country",
                table: "Country");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.RenameTable(
                name: "State",
                newName: "States");

            migrationBuilder.RenameTable(
                name: "Country",
                newName: "Countrys");

            migrationBuilder.RenameTable(
                name: "City",
                newName: "Citys");

            migrationBuilder.RenameIndex(
                name: "IX_State_CountryId",
                table: "States",
                newName: "IX_States_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_City_StateId",
                table: "Citys",
                newName: "IX_Citys_StateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_States",
                table: "States",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countrys",
                table: "Countrys",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Citys",
                table: "Citys",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Citys_States_StateId",
                table: "Citys",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Citys_PermanentCityId",
                table: "Contacts",
                column: "PermanentCityId",
                principalTable: "Citys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Countrys_PermanentCountryId",
                table: "Contacts",
                column: "PermanentCountryId",
                principalTable: "Countrys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_States_PermanentStateId",
                table: "Contacts",
                column: "PermanentStateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_States_Countrys_CountryId",
                table: "States",
                column: "CountryId",
                principalTable: "Countrys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAddressInformation_Citys_CityId",
                table: "UserAddressInformation",
                column: "CityId",
                principalTable: "Citys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAddressInformation_Countrys_CountryId",
                table: "UserAddressInformation",
                column: "CountryId",
                principalTable: "Countrys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAddressInformation_States_StateId",
                table: "UserAddressInformation",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInformations_Citys_CityId",
                table: "UserInformations",
                column: "CityId",
                principalTable: "Citys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInformations_Countrys_CountryId",
                table: "UserInformations",
                column: "CountryId",
                principalTable: "Countrys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInformations_Countrys_NationalityId",
                table: "UserInformations",
                column: "NationalityId",
                principalTable: "Countrys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInformations_States_StateId",
                table: "UserInformations",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Citys_States_StateId",
                table: "Citys");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Citys_PermanentCityId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Countrys_PermanentCountryId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_States_PermanentStateId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_States_Countrys_CountryId",
                table: "States");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAddressInformation_Citys_CityId",
                table: "UserAddressInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAddressInformation_Countrys_CountryId",
                table: "UserAddressInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAddressInformation_States_StateId",
                table: "UserAddressInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInformations_Citys_CityId",
                table: "UserInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInformations_Countrys_CountryId",
                table: "UserInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInformations_Countrys_NationalityId",
                table: "UserInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInformations_States_StateId",
                table: "UserInformations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_States",
                table: "States");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countrys",
                table: "Countrys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Citys",
                table: "Citys");

            migrationBuilder.RenameTable(
                name: "States",
                newName: "State");

            migrationBuilder.RenameTable(
                name: "Countrys",
                newName: "Country");

            migrationBuilder.RenameTable(
                name: "Citys",
                newName: "City");

            migrationBuilder.RenameIndex(
                name: "IX_States_CountryId",
                table: "State",
                newName: "IX_State_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Citys_StateId",
                table: "City",
                newName: "IX_City_StateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_State",
                table: "State",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Country",
                table: "Country",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_City_State_StateId",
                table: "City",
                column: "StateId",
                principalTable: "State",
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
                name: "FK_Contacts_State_PermanentStateId",
                table: "Contacts",
                column: "PermanentStateId",
                principalTable: "State",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_State_Country_CountryId",
                table: "State",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAddressInformation_City_CityId",
                table: "UserAddressInformation",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAddressInformation_Country_CountryId",
                table: "UserAddressInformation",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAddressInformation_State_StateId",
                table: "UserAddressInformation",
                column: "StateId",
                principalTable: "State",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInformations_City_CityId",
                table: "UserInformations",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInformations_Country_CountryId",
                table: "UserInformations",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInformations_Country_NationalityId",
                table: "UserInformations",
                column: "NationalityId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInformations_State_StateId",
                table: "UserInformations",
                column: "StateId",
                principalTable: "State",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
