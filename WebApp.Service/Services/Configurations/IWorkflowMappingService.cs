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
    public interface IWorkflowMappingService : IBaseService<WorkflowMaping>
    {
        Task<Dropdown<WorkflowMappingModel>> GetCompanyDropdownAsync(long? companyId = null, string searchText = null, int size = CommonVariables.DropdownSize);
        Task<Dropdown<WorkflowMappingModel>> GetEmployeeDropdownAsync(long? employeeId = null, string searchText = null, int size = CommonVariables.DropdownSize);
        Task<Dropdown<WorkflowMappingModel>> GetBranchDropdownAsync(long? branchId = null, string searchText = null, int size = CommonVariables.DropdownSize);
        Task<Dropdown<WorkflowMappingModel>> GetDepartmentDropdownAsync(long? departmentId = null, string searchText = null, int size = CommonVariables.DropdownSize);
        Task<Dropdown<WorkflowMappingModel>> GetWorkflowDropdownAsync(long? workflowId = null, string searchText = null, int size = CommonVariables.DropdownSize);
    }
}
