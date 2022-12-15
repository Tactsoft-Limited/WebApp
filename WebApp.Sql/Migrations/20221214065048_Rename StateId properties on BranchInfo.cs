using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Sql.Migrations
{
    public partial class RenameStateIdpropertiesonBranchInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BranchInfos_States_CompanyStateId",
                table: "BranchInfos");

            migrationBuilder.RenameColumn(
                name: "CompanyStateId",
                table: "BranchInfos",
                newName: "StateId");

            migrationBuilder.RenameIndex(
                name: "IX_BranchInfos_CompanyStateId",
                table: "BranchInfos",
                newName: "IX_BranchInfos_StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_BranchInfos_States_StateId",
                table: "BranchInfos",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BranchInfos_States_StateId",
                table: "BranchInfos");

            migrationBuilder.RenameColumn(
                name: "StateId",
                table: "BranchInfos",
                newName: "CompanyStateId");

            migrationBuilder.RenameIndex(
                name: "IX_BranchInfos_StateId",
                table: "BranchInfos",
                newName: "IX_BranchInfos_CompanyStateId");

            migrationBuilder.AddForeignKey(
                name: "FK_BranchInfos_States_CompanyStateId",
                table: "BranchInfos",
                column: "CompanyStateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
