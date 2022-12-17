using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
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
    public class AwardInfoService : BaseService<AwardInfo>, IAwardInfoService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public AwardInfoService(IUnitOfWork unitOfWork,
              IMapper mapper,
              IWebHostEnvironment webHostEnvironment,
              IOptions<AppSettings> appSettings) : base(unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            _mapper = mapper;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<AwardInfoModel> AddAwardInfoDetailAsync(AwardInfoModel model)
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
            var entity = _mapper.Map<AwardInfoModel, AwardInfo>(model);
            await _unitOfWork.Repository<AwardInfo>().UpdateAsync(entity);
            await _unitOfWork.CompleteAsync();

            return new AwardInfoModel();
        }

        public async Task<AwardInfoModel> GetAwardInfoDetailAsync(long awardinfoId)
        {
            var data = await _unitOfWork.Repository<AwardInfo>().FirstOrDefaultAsync(f => f.Id == awardinfoId,
                o=>o.OrderBy(ob=>ob.Id),
                i=>i.User);
            return _mapper.Map<AwardInfo, AwardInfoModel>(data);
        }

        //public Task<Dropdown<AwardInfoModel>> GetDropdownAsync(string searchText = null, int size = 15)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Paging<AwardInfoModel>> GetFilterAsync(int pageIndex = 0, int pageSize = 10, string filterText1 = null)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Paging<AwardInfoModel>> GetSearchAsync(int pageIndex = 0, int pageSize = 10, string searchText = null)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<AwardInfoModel> UpdateAwardInfoDetailAsync(long awardinfoId, AwardInfoModel model)
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
            {
                model.Attachment = model.Attachment?.Split("/")?.LastOrDefault();
            }

            var entity = _mapper.Map<AwardInfoModel, AwardInfo>(model);
            await _unitOfWork.Repository<AwardInfo>().UpdateAsync(entity);
            await _unitOfWork.CompleteAsync();

            return new AwardInfoModel();
        }

        public async Task<AwardInfoModel> UpdateAwardInfoDetailAsync(long awardinfoId, string model, List<IFormFile> images)
        {
            var image = images.FirstOrDefault();
            var awardinfo = JsonConvert.DeserializeObject<AwardInfoModel>(model);
            string uniqueFileName = string.Empty;
            if (image != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, CommonVariables.AvatarLocation);
                uniqueFileName = Guid.NewGuid().ToString() + "_" + image.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    image.CopyTo(fileStream);
                }
            }
            awardinfo.Attachment = uniqueFileName;
            var entity = _mapper.Map<AwardInfoModel, AwardInfo>(awardinfo);
            await _unitOfWork.Repository<AwardInfo>().UpdateAsync(entity);
            await _unitOfWork.CompleteAsync();

            return new AwardInfoModel();
        }
    }
}
