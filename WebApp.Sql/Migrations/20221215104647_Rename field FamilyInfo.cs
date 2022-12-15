using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Sql.Migrations
{
    public partial class RenamefieldFamilyInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FemilyMemberName",
                table: "FamilyInfos",
                newName: "FamilyMemberName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FamilyMemberName",
                table: "FamilyInfos",
                newName: "FemilyMemberName");
        }
    }
}
