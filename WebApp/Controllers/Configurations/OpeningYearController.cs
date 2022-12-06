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
    public class OpeningYearController : GenericBaseController<OpeningYear>
    {
        private readonly IOpeningYearService _openingService;

        public OpeningYearController(IOpeningYearService openingService) : base(openingService)
        {
            _openingService = openingService;
        }
        [HttpGet("company_dropdown")]
        public async Task<IActionResult> GetCompanyDropdownAsync(long? companyId = null, string searchText = null)
        {
            var res = await _openingService.GetCompanyDropdownAsync(companyId, searchText);

            return new ApiOkActionResult(res);
        }
    }
}
