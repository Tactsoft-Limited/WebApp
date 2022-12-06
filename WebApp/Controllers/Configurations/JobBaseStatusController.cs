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
    public class JobBaseStatusController : GenericBaseController<JobBaseStatus>
    {
        private readonly IJobBaseStatusService _jobbasestatusService;

        public JobBaseStatusController(IJobBaseStatusService jobbasestatusService) : base(jobbasestatusService)
        {
            _jobbasestatusService = jobbasestatusService;
        }
        [HttpGet("company_dropdown")]
        public async Task<IActionResult> GetCompanyDropdownAsync(long? companyId = null, string searchText = null)
        {
            var res = await _jobbasestatusService.GetCompanyDropdownAsync(companyId, searchText);

            return new ApiOkActionResult(res);
        }
        [HttpGet("project_dropdown")]
        public async Task<IActionResult> GetProjectDropdownAsync(long? projectId = null, string searchText = null)
        {
            var res = await _jobbasestatusService.GetProjectDropdownAsync(projectId, searchText);

            return new ApiOkActionResult(res);
        }
        [HttpGet("branch_dropdown")]
        public async Task<IActionResult> GetBranchDropdownAsync(long? branchId = null, string searchText = null)
        {
            var res = await _jobbasestatusService.GetBranchDropdownAsync(branchId, searchText);

            return new ApiOkActionResult(res);
        }
    }
}
