using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApp.Helpers.Base;
using WebApp.Service;
using WebApp.Sql.Entities.Enrols;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankInfoController : GenericBaseController<BankInfo>
    {
        private readonly IBankInfoService _bankInfoService;
        public BankInfoController(IBankInfoService bankInfoService):base(bankInfoService)
        {
            this._bankInfoService = bankInfoService;
        }
        //[HttpGet("search")]
        //public async Task<IActionResult> GetSearchAsync()
        //{

        //}

    }
}
