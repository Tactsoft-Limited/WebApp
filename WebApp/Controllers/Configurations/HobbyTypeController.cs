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
    public class HobbyTypeController : GenericBaseController<HobbyType>
    {
        private readonly IHobbyTypeService _hobbyTypeService;

        public HobbyTypeController(IHobbyTypeService hobbyTypeService) : base(hobbyTypeService)
        {
            this._hobbyTypeService = hobbyTypeService;
        }

        [HttpGet("dropdown")]
        public async Task<IActionResult> GetDropdownAsync(string searchText = null)
        {
            var res = await _hobbyTypeService.GetDropdownAsync(searchText);

            return new ApiOkActionResult(res);
        }
    }
}
