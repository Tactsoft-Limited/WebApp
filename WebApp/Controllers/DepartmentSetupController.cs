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
    public class DepartmentSetupController : GenericBaseController<DepartmentSetup>
    {
        private readonly IDepartmentSetupService _departmentSetupSservice;

        public DepartmentSetupController(IDepartmentSetupService departmentSetupSservice) : base(departmentSetupSservice)
        {
            _departmentSetupSservice = departmentSetupSservice;
        }

        [HttpGet("{departmentSetupId}")]
        public async Task<IActionResult> GetContactDetailsAsync(long departmentSetupId)
        {
            var res = await _departmentSetupSservice.GetDepartmentSetupDetailAsync(departmentSetupId);

            return new ApiOkActionResult(res);
        }
        [HttpPost()]
        public async Task<IActionResult> AddDepartmentSetupDetailAsync ([FromForm] DepartmentSetupModel model)
        {
            var res = await _departmentSetupSservice.AddDepartmentSetupDetailAsync(model);

            return new ApiOkActionResult(res);
        }
        [HttpPut("{contactId}")]
        public async Task<IActionResult> UpdateDepartmentSetupDetailAsync(long contactId, [FromForm] DepartmentSetupModel model)
        {
            var res = await _departmentSetupSservice.UpdateDepartmentSetupDetailAsync(contactId, model);
            return new ApiOkActionResult(res);
        }
    }
}
