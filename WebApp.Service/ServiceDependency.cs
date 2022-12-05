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
            services.AddScoped<IPassportService, PassportService>();
            services.AddScoped<IJobNewStatusService, JobNewStatusService>();
            services.AddScoped<IDistributeAssetService, DistributeAssetService>();
            services.AddScoped<IAssetRequisitionService, AssetRequisitionService>();



            services.AddScoped<ISupervisorService, SupervisorService>();
            services.AddScoped<IFunctionalDesignationService, FunctionalDesignationService>();
            services.AddScoped<IProficiencyService, ProficiencyService>();
            services.AddScoped<IReligionService, ReligionService>();
            services.AddScoped<IFamilyInfoService, FamilyInfoService>();
            services.AddScoped<IEmployeeManagementCategoryService, EmployeeManagementCategoryService>();


        }
    }
}
