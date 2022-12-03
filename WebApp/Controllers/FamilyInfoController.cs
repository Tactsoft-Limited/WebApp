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
    public class FamilyInfoController : GenericBaseController<FamilyInfo>
    {
        private readonly IFamilyInfoService _familyInfoService;

        public FamilyInfoController(IFamilyInfoService familyInfoService) : base(familyInfoService)
        {
            this._familyInfoService = familyInfoService;
        }

        [HttpGet("{familyInfoId}")]
        public async Task<IActionResult> GetFamilyInfoDetailAsync(long familyInfoId)
        {
            var res = await _familyInfoService.GetFamilyInfoDetailAsync(familyInfoId);

            return new ApiOkActionResult(res);
        }
        [HttpPost()]
        public async Task<IActionResult> AddFamilyInfoDetailAsync([FromForm] FamilyInfoModel model)
        {
            var res = await _familyInfoService.AddFamilyInfoDetailAsync(model);

            return new ApiOkActionResult(res);
        }
        [HttpPut("{familyInfoId}")]
        public async Task<IActionResult> UpdateFamilyInfoDetailAsync(long familyInfoId, [FromForm] FamilyInfoModel employees)
        {

            var res = await _familyInfoService.UpdateFamilyInfoDetailAsync(familyInfoId, employees);

            return new ApiOkActionResult(res);
        }
    }
}
