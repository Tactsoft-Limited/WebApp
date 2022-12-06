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
    public class SupervisorSetupService : BaseService<SupervisorSetup>,ISupervisorSetupService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SupervisorSetupService(IUnitOfWork unitOfWork,
        IMapper mapper) : base(unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<Dropdown<SupervisorSetupModel>> GetCompanyDropdownAsync(long? companyId = null,
    string searchText = null,
    int size = CommonVariables.DropdownSize)
        {
            var data = await _unitOfWork.Repository<SupervisorSetup>().GetDropdownAsync(
                s => ((string.IsNullOrEmpty(searchText) || s.Company.CompanyName.Contains(searchText))
                    && companyId == null || s.CompanyId == companyId),
                o => o.OrderBy(ob => ob.Id),
                se => new SupervisorSetupModel { Id = se.Id, CompanyId = se.CompanyId },

            size);

            return data;
        }
        public async Task<Dropdown<SupervisorSetupModel>> GetEmployeeDropdownAsync(long? branchId = null,
        string searchText = null,
        int size = CommonVariables.DropdownSize)
        {
            var data = await _unitOfWork.Repository<SupervisorSetup>().GetDropdownAsync(
                s => ((string.IsNullOrEmpty(searchText) || s.Employees.Name.Contains(searchText))
                    && branchId == null || s.EmployeeId == branchId),
                o => o.OrderBy(ob => ob.Id),
                se => new SupervisorSetupModel { Id = se.Id, EmployeeId = se.EmployeeId },

            size);

            return data;
        }
    }
}
