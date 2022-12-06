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
    public class LeaveTypeController : GenericBaseController<LeaveType>
    {
        private readonly ILeaveTypeService _leavetypeService;

        public LeaveTypeController(ILeaveTypeService leavetypeService) : base(leavetypeService)
        {
            _leavetypeService = leavetypeService;
        }
        [HttpGet("company_dropdown")]
        public async Task<IActionResult> GetCompanyDropdownAsync(long? companyId = null, string searchText = null)
        {
            var res = await _leavetypeService.GetCompanyDropdownAsync(companyId, searchText);

            return new ApiOkActionResult(res);
        }
    }
}
