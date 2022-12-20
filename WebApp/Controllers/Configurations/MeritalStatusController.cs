using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApp.Core;
using WebApp.Extensions;
using WebApp.Helpers.Base;
using WebApp.Service.Models.Configurations;
using WebApp.Service.Services.Configurations;
using WebApp.Services;
using WebApp.Sql.Entities.Configurations;

namespace WebApp.Controllers.Configurations
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeritalStatusController : GenericBaseController<MeritalStatus>
    {
        private readonly IMeritalStatusService  _meritalStatusService;

        public MeritalStatusController(IMeritalStatusService meritalStatusService) : base(meritalStatusService)
        {
            _meritalStatusService = meritalStatusService;
        }

        [HttpGet("dropdown")]
        public async Task<IActionResult> GetDropdownAsync(string searchText = null)
        {
            var res = await _meritalStatusService.GetDropdownAsync(searchText);

            return new ApiOkActionResult(res);
        }
        [HttpGet("search")]
        public async Task<IActionResult> GetSearchAsync(int pageIndex = CommonVariables.pageIndex, int pageSize = CommonVariables.pageSize, string searchText = null)
        {
            var res = await _meritalStatusService.GetSearchAsync(pageIndex, pageSize, searchText);

            return new ApiOkActionResult(res);
        }
        [HttpGet("{meritalStatusId}")]
        public async Task<IActionResult> GetMeritalStatusDetailsAsync(long meritalStatusId)
        {
            var res = await _meritalStatusService.GetMeritalStatusDetailsAsync(meritalStatusId);

            return new ApiOkActionResult(res);
        }

        [HttpPost()]
        public async Task<IActionResult> AddMeritalStatusDetailsAsync([FromForm] MeritalStatusModel model)
        {
            var res = await _meritalStatusService.AddMeritalStatusDetailsAsync(model);

            return new ApiOkActionResult(res);
        }

        [HttpPut("{meritalStatusId}")]
        public async Task<IActionResult> UpdateContactDetailsAsync(long meritalStatusId, [FromForm] MeritalStatusModel model)
        {
            var res = await _meritalStatusService.UpdateMeritalStatusDetailsAsync(meritalStatusId, model);

            return new ApiOkActionResult(res);
        }
    }
}
