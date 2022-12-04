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
    public class StatusService : BaseService<Status>, IStatusService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public StatusService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<Dropdown<StatusModel>> GetDropdownAsync(string searchText = null, int size = CommonVariables.DropdownSize)
        {
            var data = await _unitOfWork.Repository<Status>().GetDropdownAsync(
                p=>(string.IsNullOrEmpty(searchText)||p.StatusName.Contains(searchText)),
                o=>o.OrderBy(ob=>ob.Id),
                se=> new StatusModel { Id = se.Id, StatusName=se.StatusName},
                size);
            return data;
        }
    }
}
