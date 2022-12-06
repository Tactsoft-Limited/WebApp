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
    public class NewApprovalWorkflowController : GenericBaseController<NewApprovalWorkflow>
    {
        private readonly INewApprovalWorkflowService _newapprovalworkflowService;

        public NewApprovalWorkflowController(INewApprovalWorkflowService newapprovalworkflowService) : base(newapprovalworkflowService)
        {
            _newapprovalworkflowService = newapprovalworkflowService;
        }
        [HttpGet("company_dropdown")]
        public async Task<IActionResult> GetCompanyDropdownAsync(long? companyId = null, string searchText = null)
        {
            var res = await _newapprovalworkflowService.GetCompanyDropdownAsync(companyId, searchText);

            return new ApiOkActionResult(res);
        }
    }
}
