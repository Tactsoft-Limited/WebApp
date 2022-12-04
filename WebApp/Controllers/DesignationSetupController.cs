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
    public class DesignationSetupController : GenericBaseController<DesignationSetup>
    {
        private readonly IDesignationSetupService _designationSetupService;

        public DesignationSetupController(IDesignationSetupService designationSetupService) : base(designationSetupService)
        {
            this._designationSetupService = designationSetupService;
        }

        [HttpGet("{designationSetupId}")]
        public async Task<IActionResult> GetDesignationSetupDetailAsync(long designationSetupId)
        {
            var res = await _designationSetupService.GetDesignationSetupDetailAsync(designationSetupId);

            return new ApiOkActionResult(res);
        }
        [HttpPost()]
        public async Task<IActionResult> AddDepartmentSetupDetailAsync([FromForm] DesignationSetupModel model)
        {
            var res = await _designationSetupService.AddDesignationSetupDetailAsync(model);

            return new ApiOkActionResult(res);
        }
        [HttpPut("{contactId}")]
        public async Task<IActionResult> UpdateDepartmentSetupDetailAsync(long contactId, [FromForm] DesignationSetupModel model)
        {
            var res = await _designationSetupService.UpdateDesignationSetupDetailAsync(contactId, model);
            return new ApiOkActionResult(res);
        }


    }
}
