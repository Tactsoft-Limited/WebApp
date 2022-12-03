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
    public class EmployeeManagementCategoryController : GenericBaseController<EmployeeManagementCategory>
    {
        private readonly IEmployeeManagementCategoryService _employeeManagementCategoryService;
        public EmployeeManagementCategoryController(IEmployeeManagementCategoryService employeeManagementCategoryService) : base(employeeManagementCategoryService)
        {
            _employeeManagementCategoryService = employeeManagementCategoryService;
        }

        [HttpGet("{employeeMCId}")]
        public async Task<IActionResult> GetEmployeeManagementCategoryServiceDetailAsync(long employeeMCId)
        {
            var res = await _employeeManagementCategoryService.GetEmployeeManagementCategoryServiceDetailAsync(employeeMCId);

            return new ApiOkActionResult(res);
        }
        [HttpPost()]
        public async Task<IActionResult> AddEmployeeManagementCategoryServiceDetailAsync([FromForm] EmployeeManagementCategoryModel model)
        {
            var res = await _employeeManagementCategoryService.AddEmployeeManagementCategoryServiceDetailAsync(model);

            return new ApiOkActionResult(res);
        }
        [HttpPut("{employeeMCId}")]
        public async Task<IActionResult> UpdateEmployeeManagementCategoryServiceDetailAsync(long employeeMCId, [FromForm] EmployeeManagementCategoryModel model)
        {

            var res = await _employeeManagementCategoryService.UpdateEmployeeManagementCategoryServiceDetailAsync(employeeMCId, model);

            return new ApiOkActionResult(res);
        }
    }
}
