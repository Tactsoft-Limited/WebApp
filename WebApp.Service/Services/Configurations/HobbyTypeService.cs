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
    public class HobbyTypeService : BaseService<HobbyType>, IHobbyTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public HobbyTypeService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<Dropdown<HobbyTypeModel>> GetDropdownAsync(string searchText = null, int size = CommonVariables.DropdownSize)
        {
            var data = await _unitOfWork.Repository<HobbyType>().GetDropdownAsync(
                p=>(string.IsNullOrEmpty(searchText)||p.HobbyTypeName.Contains(searchText)),
                o=>o.OrderBy(ob=>ob.Id),
                se=> new HobbyTypeModel { Id=se.Id, HobbyTypeName=se.HobbyTypeName },
                size);
            return data;
        }
    }
}
