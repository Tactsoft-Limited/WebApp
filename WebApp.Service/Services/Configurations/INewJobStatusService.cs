using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Core;
using WebApp.Core.Collections;
using WebApp.Service.Models.Configurations;
using WebApp.Services;
using WebApp.Sql.Entities.Enrols;

namespace WebApp.Service.Services.Configurations
{
    public interface INewJobStatusService : IBaseService<NewJobStatus>
    {
        Task<Dropdown<NewJobStatusModel>> GetCompanyDropdownAsync(long? companyId = null, string searchText = null, int size = CommonVariables.DropdownSize);
        Task<Dropdown<NewJobStatusModel>> GetProjectDropdownAsync(long? companyId = null, string searchText = null, int size = CommonVariables.DropdownSize);
        Task<Dropdown<NewJobStatusModel>> GetBranchDropdownAsync(long? companyId = null, string searchText = null, int size = CommonVariables.DropdownSize);
    }
}
