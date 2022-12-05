using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApp.Extensions;
using WebApp.Helpers.Base;
using WebApp.Service;
using WebApp.Service.Models.Enrols;
using WebApp.Services;
using WebApp.Sql.Entities.Enrols;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationController : GenericBaseController<Education>
    {
        private readonly IEducationService _educationService;

        public EducationController(IEducationService educationService) : base(educationService)
        {
            this._educationService = educationService;
        }

        [HttpGet("{educationId}")]
        public async Task<IActionResult> GetEducationDetailsAsync(long educationId)
        {
            var res = await _educationService.GetEducationDetailsAsync(educationId);

            return new ApiOkActionResult(res);
        }
        [HttpPost()]
        public async Task<IActionResult> AddEducationDetailsAsync([FromForm] EducationModel model)
        {
            var res = await _educationService.AddEducationDetailsAsync(model);

            return new ApiOkActionResult(res);
        }
        [HttpPut("{educationId}")]
        public async Task<IActionResult> UpdateEducationDetailsAsync(long educationId, [FromForm] EducationModel model)
        {

            var res = await _educationService.UpdateEducationDetailsAsync(educationId, model);

            return new ApiOkActionResult(res);
        }
    }
}
