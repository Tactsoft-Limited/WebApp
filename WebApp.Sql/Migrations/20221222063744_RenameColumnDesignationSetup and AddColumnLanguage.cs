using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Sql.Migrations
{
    public partial class RenameColumnDesignationSetupandAddColumnLanguage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RemarK",
                table: "DesignationSetups",
                newName: "Remark");

            migrationBuilder.AddColumn<string>(
                name: "LanguageName",
                table: "Languages",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LanguageName",
                table: "Languages");

            migrationBuilder.RenameColumn(
                name: "Remark",
                table: "DesignationSetups",
                newName: "RemarK");
        }
    }
}
