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
    public class ReligionService : BaseService<Religion>, IReligionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ReligionService(IUnitOfWork unitOfWork,IMapper mapper) : base(unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Dropdown<ReligionModel>> GetDropdownAsync(string searchText = null, int size = CommonVariables.DropdownSize)
        {
            var data = await _unitOfWork.Repository<Religion>().GetDropdownAsync(
                p => (string.IsNullOrEmpty(searchText) || p.ReligionName.Contains(searchText)),
                o => o.OrderBy(ob => ob.Id),
                se => new ReligionModel { Id = se.Id, ReligionName = se.ReligionName },
                size);
            return data;
        }
    }
}
