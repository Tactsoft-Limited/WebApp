﻿using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Database;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Core;
using WebApp.Core.Collections;
using WebApp.Service.Models.Enrols;
using WebApp.Services;
using WebApp.Sql.Entities.Enrols;

namespace WebApp.Service
{
    public class DocumentService : BaseService<Document>, IDocumentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public DocumentService(IUnitOfWork unitOfWork, IMapper mapper, IWebHostEnvironment webHostEnvironment, IOptions<AppSettings> appSettings) : base(unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            _mapper = mapper;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<DocumentModel> AddDocumentDetailAsync(DocumentModel model)
        {
            string uniqueFileName = string.Empty;
            if (model.AttachmentFile !=null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, CommonVariables.AvatarLocation);
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.AttachmentFile.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.AttachmentFile.CopyTo(fileStream);
                }
                model.Attachment = uniqueFileName;
            }
            var entity = _mapper.Map<DocumentModel, Document>(model);
            await _unitOfWork.Repository<Document>().UpdateAsync(entity);
            await _unitOfWork.CompleteAsync();

            return new DocumentModel();
        }

        public async Task<DocumentModel> GetDocumentDetailAsync(long documentId)
        {
            var data = await _unitOfWork.Repository<Document>().FirstOrDefaultAsync(f => f.Id == documentId,
                o => o.OrderBy(ob => ob.Id),
                i => i.User);

            var response = _mapper.Map<Document, DocumentModel>(data);
            return response;
        }

        public async Task<DocumentModel> UpdateDocumentDetailAsync(long documentId, DocumentModel model)
        {
            string uniqueFileName = string.Empty;
            if (model.AttachmentFile != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, CommonVariables.AvatarLocation);
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.AttachmentFile.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.AttachmentFile.CopyTo(fileStream);
                }
                model.Attachment = uniqueFileName;
            }
            else
            {
                model.Attachment = model.Attachment?.Split("/")?.LastOrDefault();
            }

            var entity = _mapper.Map<DocumentModel, Document>(model);
            await _unitOfWork.Repository<Document>().UpdateAsync(entity);
            await _unitOfWork.CompleteAsync();

            return new DocumentModel();
        }

        public async Task<DocumentModel> UpdateDocumentDetailAsync(long documentId, string model, List<IFormFile> file)
        {
            var filles = file.FirstOrDefault();
            var document = JsonConvert.DeserializeObject<DocumentModel>(model);
            string uniqueFileName = string.Empty;
            if (filles!=null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, CommonVariables.AvatarLocation);
                uniqueFileName = Guid.NewGuid().ToString() + "_" + filles.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream=new FileStream(filePath, FileMode.Create))
                {
                    filles.CopyTo(fileStream);
                }
            }
            document.Attachment = uniqueFileName;
            var entity = _mapper.Map<DocumentModel, Document>(document);

            await _unitOfWork.Repository<Document>().UpdateAsync(entity);
            await _unitOfWork.CompleteAsync();

            return new DocumentModel();
        }
    }
}