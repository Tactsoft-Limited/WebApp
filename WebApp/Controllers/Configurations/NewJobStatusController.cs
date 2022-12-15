﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApp.Extensions;
using WebApp.Helpers.Base;
using WebApp.Service.Services.Configurations;
using WebApp.Sql.Entities.Enrols;

namespace WebApp.Controllers.Configurations
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewJobStatusController : GenericBaseController<NewJobStatus>
    {
        private readonly INewJobStatusService _newjobstatusService;

        public NewJobStatusController(INewJobStatusService newjobstatusService) : base(newjobstatusService)
        {
            _newjobstatusService = newjobstatusService;
        }
        [HttpGet("company_dropdown")]
        public async Task<IActionResult> GetCompanyDropdownAsync(long? companyId = null, string searchText = null)
        {
            var res = await _newjobstatusService.GetCompanyDropdownAsync(companyId, searchText);

            return new ApiOkActionResult(res);
        }
        [HttpGet("project_dropdown")]
        public async Task<IActionResult> GetProjectDropdownAsync(long? projectId = null, string searchText = null)
        {
            var res = await _newjobstatusService.GetProjectDropdownAsync(projectId, searchText);

            return new ApiOkActionResult(res);
        }
        [HttpGet("branch_dropdown")]
        public async Task<IActionResult> GetBranchDropdownAsync(long? branchId = null, string searchText = null)
        {
            var res = await _newjobstatusService.GetBranchDropdownAsync(branchId, searchText);

            return new ApiOkActionResult(res);
        }
    }
}