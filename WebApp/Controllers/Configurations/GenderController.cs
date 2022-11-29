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
    public class GenderController : GenericBaseController<Gender>
    {
        private readonly IGenderService _genderService;

        public GenderController(IGenderService genderService) : base(genderService)
        {
            _genderService = genderService;
        }

        [HttpGet("dropdown")]
        public async Task<IActionResult> GetDropdownAsync(string searchText = null)
        {
            var res = await _genderService.GetDropdownAsync(searchText);

            return new ApiOkActionResult(res);
        }
    }
}
