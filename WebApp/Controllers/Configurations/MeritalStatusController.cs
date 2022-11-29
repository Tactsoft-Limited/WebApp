using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApp.Extensions;
using WebApp.Helpers.Base;
using WebApp.Service.Models.Configurations;
using WebApp.Service.Services.Configurations;
using WebApp.Services;
using WebApp.Sql.Entities.Configurations;

namespace WebApp.Controllers.Configurations
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeritalStatusController : GenericBaseController<MeritalStatus>
    {
        private readonly IMeritalStatusService  _meritalStatusService;

        public MeritalStatusController(IMeritalStatusService meritalStatusService) : base(meritalStatusService)
        {
            _meritalStatusService = meritalStatusService;
        }

        [HttpGet("dropdown")]
        public async Task<IActionResult> GetDropdownAsync(string searchText = null)
        {
            var res = await _meritalStatusService.GetDropdownAsync(searchText);

            return new ApiOkActionResult(res);
        }

    }
}
