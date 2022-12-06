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
    public class ClaimTypeService : BaseService<ClaimType> , IClaimTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ClaimTypeService(IUnitOfWork unitOfWork,
                IMapper mapper) : base(unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<Dropdown<ClaimTypeModel>> GetCompanyDropdownAsync(long? companyId = null,
    string searchText = null,
    int size = CommonVariables.DropdownSize)
        {
            var data = await _unitOfWork.Repository<ClaimType>().GetDropdownAsync(
                s => ((string.IsNullOrEmpty(searchText) || s.Company.CompanyName.Contains(searchText))
                    && companyId == null || s.CompanyId == companyId),
                o => o.OrderBy(ob => ob.Id),
                se => new ClaimTypeModel { Id = se.Id, CliamTypeName = se.CliamTypeName, CompanyId = se.CompanyId },
                size);

            return data;
        }
    }
}
