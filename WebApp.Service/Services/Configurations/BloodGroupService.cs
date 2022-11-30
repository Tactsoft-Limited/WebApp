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
    internal class BloodGroupService : BaseService<BloodGroup>, IBloodGroupService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BloodGroupService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Dropdown<BloodGroupModel>> GetDropdownAsync(string searchText = null, int size = CommonVariables.DropdownSize)
        {
            var data = await _unitOfWork.Repository<BloodGroup>().GetDropdownAsync(
                p => (string.IsNullOrEmpty(searchText) || p.BloodGroupName.Contains(searchText)),
                o=> o.OrderBy(ob=>ob.Id),
                se=> new BloodGroupModel { Id=se.Id, BloodGroupName= se.BloodGroupName},
                size
                );
            return data;
        }
    }
}
