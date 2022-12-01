using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Service.Models.Enrols;
using WebApp.Services;
using WebApp.Sql.Entities.Enrols;

namespace WebApp.Service
{
    public interface IDepartmentSetupService:IBaseService<DepartmentSetup>
    {
        Task<DepartmentSetupModel> GetDepartmentSetupDetailAsync(long departmentSetupId);
        Task<DepartmentSetupModel> AddDepartmentSetupDetailAsync(DepartmentSetupModel model);
        Task<DepartmentSetupModel> UpdateDepartmentSetupDetailAsync(long departmentSetupId, DepartmentSetupModel model);
        Task<DepartmentSetupModel> UpdateDepartmentSetupDetailAsync(long departmentSetupId, string model);
    }
}
