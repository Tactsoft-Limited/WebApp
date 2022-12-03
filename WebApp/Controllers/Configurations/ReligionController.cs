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
    public class ReligionController : GenericBaseController<Religion>
    {
        private readonly IReligionService _religionService;

        public ReligionController(IReligionService religionService) : base(religionService)
        {
            this._religionService = religionService;
        }

        [HttpGet("dropdown")]
        public async Task<IActionResult> GetDropdownAsync(string searchText = null)
        {
            var res = await _religionService.GetDropdownAsync(searchText);

            return new ApiOkActionResult(res);
        }


    }
}
