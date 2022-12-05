using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Sql.Migrations
{
    public partial class EditDesignationTableAddUserIdColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "UserId",
                table: "DesignationSetups",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DesignationSetups_UserId",
                table: "DesignationSetups",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_DesignationSetups_AspNetUsers_UserId",
                table: "DesignationSetups",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DesignationSetups_AspNetUsers_UserId",
                table: "DesignationSetups");

            migrationBuilder.DropIndex(
                name: "IX_DesignationSetups_UserId",
                table: "DesignationSetups");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "DesignationSetups");
        }
    }
}
