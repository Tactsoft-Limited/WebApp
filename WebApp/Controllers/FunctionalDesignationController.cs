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
    public class FunctionalDesignationController : GenericBaseController<FunctionalDesignation>
    {
        private readonly IFunctionalDesignationService _functionalDesignation;
        public FunctionalDesignationController(IFunctionalDesignationService functionalDesignation) : base(functionalDesignation)
        {
            this._functionalDesignation = functionalDesignation;
        }

        [HttpGet("{functionalDesignationId}")]
        public async Task<IActionResult> GetFunctionalDesignationDetailAsync(long functionalDesignationId)
        {
            var res = await _functionalDesignation.GetFunctionalDesignationDetailAsync(functionalDesignationId);

            return new ApiOkActionResult(res);
        }
        [HttpPost()]
        public async Task<IActionResult> AddFunctionalDesignationDetailAsync([FromForm] FunctionalDesignationModel model)
        {
            var res = await _functionalDesignation.AddFunctionalDesignationDetailAsync(model);

            return new ApiOkActionResult(res);
        }
        [HttpPut("{functionalDesignationId}")]
        public async Task<IActionResult> UpdateFunctionalDesignationDetailAsync(long functionalDesignationId, [FromForm] FunctionalDesignationModel functionalDesignation)
        {

            var res = await _functionalDesignation.UpdateFunctionalDesignationDetailAsync(functionalDesignationId, functionalDesignation);

            return new ApiOkActionResult(res);
        }
    }
}
