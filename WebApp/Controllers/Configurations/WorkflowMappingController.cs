using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApp.Extensions;
using WebApp.Helpers.Base;
using WebApp.Service.Services.Configurations;
using WebApp.Sql.Entities.Configurations;

namespace WebApp.Controllers.Configurations
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkflowMappingController : GenericBaseController<WorkflowMaping>
    {
        private readonly IWorkflowMappingService _workflowmappingService;

        public WorkflowMappingController(IWorkflowMappingService workflowmappingService) : base(workflowmappingService)
        {
            _workflowmappingService = workflowmappingService;
        }
        [HttpGet("company_dropdown")]
        public async Task<IActionResult> GetCompanyDropdownAsync(long? companyId = null, string searchText = null)
        {
            var res = await _workflowmappingService.GetCompanyDropdownAsync(companyId, searchText);

            return new ApiOkActionResult(res);
        }
        [HttpGet("employww_dropdown")]
        public async Task<IActionResult> GetEmployeeDropdownAsync(long? employeeId = null, string searchText = null)
        {
            var res = await _workflowmappingService.GetEmployeeDropdownAsync(employeeId, searchText);

            return new ApiOkActionResult(res);
        }
        [HttpGet("branch_dropdown")]
        public async Task<IActionResult> GetBranchDropdownAsync(long? branchId = null, string searchText = null)
        {
            var res = await _workflowmappingService.GetBranchDropdownAsync(branchId, searchText);

            return new ApiOkActionResult(res);
        }
        [HttpGet("department_dropdown")]
        public async Task<IActionResult> GetDepartmentDropdownAsync(long? departmentId = null, string searchText = null)
        {
            var res = await _workflowmappingService.GetDepartmentDropdownAsync(departmentId, searchText);

            return new ApiOkActionResult(res);
        }
        [HttpGet("workflow_dropdown")]
        public async Task<IActionResult> GetWorkflowDropdownAsync(long? workflowId = null, string searchText = null)
        {
            var res = await _workflowmappingService.GetWorkflowDropdownAsync(workflowId, searchText);

            return new ApiOkActionResult(res);
        }
    }
}
