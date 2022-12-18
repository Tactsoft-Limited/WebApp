using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Sql.Migrations
{
    public partial class AddRelationandRenameColumnTypeAwardInfoTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "PriceAmount",
                table: "AwardInfos",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.CreateIndex(
                name: "IX_AwardInfos_AwardTypeId",
                table: "AwardInfos",
                column: "AwardTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AwardInfos_AwardTypes_AwardTypeId",
                table: "AwardInfos",
                column: "AwardTypeId",
                principalTable: "AwardTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AwardInfos_AwardTypes_AwardTypeId",
                table: "AwardInfos");

            migrationBuilder.DropIndex(
                name: "IX_AwardInfos_AwardTypeId",
                table: "AwardInfos");

            migrationBuilder.AlterColumn<float>(
                name: "PriceAmount",
                table: "AwardInfos",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
