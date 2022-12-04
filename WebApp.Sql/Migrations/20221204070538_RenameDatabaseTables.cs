using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Sql.Migrations
{
    public partial class RenameDatabaseTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asset_AspNetUsers_UserId",
                table: "Asset");

            migrationBuilder.DropForeignKey(
                name: "FK_Asset_AssetType_AssetTypeId",
                table: "Asset");

            migrationBuilder.DropForeignKey(
                name: "FK_Asset_CompanyInfo_CompanyId",
                table: "Asset");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetRequisitions_AspNetUsers_UserId",
                table: "AssetRequisitions");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetRequisitions_Asset_AssetId",
                table: "AssetRequisitions");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetRequisitions_Employees_EmployeeId",
                table: "AssetRequisitions");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetType_AspNetUsers_UserId",
                table: "AssetType");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetType_BranchInfo_BranchId",
                table: "AssetType");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetType_CompanyInfo_CompanyId",
                table: "AssetType");

            migrationBuilder.DropForeignKey(
                name: "FK_AwardType_CompanyInfo_CompanyId",
                table: "AwardType");

            migrationBuilder.DropForeignKey(
                name: "FK_BankInfos_BranchInfo_BranchId",
                table: "BankInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_BranchInfo_AspNetUsers_UserId",
                table: "BranchInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_BranchInfo_Citys_CityId",
                table: "BranchInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_BranchInfo_Countrys_CountryId",
                table: "BranchInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_BranchInfo_States_CompanyStateId",
                table: "BranchInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_ClaimType_CompanyInfo_CompanyId",
                table: "ClaimType");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyInfo_AspNetUsers_UserId",
                table: "CompanyInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyInfo_Citys_CityId",
                table: "CompanyInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyInfo_Countrys_CountryId",
                table: "CompanyInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyInfo_States_StateId",
                table: "CompanyInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_DistributeAssets_Asset_AssetId",
                table: "DistributeAssets");

            migrationBuilder.DropForeignKey(
                name: "FK_DocumentCategorie_CompanyInfo_CompanyId",
                table: "DocumentCategorie");

            migrationBuilder.DropForeignKey(
                name: "FK_EducationGroup_CompanyInfo_CompanyId",
                table: "EducationGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_EducationType_CompanyInfo_CompanyId",
                table: "EducationType");

            migrationBuilder.DropForeignKey(
                name: "FK_EmploymentCategorie_CompanyInfo_CompanyId",
                table: "EmploymentCategorie");

            migrationBuilder.DropForeignKey(
                name: "FK_Grade_CompanyInfo_CompanyId",
                table: "Grade");

            migrationBuilder.DropForeignKey(
                name: "FK_Institute_CompanyInfo_CompanyId",
                table: "Institute");

            migrationBuilder.DropForeignKey(
                name: "FK_JobBaseStatus_BranchInfo_BranchId",
                table: "JobBaseStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_JobBaseStatus_CompanyInfo_CompanyId",
                table: "JobBaseStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_JobBaseStatus_Project_ProjectId",
                table: "JobBaseStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveType_CompanyInfo_CompanyId",
                table: "LeaveType");

            migrationBuilder.DropForeignKey(
                name: "FK_NewApprovalWorkflow_CompanyInfo_CompanyId",
                table: "NewApprovalWorkflow");

            migrationBuilder.DropForeignKey(
                name: "FK_NewJobStatus_BranchInfo_BranchId",
                table: "NewJobStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_NewJobStatus_CompanyInfo_CompanyId",
                table: "NewJobStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_NewJobStatus_Project_ProjectId",
                table: "NewJobStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_OpeningYear_CompanyInfo_CompanyId",
                table: "OpeningYear");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_AspNetUsers_UserId",
                table: "Project");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_BranchInfo_BranchId",
                table: "Project");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_CompanyInfo_CompanyId",
                table: "Project");

            migrationBuilder.DropForeignKey(
                name: "FK_SupervisorSetup_CompanyInfo_CompanyId",
                table: "SupervisorSetup");

            migrationBuilder.DropForeignKey(
                name: "FK_SupervisorSetup_Employees_EmployeeId",
                table: "SupervisorSetup");

            migrationBuilder.DropForeignKey(
                name: "FK_WarningType_CompanyInfo_CompanyId",
                table: "WarningType");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkflowMaping_BranchInfo_BranchId",
                table: "WorkflowMaping");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkflowMaping_CompanyInfo_CompanyId",
                table: "WorkflowMaping");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkflowMaping_Departments_DepartmentId",
                table: "WorkflowMaping");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkflowMaping_Employees_EmployeeId",
                table: "WorkflowMaping");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkflowMaping_NewApprovalWorkflow_WorkflowId",
                table: "WorkflowMaping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkflowMaping",
                table: "WorkflowMaping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WarningType",
                table: "WarningType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SupervisorSetup",
                table: "SupervisorSetup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Project",
                table: "Project");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OpeningYear",
                table: "OpeningYear");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NewApprovalWorkflow",
                table: "NewApprovalWorkflow");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeaveType",
                table: "LeaveType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobBaseStatus",
                table: "JobBaseStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Institute",
                table: "Institute");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Grade",
                table: "Grade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmploymentCategorie",
                table: "EmploymentCategorie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EducationType",
                table: "EducationType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EducationGroup",
                table: "EducationGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DocumentCategorie",
                table: "DocumentCategorie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyInfo",
                table: "CompanyInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClaimType",
                table: "ClaimType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BranchInfo",
                table: "BranchInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AwardType",
                table: "AwardType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssetType",
                table: "AssetType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssetRequisitions",
                table: "AssetRequisitions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Asset",
                table: "Asset");

            migrationBuilder.RenameTable(
                name: "WorkflowMaping",
                newName: "WorkflowMaps");

            migrationBuilder.RenameTable(
                name: "WarningType",
                newName: "WarningTypes");

            migrationBuilder.RenameTable(
                name: "SupervisorSetup",
                newName: "SupervisorSetups");

            migrationBuilder.RenameTable(
                name: "Project",
                newName: "Projects");

            migrationBuilder.RenameTable(
                name: "OpeningYear",
                newName: "OpeningYears");

            migrationBuilder.RenameTable(
                name: "NewApprovalWorkflow",
                newName: "NewApprovalWorkflows");

            migrationBuilder.RenameTable(
                name: "LeaveType",
                newName: "LeaveTypes");

            migrationBuilder.RenameTable(
                name: "JobBaseStatus",
                newName: "JobBaseStatuses");

            migrationBuilder.RenameTable(
                name: "Institute",
                newName: "Institutes");

            migrationBuilder.RenameTable(
                name: "Grade",
                newName: "Grades");

            migrationBuilder.RenameTable(
                name: "EmploymentCategorie",
                newName: "EmploymentCategories");

            migrationBuilder.RenameTable(
                name: "EducationType",
                newName: "EducationsTypes");

            migrationBuilder.RenameTable(
                name: "EducationGroup",
                newName: "EducationsGroups");

            migrationBuilder.RenameTable(
                name: "DocumentCategorie",
                newName: "DocumentCategorias");

            migrationBuilder.RenameTable(
                name: "CompanyInfo",
                newName: "CompanyInfos");

            migrationBuilder.RenameTable(
                name: "ClaimType",
                newName: "ClaimTypes");

            migrationBuilder.RenameTable(
                name: "BranchInfo",
                newName: "BranchInfos");

            migrationBuilder.RenameTable(
                name: "AwardType",
                newName: "AwardTypes");

            migrationBuilder.RenameTable(
                name: "AssetType",
                newName: "AssetsTypes");

            migrationBuilder.RenameTable(
                name: "AssetRequisitions",
                newName: "AssetRequisition");

            migrationBuilder.RenameTable(
                name: "Asset",
                newName: "Assets");

            migrationBuilder.RenameIndex(
                name: "IX_WorkflowMaping_WorkflowId",
                table: "WorkflowMaps",
                newName: "IX_WorkflowMaps_WorkflowId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkflowMaping_EmployeeId",
                table: "WorkflowMaps",
                newName: "IX_WorkflowMaps_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkflowMaping_DepartmentId",
                table: "WorkflowMaps",
                newName: "IX_WorkflowMaps_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkflowMaping_CompanyId",
                table: "WorkflowMaps",
                newName: "IX_WorkflowMaps_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkflowMaping_BranchId",
                table: "WorkflowMaps",
                newName: "IX_WorkflowMaps_BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_WarningType_CompanyId",
                table: "WarningTypes",
                newName: "IX_WarningTypes_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_SupervisorSetup_EmployeeId",
                table: "SupervisorSetups",
                newName: "IX_SupervisorSetups_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_SupervisorSetup_CompanyId",
                table: "SupervisorSetups",
                newName: "IX_SupervisorSetups_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Project_UserId",
                table: "Projects",
                newName: "IX_Projects_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Project_CompanyId",
                table: "Projects",
                newName: "IX_Projects_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Project_BranchId",
                table: "Projects",
                newName: "IX_Projects_BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_OpeningYear_CompanyId",
                table: "OpeningYears",
                newName: "IX_OpeningYears_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_NewApprovalWorkflow_CompanyId",
                table: "NewApprovalWorkflows",
                newName: "IX_NewApprovalWorkflows_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveType_CompanyId",
                table: "LeaveTypes",
                newName: "IX_LeaveTypes_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_JobBaseStatus_ProjectId",
                table: "JobBaseStatuses",
                newName: "IX_JobBaseStatuses_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_JobBaseStatus_CompanyId",
                table: "JobBaseStatuses",
                newName: "IX_JobBaseStatuses_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_JobBaseStatus_BranchId",
                table: "JobBaseStatuses",
                newName: "IX_JobBaseStatuses_BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_Institute_CompanyId",
                table: "Institutes",
                newName: "IX_Institutes_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Grade_CompanyId",
                table: "Grades",
                newName: "IX_Grades_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_EmploymentCategorie_CompanyId",
                table: "EmploymentCategories",
                newName: "IX_EmploymentCategories_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_EducationType_CompanyId",
                table: "EducationsTypes",
                newName: "IX_EducationsTypes_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_EducationGroup_CompanyId",
                table: "EducationsGroups",
                newName: "IX_EducationsGroups_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_DocumentCategorie_CompanyId",
                table: "DocumentCategorias",
                newName: "IX_DocumentCategorias_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyInfo_UserId",
                table: "CompanyInfos",
                newName: "IX_CompanyInfos_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyInfo_StateId",
                table: "CompanyInfos",
                newName: "IX_CompanyInfos_StateId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyInfo_CountryId",
                table: "CompanyInfos",
                newName: "IX_CompanyInfos_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyInfo_CityId",
                table: "CompanyInfos",
                newName: "IX_CompanyInfos_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_ClaimType_CompanyId",
                table: "ClaimTypes",
                newName: "IX_ClaimTypes_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_BranchInfo_UserId",
                table: "BranchInfos",
                newName: "IX_BranchInfos_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_BranchInfo_CountryId",
                table: "BranchInfos",
                newName: "IX_BranchInfos_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_BranchInfo_CompanyStateId",
                table: "BranchInfos",
                newName: "IX_BranchInfos_CompanyStateId");

            migrationBuilder.RenameIndex(
                name: "IX_BranchInfo_CityId",
                table: "BranchInfos",
                newName: "IX_BranchInfos_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_AwardType_CompanyId",
                table: "AwardTypes",
                newName: "IX_AwardTypes_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_AssetType_UserId",
                table: "AssetsTypes",
                newName: "IX_AssetsTypes_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AssetType_CompanyId",
                table: "AssetsTypes",
                newName: "IX_AssetsTypes_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_AssetType_BranchId",
                table: "AssetsTypes",
                newName: "IX_AssetsTypes_BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_AssetRequisitions_UserId",
                table: "AssetRequisition",
                newName: "IX_AssetRequisition_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AssetRequisitions_EmployeeId",
                table: "AssetRequisition",
                newName: "IX_AssetRequisition_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_AssetRequisitions_AssetId",
                table: "AssetRequisition",
                newName: "IX_AssetRequisition_AssetId");

            migrationBuilder.RenameIndex(
                name: "IX_Asset_UserId",
                table: "Assets",
                newName: "IX_Assets_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Asset_CompanyId",
                table: "Assets",
                newName: "IX_Assets_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Asset_AssetTypeId",
                table: "Assets",
                newName: "IX_Assets_AssetTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkflowMaps",
                table: "WorkflowMaps",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WarningTypes",
                table: "WarningTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupervisorSetups",
                table: "SupervisorSetups",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projects",
                table: "Projects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OpeningYears",
                table: "OpeningYears",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewApprovalWorkflows",
                table: "NewApprovalWorkflows",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeaveTypes",
                table: "LeaveTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobBaseStatuses",
                table: "JobBaseStatuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Institutes",
                table: "Institutes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Grades",
                table: "Grades",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmploymentCategories",
                table: "EmploymentCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EducationsTypes",
                table: "EducationsTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EducationsGroups",
                table: "EducationsGroups",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DocumentCategorias",
                table: "DocumentCategorias",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyInfos",
                table: "CompanyInfos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClaimTypes",
                table: "ClaimTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BranchInfos",
                table: "BranchInfos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AwardTypes",
                table: "AwardTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssetsTypes",
                table: "AssetsTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssetRequisition",
                table: "AssetRequisition",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assets",
                table: "Assets",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetRequisition_AspNetUsers_UserId",
                table: "AssetRequisition",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AssetRequisition_Assets_AssetId",
                table: "AssetRequisition",
                column: "AssetId",
                principalTable: "Assets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AssetRequisition_Employees_EmployeeId",
                table: "AssetRequisition",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_AspNetUsers_UserId",
                table: "Assets",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_AssetsTypes_AssetTypeId",
                table: "Assets",
                column: "AssetTypeId",
                principalTable: "AssetsTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_CompanyInfos_CompanyId",
                table: "Assets",
                column: "CompanyId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AssetsTypes_AspNetUsers_UserId",
                table: "AssetsTypes",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AssetsTypes_BranchInfos_BranchId",
                table: "AssetsTypes",
                column: "BranchId",
                principalTable: "BranchInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AssetsTypes_CompanyInfos_CompanyId",
                table: "AssetsTypes",
                column: "CompanyId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AwardTypes_CompanyInfos_CompanyId",
                table: "AwardTypes",
                column: "CompanyId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BankInfos_BranchInfos_BranchId",
                table: "BankInfos",
                column: "BranchId",
                principalTable: "BranchInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BranchInfos_AspNetUsers_UserId",
                table: "BranchInfos",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BranchInfos_Citys_CityId",
                table: "BranchInfos",
                column: "CityId",
                principalTable: "Citys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BranchInfos_Countrys_CountryId",
                table: "BranchInfos",
                column: "CountryId",
                principalTable: "Countrys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BranchInfos_States_CompanyStateId",
                table: "BranchInfos",
                column: "CompanyStateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClaimTypes_CompanyInfos_CompanyId",
                table: "ClaimTypes",
                column: "CompanyId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyInfos_AspNetUsers_UserId",
                table: "CompanyInfos",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyInfos_Citys_CityId",
                table: "CompanyInfos",
                column: "CityId",
                principalTable: "Citys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyInfos_Countrys_CountryId",
                table: "CompanyInfos",
                column: "CountryId",
                principalTable: "Countrys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyInfos_States_StateId",
                table: "CompanyInfos",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DistributeAssets_Assets_AssetId",
                table: "DistributeAssets",
                column: "AssetId",
                principalTable: "Assets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentCategorias_CompanyInfos_CompanyId",
                table: "DocumentCategorias",
                column: "CompanyId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EducationsGroups_CompanyInfos_CompanyId",
                table: "EducationsGroups",
                column: "CompanyId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EducationsTypes_CompanyInfos_CompanyId",
                table: "EducationsTypes",
                column: "CompanyId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmploymentCategories_CompanyInfos_CompanyId",
                table: "EmploymentCategories",
                column: "CompanyId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_CompanyInfos_CompanyId",
                table: "Grades",
                column: "CompanyId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Institutes_CompanyInfos_CompanyId",
                table: "Institutes",
                column: "CompanyId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobBaseStatuses_BranchInfos_BranchId",
                table: "JobBaseStatuses",
                column: "BranchId",
                principalTable: "BranchInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobBaseStatuses_CompanyInfos_CompanyId",
                table: "JobBaseStatuses",
                column: "CompanyId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobBaseStatuses_Projects_ProjectId",
                table: "JobBaseStatuses",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveTypes_CompanyInfos_CompanyId",
                table: "LeaveTypes",
                column: "CompanyId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NewApprovalWorkflows_CompanyInfos_CompanyId",
                table: "NewApprovalWorkflows",
                column: "CompanyId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NewJobStatus_BranchInfos_BranchId",
                table: "NewJobStatus",
                column: "BranchId",
                principalTable: "BranchInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NewJobStatus_CompanyInfos_CompanyId",
                table: "NewJobStatus",
                column: "CompanyId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NewJobStatus_Projects_ProjectId",
                table: "NewJobStatus",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OpeningYears_CompanyInfos_CompanyId",
                table: "OpeningYears",
                column: "CompanyId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_AspNetUsers_UserId",
                table: "Projects",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_BranchInfos_BranchId",
                table: "Projects",
                column: "BranchId",
                principalTable: "BranchInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_CompanyInfos_CompanyId",
                table: "Projects",
                column: "CompanyId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SupervisorSetups_CompanyInfos_CompanyId",
                table: "SupervisorSetups",
                column: "CompanyId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SupervisorSetups_Employees_EmployeeId",
                table: "SupervisorSetups",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WarningTypes_CompanyInfos_CompanyId",
                table: "WarningTypes",
                column: "CompanyId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkflowMaps_BranchInfos_BranchId",
                table: "WorkflowMaps",
                column: "BranchId",
                principalTable: "BranchInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkflowMaps_CompanyInfos_CompanyId",
                table: "WorkflowMaps",
                column: "CompanyId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkflowMaps_Departments_DepartmentId",
                table: "WorkflowMaps",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkflowMaps_Employees_EmployeeId",
                table: "WorkflowMaps",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkflowMaps_NewApprovalWorkflows_WorkflowId",
                table: "WorkflowMaps",
                column: "WorkflowId",
                principalTable: "NewApprovalWorkflows",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssetRequisition_AspNetUsers_UserId",
                table: "AssetRequisition");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetRequisition_Assets_AssetId",
                table: "AssetRequisition");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetRequisition_Employees_EmployeeId",
                table: "AssetRequisition");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_AspNetUsers_UserId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_AssetsTypes_AssetTypeId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_CompanyInfos_CompanyId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetsTypes_AspNetUsers_UserId",
                table: "AssetsTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetsTypes_BranchInfos_BranchId",
                table: "AssetsTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetsTypes_CompanyInfos_CompanyId",
                table: "AssetsTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_AwardTypes_CompanyInfos_CompanyId",
                table: "AwardTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_BankInfos_BranchInfos_BranchId",
                table: "BankInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_BranchInfos_AspNetUsers_UserId",
                table: "BranchInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_BranchInfos_Citys_CityId",
                table: "BranchInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_BranchInfos_Countrys_CountryId",
                table: "BranchInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_BranchInfos_States_CompanyStateId",
                table: "BranchInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_ClaimTypes_CompanyInfos_CompanyId",
                table: "ClaimTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyInfos_AspNetUsers_UserId",
                table: "CompanyInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyInfos_Citys_CityId",
                table: "CompanyInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyInfos_Countrys_CountryId",
                table: "CompanyInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyInfos_States_StateId",
                table: "CompanyInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_DistributeAssets_Assets_AssetId",
                table: "DistributeAssets");

            migrationBuilder.DropForeignKey(
                name: "FK_DocumentCategorias_CompanyInfos_CompanyId",
                table: "DocumentCategorias");

            migrationBuilder.DropForeignKey(
                name: "FK_EducationsGroups_CompanyInfos_CompanyId",
                table: "EducationsGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_EducationsTypes_CompanyInfos_CompanyId",
                table: "EducationsTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_EmploymentCategories_CompanyInfos_CompanyId",
                table: "EmploymentCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Grades_CompanyInfos_CompanyId",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_Institutes_CompanyInfos_CompanyId",
                table: "Institutes");

            migrationBuilder.DropForeignKey(
                name: "FK_JobBaseStatuses_BranchInfos_BranchId",
                table: "JobBaseStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_JobBaseStatuses_CompanyInfos_CompanyId",
                table: "JobBaseStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_JobBaseStatuses_Projects_ProjectId",
                table: "JobBaseStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveTypes_CompanyInfos_CompanyId",
                table: "LeaveTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_NewApprovalWorkflows_CompanyInfos_CompanyId",
                table: "NewApprovalWorkflows");

            migrationBuilder.DropForeignKey(
                name: "FK_NewJobStatus_BranchInfos_BranchId",
                table: "NewJobStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_NewJobStatus_CompanyInfos_CompanyId",
                table: "NewJobStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_NewJobStatus_Projects_ProjectId",
                table: "NewJobStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_OpeningYears_CompanyInfos_CompanyId",
                table: "OpeningYears");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_AspNetUsers_UserId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_BranchInfos_BranchId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_CompanyInfos_CompanyId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_SupervisorSetups_CompanyInfos_CompanyId",
                table: "SupervisorSetups");

            migrationBuilder.DropForeignKey(
                name: "FK_SupervisorSetups_Employees_EmployeeId",
                table: "SupervisorSetups");

            migrationBuilder.DropForeignKey(
                name: "FK_WarningTypes_CompanyInfos_CompanyId",
                table: "WarningTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkflowMaps_BranchInfos_BranchId",
                table: "WorkflowMaps");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkflowMaps_CompanyInfos_CompanyId",
                table: "WorkflowMaps");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkflowMaps_Departments_DepartmentId",
                table: "WorkflowMaps");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkflowMaps_Employees_EmployeeId",
                table: "WorkflowMaps");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkflowMaps_NewApprovalWorkflows_WorkflowId",
                table: "WorkflowMaps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkflowMaps",
                table: "WorkflowMaps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WarningTypes",
                table: "WarningTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SupervisorSetups",
                table: "SupervisorSetups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projects",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OpeningYears",
                table: "OpeningYears");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NewApprovalWorkflows",
                table: "NewApprovalWorkflows");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeaveTypes",
                table: "LeaveTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobBaseStatuses",
                table: "JobBaseStatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Institutes",
                table: "Institutes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Grades",
                table: "Grades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmploymentCategories",
                table: "EmploymentCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EducationsTypes",
                table: "EducationsTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EducationsGroups",
                table: "EducationsGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DocumentCategorias",
                table: "DocumentCategorias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyInfos",
                table: "CompanyInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClaimTypes",
                table: "ClaimTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BranchInfos",
                table: "BranchInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AwardTypes",
                table: "AwardTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssetsTypes",
                table: "AssetsTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assets",
                table: "Assets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssetRequisition",
                table: "AssetRequisition");

            migrationBuilder.RenameTable(
                name: "WorkflowMaps",
                newName: "WorkflowMaping");

            migrationBuilder.RenameTable(
                name: "WarningTypes",
                newName: "WarningType");

            migrationBuilder.RenameTable(
                name: "SupervisorSetups",
                newName: "SupervisorSetup");

            migrationBuilder.RenameTable(
                name: "Projects",
                newName: "Project");

            migrationBuilder.RenameTable(
                name: "OpeningYears",
                newName: "OpeningYear");

            migrationBuilder.RenameTable(
                name: "NewApprovalWorkflows",
                newName: "NewApprovalWorkflow");

            migrationBuilder.RenameTable(
                name: "LeaveTypes",
                newName: "LeaveType");

            migrationBuilder.RenameTable(
                name: "JobBaseStatuses",
                newName: "JobBaseStatus");

            migrationBuilder.RenameTable(
                name: "Institutes",
                newName: "Institute");

            migrationBuilder.RenameTable(
                name: "Grades",
                newName: "Grade");

            migrationBuilder.RenameTable(
                name: "EmploymentCategories",
                newName: "EmploymentCategorie");

            migrationBuilder.RenameTable(
                name: "EducationsTypes",
                newName: "EducationType");

            migrationBuilder.RenameTable(
                name: "EducationsGroups",
                newName: "EducationGroup");

            migrationBuilder.RenameTable(
                name: "DocumentCategorias",
                newName: "DocumentCategorie");

            migrationBuilder.RenameTable(
                name: "CompanyInfos",
                newName: "CompanyInfo");

            migrationBuilder.RenameTable(
                name: "ClaimTypes",
                newName: "ClaimType");

            migrationBuilder.RenameTable(
                name: "BranchInfos",
                newName: "BranchInfo");

            migrationBuilder.RenameTable(
                name: "AwardTypes",
                newName: "AwardType");

            migrationBuilder.RenameTable(
                name: "AssetsTypes",
                newName: "AssetType");

            migrationBuilder.RenameTable(
                name: "Assets",
                newName: "Asset");

            migrationBuilder.RenameTable(
                name: "AssetRequisition",
                newName: "AssetRequisitions");

            migrationBuilder.RenameIndex(
                name: "IX_WorkflowMaps_WorkflowId",
                table: "WorkflowMaping",
                newName: "IX_WorkflowMaping_WorkflowId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkflowMaps_EmployeeId",
                table: "WorkflowMaping",
                newName: "IX_WorkflowMaping_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkflowMaps_DepartmentId",
                table: "WorkflowMaping",
                newName: "IX_WorkflowMaping_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkflowMaps_CompanyId",
                table: "WorkflowMaping",
                newName: "IX_WorkflowMaping_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkflowMaps_BranchId",
                table: "WorkflowMaping",
                newName: "IX_WorkflowMaping_BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_WarningTypes_CompanyId",
                table: "WarningType",
                newName: "IX_WarningType_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_SupervisorSetups_EmployeeId",
                table: "SupervisorSetup",
                newName: "IX_SupervisorSetup_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_SupervisorSetups_CompanyId",
                table: "SupervisorSetup",
                newName: "IX_SupervisorSetup_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_UserId",
                table: "Project",
                newName: "IX_Project_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_CompanyId",
                table: "Project",
                newName: "IX_Project_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_BranchId",
                table: "Project",
                newName: "IX_Project_BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_OpeningYears_CompanyId",
                table: "OpeningYear",
                newName: "IX_OpeningYear_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_NewApprovalWorkflows_CompanyId",
                table: "NewApprovalWorkflow",
                newName: "IX_NewApprovalWorkflow_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveTypes_CompanyId",
                table: "LeaveType",
                newName: "IX_LeaveType_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_JobBaseStatuses_ProjectId",
                table: "JobBaseStatus",
                newName: "IX_JobBaseStatus_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_JobBaseStatuses_CompanyId",
                table: "JobBaseStatus",
                newName: "IX_JobBaseStatus_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_JobBaseStatuses_BranchId",
                table: "JobBaseStatus",
                newName: "IX_JobBaseStatus_BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_Institutes_CompanyId",
                table: "Institute",
                newName: "IX_Institute_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Grades_CompanyId",
                table: "Grade",
                newName: "IX_Grade_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_EmploymentCategories_CompanyId",
                table: "EmploymentCategorie",
                newName: "IX_EmploymentCategorie_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_EducationsTypes_CompanyId",
                table: "EducationType",
                newName: "IX_EducationType_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_EducationsGroups_CompanyId",
                table: "EducationGroup",
                newName: "IX_EducationGroup_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_DocumentCategorias_CompanyId",
                table: "DocumentCategorie",
                newName: "IX_DocumentCategorie_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyInfos_UserId",
                table: "CompanyInfo",
                newName: "IX_CompanyInfo_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyInfos_StateId",
                table: "CompanyInfo",
                newName: "IX_CompanyInfo_StateId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyInfos_CountryId",
                table: "CompanyInfo",
                newName: "IX_CompanyInfo_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyInfos_CityId",
                table: "CompanyInfo",
                newName: "IX_CompanyInfo_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_ClaimTypes_CompanyId",
                table: "ClaimType",
                newName: "IX_ClaimType_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_BranchInfos_UserId",
                table: "BranchInfo",
                newName: "IX_BranchInfo_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_BranchInfos_CountryId",
                table: "BranchInfo",
                newName: "IX_BranchInfo_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_BranchInfos_CompanyStateId",
                table: "BranchInfo",
                newName: "IX_BranchInfo_CompanyStateId");

            migrationBuilder.RenameIndex(
                name: "IX_BranchInfos_CityId",
                table: "BranchInfo",
                newName: "IX_BranchInfo_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_AwardTypes_CompanyId",
                table: "AwardType",
                newName: "IX_AwardType_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_AssetsTypes_UserId",
                table: "AssetType",
                newName: "IX_AssetType_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AssetsTypes_CompanyId",
                table: "AssetType",
                newName: "IX_AssetType_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_AssetsTypes_BranchId",
                table: "AssetType",
                newName: "IX_AssetType_BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_Assets_UserId",
                table: "Asset",
                newName: "IX_Asset_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Assets_CompanyId",
                table: "Asset",
                newName: "IX_Asset_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Assets_AssetTypeId",
                table: "Asset",
                newName: "IX_Asset_AssetTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_AssetRequisition_UserId",
                table: "AssetRequisitions",
                newName: "IX_AssetRequisitions_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AssetRequisition_EmployeeId",
                table: "AssetRequisitions",
                newName: "IX_AssetRequisitions_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_AssetRequisition_AssetId",
                table: "AssetRequisitions",
                newName: "IX_AssetRequisitions_AssetId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkflowMaping",
                table: "WorkflowMaping",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WarningType",
                table: "WarningType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupervisorSetup",
                table: "SupervisorSetup",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Project",
                table: "Project",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OpeningYear",
                table: "OpeningYear",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewApprovalWorkflow",
                table: "NewApprovalWorkflow",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeaveType",
                table: "LeaveType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobBaseStatus",
                table: "JobBaseStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Institute",
                table: "Institute",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Grade",
                table: "Grade",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmploymentCategorie",
                table: "EmploymentCategorie",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EducationType",
                table: "EducationType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EducationGroup",
                table: "EducationGroup",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DocumentCategorie",
                table: "DocumentCategorie",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyInfo",
                table: "CompanyInfo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClaimType",
                table: "ClaimType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BranchInfo",
                table: "BranchInfo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AwardType",
                table: "AwardType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssetType",
                table: "AssetType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Asset",
                table: "Asset",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssetRequisitions",
                table: "AssetRequisitions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_AspNetUsers_UserId",
                table: "Asset",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_AssetType_AssetTypeId",
                table: "Asset",
                column: "AssetTypeId",
                principalTable: "AssetType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_CompanyInfo_CompanyId",
                table: "Asset",
                column: "CompanyId",
                principalTable: "CompanyInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AssetRequisitions_AspNetUsers_UserId",
                table: "AssetRequisitions",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AssetRequisitions_Asset_AssetId",
                table: "AssetRequisitions",
                column: "AssetId",
                principalTable: "Asset",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AssetRequisitions_Employees_EmployeeId",
                table: "AssetRequisitions",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AssetType_AspNetUsers_UserId",
                table: "AssetType",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AssetType_BranchInfo_BranchId",
                table: "AssetType",
                column: "BranchId",
                principalTable: "BranchInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AssetType_CompanyInfo_CompanyId",
                table: "AssetType",
                column: "CompanyId",
                principalTable: "CompanyInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AwardType_CompanyInfo_CompanyId",
                table: "AwardType",
                column: "CompanyId",
                principalTable: "CompanyInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BankInfos_BranchInfo_BranchId",
                table: "BankInfos",
                column: "BranchId",
                principalTable: "BranchInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BranchInfo_AspNetUsers_UserId",
                table: "BranchInfo",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BranchInfo_Citys_CityId",
                table: "BranchInfo",
                column: "CityId",
                principalTable: "Citys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BranchInfo_Countrys_CountryId",
                table: "BranchInfo",
                column: "CountryId",
                principalTable: "Countrys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BranchInfo_States_CompanyStateId",
                table: "BranchInfo",
                column: "CompanyStateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClaimType_CompanyInfo_CompanyId",
                table: "ClaimType",
                column: "CompanyId",
                principalTable: "CompanyInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyInfo_AspNetUsers_UserId",
                table: "CompanyInfo",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyInfo_Citys_CityId",
                table: "CompanyInfo",
                column: "CityId",
                principalTable: "Citys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyInfo_Countrys_CountryId",
                table: "CompanyInfo",
                column: "CountryId",
                principalTable: "Countrys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyInfo_States_StateId",
                table: "CompanyInfo",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DistributeAssets_Asset_AssetId",
                table: "DistributeAssets",
                column: "AssetId",
                principalTable: "Asset",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentCategorie_CompanyInfo_CompanyId",
                table: "DocumentCategorie",
                column: "CompanyId",
                principalTable: "CompanyInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EducationGroup_CompanyInfo_CompanyId",
                table: "EducationGroup",
                column: "CompanyId",
                principalTable: "CompanyInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EducationType_CompanyInfo_CompanyId",
                table: "EducationType",
                column: "CompanyId",
                principalTable: "CompanyInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmploymentCategorie_CompanyInfo_CompanyId",
                table: "EmploymentCategorie",
                column: "CompanyId",
                principalTable: "CompanyInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Grade_CompanyInfo_CompanyId",
                table: "Grade",
                column: "CompanyId",
                principalTable: "CompanyInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Institute_CompanyInfo_CompanyId",
                table: "Institute",
                column: "CompanyId",
                principalTable: "CompanyInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobBaseStatus_BranchInfo_BranchId",
                table: "JobBaseStatus",
                column: "BranchId",
                principalTable: "BranchInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobBaseStatus_CompanyInfo_CompanyId",
                table: "JobBaseStatus",
                column: "CompanyId",
                principalTable: "CompanyInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobBaseStatus_Project_ProjectId",
                table: "JobBaseStatus",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveType_CompanyInfo_CompanyId",
                table: "LeaveType",
                column: "CompanyId",
                principalTable: "CompanyInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NewApprovalWorkflow_CompanyInfo_CompanyId",
                table: "NewApprovalWorkflow",
                column: "CompanyId",
                principalTable: "CompanyInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NewJobStatus_BranchInfo_BranchId",
                table: "NewJobStatus",
                column: "BranchId",
                principalTable: "BranchInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NewJobStatus_CompanyInfo_CompanyId",
                table: "NewJobStatus",
                column: "CompanyId",
                principalTable: "CompanyInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NewJobStatus_Project_ProjectId",
                table: "NewJobStatus",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OpeningYear_CompanyInfo_CompanyId",
                table: "OpeningYear",
                column: "CompanyId",
                principalTable: "CompanyInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Project_AspNetUsers_UserId",
                table: "Project",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Project_BranchInfo_BranchId",
                table: "Project",
                column: "BranchId",
                principalTable: "BranchInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Project_CompanyInfo_CompanyId",
                table: "Project",
                column: "CompanyId",
                principalTable: "CompanyInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SupervisorSetup_CompanyInfo_CompanyId",
                table: "SupervisorSetup",
                column: "CompanyId",
                principalTable: "CompanyInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SupervisorSetup_Employees_EmployeeId",
                table: "SupervisorSetup",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WarningType_CompanyInfo_CompanyId",
                table: "WarningType",
                column: "CompanyId",
                principalTable: "CompanyInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkflowMaping_BranchInfo_BranchId",
                table: "WorkflowMaping",
                column: "BranchId",
                principalTable: "BranchInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkflowMaping_CompanyInfo_CompanyId",
                table: "WorkflowMaping",
                column: "CompanyId",
                principalTable: "CompanyInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkflowMaping_Departments_DepartmentId",
                table: "WorkflowMaping",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkflowMaping_Employees_EmployeeId",
                table: "WorkflowMaping",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkflowMaping_NewApprovalWorkflow_WorkflowId",
                table: "WorkflowMaping",
                column: "WorkflowId",
                principalTable: "NewApprovalWorkflow",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
