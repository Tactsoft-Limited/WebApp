using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Core.Collections;
using WebApp.Service.Models.Configurations;
using WebApp.Services;
using WebApp.Sql.Entities.Configurations;

namespace WebApp.Service.Services.Configurations
{
    public class ProficiencyService : BaseService<Proficiency>, IProficiencyService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ProficiencyService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork)
        {this._unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Dropdown<ProficiencyModel>> GetDropdownAsync(string searchText = null, int size = 15)
        {
            var data = await _unitOfWork.Repository<Proficiency>().GetDropdownAsync(
                p=>(string.IsNullOrEmpty(searchText)||p.ProficiencyName.Contains(searchText)),
                o=>o.OrderBy(ob=>ob.Id),
                se=> new ProficiencyModel { Id = se.Id, ProficiencyName=se.ProficiencyName},
                size);
            return data;
        }
    }
}
