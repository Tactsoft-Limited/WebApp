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
    public class ProficiencyController : GenericBaseController<Proficiency>
    {
        private readonly IProficiencyService _proficiencyService;

        public ProficiencyController(IProficiencyService proficiencyService) : base(proficiencyService)
        {
            this._proficiencyService = proficiencyService;
        }

        [HttpGet("dropdown")]
        public async Task<IActionResult> GetDropdownAsync(string searchText = null)
        {
            var res = await _proficiencyService.GetDropdownAsync(searchText);

            return new ApiOkActionResult(res);
        }
    }
}
