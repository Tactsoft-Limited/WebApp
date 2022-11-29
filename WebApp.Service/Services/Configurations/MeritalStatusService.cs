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

        public async Task<Dropdown<MeritalStatusModel>> GetDropdownAsync(string searchText = null, int size = CommonVariables.DropdownSize)
        {
            var data = await _unitOfWork.Repository<MeritalStatus>().GetDropdownAsync(
                p=>(string.IsNullOrEmpty(searchText)|| p.MeritalStatusName.Contains(searchText)),
                o=>o.OrderBy(ob=>ob.Id),
                se=> new MeritalStatusModel { Id = se.Id, MeritalStatusName = se.MeritalStatusName},
                size
                );

            return data;
        }
    }
}
