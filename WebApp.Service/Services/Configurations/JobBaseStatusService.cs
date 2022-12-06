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
    public class JobBaseStatusService : BaseService<JobBaseStatus>, IJobBaseStatusService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public JobBaseStatusService(IUnitOfWork unitOfWork,
        IMapper mapper) : base(unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<Dropdown<JobBaseStatusModel>> GetCompanyDropdownAsync(long? companyId = null,
string searchText = null,
int size = CommonVariables.DropdownSize)
        {
            var data = await _unitOfWork.Repository<JobBaseStatus>().GetDropdownAsync(
                s => ((string.IsNullOrEmpty(searchText) || s.Company.CompanyName.Contains(searchText))
                    && companyId == null || s.CompanyId == companyId),
                o => o.OrderBy(ob => ob.Id),
                se => new JobBaseStatusModel { Id = se.Id, JobBaseStatusTitle = se.JobBaseStatusTitle, CompanyId = se.CompanyId },

            size);

            return data;
        }
        public async Task<Dropdown<JobBaseStatusModel>> GetBranchDropdownAsync(long? branchId = null,
    string searchText = null,
    int size = CommonVariables.DropdownSize)
        {
            var data = await _unitOfWork.Repository<JobBaseStatus>().GetDropdownAsync(
                s => ((string.IsNullOrEmpty(searchText) || s.Branch.BranchName.Contains(searchText))
                    && branchId == null || s.BranchId == branchId),
                o => o.OrderBy(ob => ob.Id),
                se => new JobBaseStatusModel { Id = se.Id, JobBaseStatusTitle = se.JobBaseStatusTitle, BranchId = se.BranchId },

            size);

            return data;
        }
        public async Task<Dropdown<JobBaseStatusModel>> GetProjectDropdownAsync(long? projectId = null,
    string searchText = null,
    int size = CommonVariables.DropdownSize)
        {
            var data = await _unitOfWork.Repository<JobBaseStatus>().GetDropdownAsync(
                s => ((string.IsNullOrEmpty(searchText) || s.Project.ProjectName.Contains(searchText))
                    && projectId == null || s.ProjectId == projectId),
                o => o.OrderBy(ob => ob.Id),
                se => new JobBaseStatusModel { Id = se.Id, JobBaseStatusTitle = se.JobBaseStatusTitle, ProjectId = se.ProjectId },

            size);

            return data;
        }
    }
}
