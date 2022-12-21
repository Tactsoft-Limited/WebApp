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
    public class SupervisorSetupController : GenericBaseController<SupervisorSetup>
    {
        private readonly ISupervisorSetupService _supervisorsetupService;

        public SupervisorSetupController(ISupervisorSetupService supervisorsetupService) : base(supervisorsetupService)
        {
            _supervisorsetupService = supervisorsetupService;
        }
        [HttpGet("company_dropdown")]
        public async Task<IActionResult> GetCompanyDropdownAsync(long? companyId = null, string searchText = null)
        {
            var res = await _supervisorsetupService.GetDropdownAsync(companyId, searchText);

            return new ApiOkActionResult(res);
        }
        
    }
}
