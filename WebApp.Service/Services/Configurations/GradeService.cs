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
    public class GradeService : BaseService<Grade> ,IGradeService

    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GradeService(IUnitOfWork unitOfWork,
                IMapper mapper) : base(unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<Dropdown<GradeModel>> GetCompanyDropdownAsync(long? companyId = null,
        string searchText = null,
        int size = CommonVariables.DropdownSize)
        {
            var data = await _unitOfWork.Repository<Grade>().GetDropdownAsync(
                s => ((string.IsNullOrEmpty(searchText) || s.Company.CompanyName.Contains(searchText))
                    && companyId == null || s.CompanyId == companyId),
                o => o.OrderBy(ob => ob.Id),
                se => new GradeModel { Id = se.Id, GradeName = se.GradeName, CompanyId = se.CompanyId },
                size);

            return data;
        }
    }
}
