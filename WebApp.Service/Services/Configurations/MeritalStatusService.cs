using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Core;
using WebApp.Core.Collections;
using WebApp.Service.Models.Configurations;
using WebApp.Services;
using WebApp.Sql.Entities.Configurations;

namespace WebApp.Service.Services.Configurations
{
    public class MeritalStatusService : BaseService<MeritalStatus>, IMeritalStatusService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MeritalStatusService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<MeritalStatusModel> AddMeritalStatusDetailsAsync(MeritalStatusModel model)
        {
            var entity = _mapper.Map<MeritalStatusModel, MeritalStatus>(model);
            await _unitOfWork.Repository<MeritalStatus>().UpdateAsync(entity);
            await _unitOfWork.CompleteAsync();
            return new MeritalStatusModel();
        }

        public async Task<MeritalStatusModel> GetMeritalStatusDetailsAsync(long meritalStatusId)
        {
            var data = await _unitOfWork.Repository<MeritalStatus>().FirstOrDefaultAsync(f=>f.Id== meritalStatusId);
            return  _mapper.Map<MeritalStatus, MeritalStatusModel>(data);
        }

        public async Task<Dropdown<MeritalStatusModel>> GetDropdownAsync(string searchText = null, int size = CommonVariables.DropdownSize)
        {
            var data = await _unitOfWork.Repository<MeritalStatus>().GetDropdownAsync(
                p=>(string.IsNullOrEmpty(searchText)|| p.MeritalStatusName.Contains(searchText)),
                o=>o.OrderBy(ob=>ob.Id),
                se=> new MeritalStatusModel { Id = se.Id, MeritalStatusName = se.MeritalStatusName},
                size);

            return data;
        }

        public Task<Paging<MeritalStatusModel>> GetFilterAsync(int pageIndex = CommonVariables.pageIndex, int pageSize = CommonVariables.pageSize, string filterText1 = null)
        {
            throw new NotImplementedException();
        }

        public async Task<Paging<MeritalStatusModel>> GetSearchAsync(int pageIndex = CommonVariables.pageIndex, int pageSize = CommonVariables.pageSize, string searchText = null)
        {
            var data = await _unitOfWork.Repository<MeritalStatus>().GetPageAsync(pageIndex, pageSize,
                p=>(string.IsNullOrEmpty(searchText)|p.MeritalStatusName.Contains(searchText)),
                o=>o.OrderBy(ob=>ob.Id));
            return data.ToPagingModel<MeritalStatus, MeritalStatusModel>(_mapper);
        }

        public async Task<MeritalStatusModel> UpdateMeritalStatusDetailsAsync(long meritalStatusId, MeritalStatusModel model)
        {
            var entity = _mapper.Map<MeritalStatusModel, MeritalStatus>(model);

            await _unitOfWork.Repository<MeritalStatus>().UpdateAsync(entity);
            await _unitOfWork.CompleteAsync();

            return new MeritalStatusModel();
        }

        public Task<MeritalStatusModel> UpdateMeritalStatusDetailsAsync(long meritalStatusId, string model)
        {
            throw new NotImplementedException();
        }
    }
}
