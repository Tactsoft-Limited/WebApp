using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Service.Models.Enrols;
using WebApp.Services;
using WebApp.Sql.Entities.Enrols;

namespace WebApp.Service
{
    public interface IDocumentService:IBaseService<Document>
    {
        Task<DocumentModel> GetDocumentDetailAsync(long documentId);
        Task<DocumentModel> AddDocumentDetailAsync(DocumentModel model);
        Task<DocumentModel> UpdateDocumentDetailAsync(long documentId, DocumentModel model);
        Task<DocumentModel> UpdateDocumentDetailAsync(long documentId, string model, List<IFormFile> file);
    }
}
