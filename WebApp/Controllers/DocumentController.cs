using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApp.Extensions;
using WebApp.Helpers.Base;
using WebApp.Service;
using WebApp.Service.Models.Enrols;
using WebApp.Sql.Entities.Enrols;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : GenericBaseController<Document>
    {
        private readonly IDocumentService _documentService;
        public DocumentController(IDocumentService documentService):base(documentService)
        {
            this._documentService = documentService;
        }
        [HttpGet("{documentId}")]
        public async Task<IActionResult> GetDocumentDetailAsync(long documentId)
        {
            var res = await _documentService.GetDocumentDetailAsync(documentId);

            return new ApiOkActionResult(res);
        }
        [HttpPost()]
        public async Task<IActionResult> AddDocumentDetailAsync([FromForm] DocumentModel model)
        {
            var res = await _documentService.AddDocumentDetailAsync(model);

            return new ApiOkActionResult(res);
        }
        [HttpPut("{documentId}")]
        public async Task<IActionResult> UpdateDocumentDetailAsync(long documentId, [FromForm] DocumentModel document)
        {

            var res = await _documentService.UpdateDocumentDetailAsync(documentId, document);

            return new ApiOkActionResult(res);
        }

        [HttpPut("{documentId1}")]
        public async Task<IActionResult> UpdateDocumentDetailAsync(long documentId, [FromForm] string document, [FromForm] List<IFormFile> file)
        {

            var res = await _documentService.UpdateDocumentDetailAsync(documentId, document, file);

            return new ApiOkActionResult(res);
        }
    }
}

