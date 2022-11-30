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
    public class BloodGroupController : GenericBaseController<BloodGroup>
    {
        private readonly IBloodGroupService _bloodGroupService;

        public BloodGroupController(IBloodGroupService bloodGroupService) : base(bloodGroupService)
        {
            _bloodGroupService = bloodGroupService;
        }

        [HttpGet("dropdown")]
        public async Task<IActionResult> GetDropdownAsync(string searchText = null)
        {
            var res = await _bloodGroupService.GetDropdownAsync(searchText);

            return new ApiOkActionResult(res);
        }
    }
}
