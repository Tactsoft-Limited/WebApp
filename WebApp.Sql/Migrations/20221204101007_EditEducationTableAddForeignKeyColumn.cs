using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Sql.Migrations
{
    public partial class EditEducationTableAddForeignKeyColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "Educations",
                newName: "EgucationGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_EducationTypeId",
                table: "Educations",
                column: "EducationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_EgucationGroupId",
                table: "Educations",
                column: "EgucationGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_GradeId",
                table: "Educations",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_InstituteId",
                table: "Educations",
                column: "InstituteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_EducationsGroups_EgucationGroupId",
                table: "Educations",
                column: "EgucationGroupId",
                principalTable: "EducationsGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_EducationsTypes_EducationTypeId",
                table: "Educations",
                column: "EducationTypeId",
                principalTable: "EducationsTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Grades_GradeId",
                table: "Educations",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Institutes_InstituteId",
                table: "Educations",
                column: "InstituteId",
                principalTable: "Institutes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_EducationsGroups_EgucationGroupId",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_Educations_EducationsTypes_EducationTypeId",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Grades_GradeId",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Institutes_InstituteId",
                table: "Educations");

            migrationBuilder.DropIndex(
                name: "IX_Educations_EducationTypeId",
                table: "Educations");

            migrationBuilder.DropIndex(
                name: "IX_Educations_EgucationGroupId",
                table: "Educations");

            migrationBuilder.DropIndex(
                name: "IX_Educations_GradeId",
                table: "Educations");

            migrationBuilder.DropIndex(
                name: "IX_Educations_InstituteId",
                table: "Educations");

            migrationBuilder.RenameColumn(
                name: "EgucationGroupId",
                table: "Educations",
                newName: "GroupId");
        }
    }
}
