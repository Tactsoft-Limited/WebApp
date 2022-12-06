﻿using Microsoft.AspNetCore.Http;
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
    public class EmploymentCategoryController : GenericBaseController<EmploymentCategorie>
    {
        private readonly IEmploymentCategoryService _employmentcategoriService;

        public EmploymentCategoryController(IEmploymentCategoryService employmentcategoriService) : base(employmentcategoriService)
        {
            _employmentcategoriService = employmentcategoriService;
        }
        [HttpGet("company_dropdown")]
        public async Task<IActionResult> GetCompanyDropdownAsync(long? companyId = null, string searchText = null)
        {
            var res = await _employmentcategoriService.GetCompanyDropdownAsync(companyId, searchText);

            return new ApiOkActionResult(res);
        }
    }
}
