using AutoMapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Service.Models.Enrols;
using WebApp.Services;
using WebApp.Sql.Entities.Enrols;
using WebApp.Sql.Migrations;

namespace WebApp.Service
{
    public class FamilyInfoService : BaseService<FamilyInfo>, IFamilyInfoService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public FamilyInfoService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<FamilyInfoModel> AddFamilyInfoDetailAsync(FamilyInfoModel model)
        {
            var entity = _mapper.Map<FamilyInfoModel, FamilyInfo>(model);

            await _unitOfWork.Repository<FamilyInfo>().UpdateAsync(entity);
            await _unitOfWork.CompleteAsync();

            return new FamilyInfoModel();
        }

        public async Task<FamilyInfoModel> GetFamilyInfoDetailAsync(long familyInfoId)
        {
            var data = await _unitOfWork.Repository<FamilyInfo>().FirstOrDefaultAsync(f=>f.Id==familyInfoId,
                o=>o.OrderBy(m=>m.Id),
                i=>i.User);
            return _mapper.Map<FamilyInfo, FamilyInfoModel>(data);
        }

        public async Task<FamilyInfoModel> UpdateFamilyInfoDetailAsync(long employeesId, FamilyInfoModel model)
        {
            var entity = _mapper.Map<FamilyInfoModel, FamilyInfo>(model);
            await _unitOfWork.Repository<FamilyInfo>().UpdateAsync(entity);
            await _unitOfWork.CompleteAsync();
            return new FamilyInfoModel();
        }

        public async Task<FamilyInfoModel> UpdateFamilyInfoDetailAsync(long employeesId, string model)
        {
            var familyInfo = JsonConvert.DeserializeObject<FamilyInfoModel>(model);
            var entity = _mapper.Map<FamilyInfoModel, FamilyInfo>(familyInfo);
            await _unitOfWork.Repository<FamilyInfo>().UpdateAsync(entity);
            await _unitOfWork.CompleteAsync();
            
            return new FamilyInfoModel();
        }
    }
}
