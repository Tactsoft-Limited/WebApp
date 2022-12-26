using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Sql.Migrations
{
    public partial class ScriptA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Attachment",
                table: "Documents",
                newName: "Avatar");

            migrationBuilder.CreateIndex(
                name: "IX_Supervisors_SuppervisorSetupId",
                table: "Supervisors",
                column: "SuppervisorSetupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Supervisors_SupervisorSetups_SuppervisorSetupId",
                table: "Supervisors",
                column: "SuppervisorSetupId",
                principalTable: "SupervisorSetups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Supervisors_SupervisorSetups_SuppervisorSetupId",
                table: "Supervisors");

            migrationBuilder.DropIndex(
                name: "IX_Supervisors_SuppervisorSetupId",
                table: "Supervisors");

            migrationBuilder.RenameColumn(
                name: "Avatar",
                table: "Documents",
                newName: "Attachment");
        }
    }
}
