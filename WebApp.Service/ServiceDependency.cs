using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using WebApp.Core;
using WebApp.Core.Acls;
using WebApp.Core.Helpers;
using WebApp.Core.Interface;
using WebApp.Service.Services;
using WebApp.Service.Services.Configurations;
using WebApp.Services;
using WebApp.Sql.Entities.Enrols;

namespace WebApp.Service
{
    public static class ServiceDependency
    {
        public static void AddServiceDependency(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient(typeof(IBaseService<>), typeof(BaseService<>));
            services.Configure<AppSettings>(configuration.GetSection(nameof(AppSettings)));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddTransient<ISignInHelper, SignInHelper>();
            services.AddScoped<IUserInformationService, UserInformationService>();
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<IStateService, StateService>();
            services.AddScoped<ICityService, CityService>();
            services.AddScoped<IEmployeesService, EmployeesService>();
            services.AddScoped<IDesignationService, DesignationService>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IGenderService, GenderService>();
            services.AddScoped<IMeritalStatusService, MeritalStatusService>();
            services.AddScoped<IBloodGroupService, BloodGroupService>();
            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IDepartmentSetupService, DepartmentSetupService>();
            services.AddScoped<ISupervisorService, SupervisorService>();
            services.AddScoped<IWarningService, WarningService>();


            services.AddScoped<ISupervisorService, SupervisorService>();
            services.AddScoped<IFunctionalDesignationService, FunctionalDesignationService>();
            services.AddScoped<IProficiencyService, ProficiencyService>();
            services.AddScoped<IReligionService, ReligionService>();
            services.AddScoped<IFamilyInfoService, FamilyInfoService>();
            services.AddScoped<ICompanyInfoService, CompanyInfoService>();
            services.AddScoped<IBranchInfoService, BranchInfoService>();
            services.AddScoped<IAssetTypeService, AssetTypeService>();
            services.AddScoped<IAssetService, AssetService>();  
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<INewJobStatusService, NewJobStatusService>();
            services.AddScoped<IJobBaseStatusService, JobBaseStatusService>();
            services.AddScoped<IEducationGroupService, EducationGroupService>();
            services.AddScoped<IEducationTypeService, EducationTypeService>();
            services.AddScoped<IGenderService, GenderService>();
            services.AddScoped<IInstituteService, InstituteService>();
            services.AddScoped<IEmploymentCategoryService, EmploymentCategoryService>();
            services.AddScoped<IDocumentCategoryService, DocumentCategoryService>();
            services.AddScoped<IAwardTypeService, AwardTypeService>();
            services.AddScoped<IWarningService, WarningService>();
            services.AddScoped<ISupervisorService, SupervisorService>();
            services.AddScoped<IWorkflowMappingService, WorkflowMappingService>();
            services.AddScoped<IClaimTypeService, ClaimTypeService>();
            services.AddScoped<IOpeningYearService, OpeningYearService>();
            services.AddScoped<IGradeService, GradeService>();
            services.AddScoped<IWarningTypeService, WarningTypeService>();
            services.AddScoped<ISupervisorSetupService, SupervisorSetupService>();
            services.AddScoped<INewApprovalWorkflowService, NewApprovalWorkflowService>();
            services.AddScoped<ILeaveTypeService, LeaveTypeService>();
        }
    }
}
