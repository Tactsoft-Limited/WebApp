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
    public class LanguageController : GenericBaseController<Language>
    {
        private readonly ILanguageService _languageService;

        public LanguageController(ILanguageService languageService) : base(languageService)
        {
            this._languageService = languageService;
        }

        [HttpGet("{languageId}")]
        public async Task<IActionResult> GetLanguageDetailAsync(long languageId)
        {
            var res = await _languageService.GetLanguageDetailAsync(languageId);

            return new ApiOkActionResult(res);
        }
        [HttpPost()]
        public async Task<IActionResult> AddLanguageDetailAsync([FromForm] LanguageModel model)
        {
            var res = await _languageService.AddLanguageDetailAsync(model);

            return new ApiOkActionResult(res);
        }
        [HttpPut("{languageId}")]
        public async Task<IActionResult> UpdateLanguageDetailAsync(long languageId, [FromForm] LanguageModel model)
        {

            var res = await _languageService.UpdateLanguageDetailAsync(languageId, model);

            return new ApiOkActionResult(res);
        }
    }
}
