using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApp.Extensions;
using WebApp.Helpers.Base;
using WebApp.Service.Services.Configurations;
using WebApp.Services;
using WebApp.Sql.Entities.Configurations;

namespace WebApp.Controllers.Configurations
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : GenericBaseController<Status>
    {
        private readonly IStatusService _statusService;

        public StatusController(IStatusService statusService) : base(statusService)
        {
            this._statusService = statusService;
        }

        [HttpGet("dropdown")]
        public async Task<IActionResult> GetDropdownAsync(string searchText = null) 
        {
            var res = await _statusService.GetDropdownAsync(searchText);

            return new ApiOkActionResult(res);
            
        }
    }
}
