using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Core;
using WebApp.Core.Collections;
using WebApp.Service.Models.Configurations;
using WebApp.Services;
using WebApp.Sql.Entities.Configurations;

namespace WebApp.Service.Services.Configurations
{
    public interface IJobBaseStatusService : IBaseService<JobBaseStatus>
    {
        Task<Dropdown<JobBaseStatusModel>> GetCompanyDropdownAsync(long? companyId = null, string searchText = null, int size = CommonVariables.DropdownSize);
        Task<Dropdown<JobBaseStatusModel>> GetProjectDropdownAsync(long? companyId = null, string searchText = null, int size = CommonVariables.DropdownSize);
        Task<Dropdown<JobBaseStatusModel>> GetBranchDropdownAsync(long? companyId = null, string searchText = null, int size = CommonVariables.DropdownSize);
    }
}
