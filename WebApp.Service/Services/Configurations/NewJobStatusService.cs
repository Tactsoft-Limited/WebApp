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
using WebApp.Sql.Entities.Enrols;

namespace WebApp.Service.Services.Configurations
{
    public class NewJobStatusService : BaseService<NewJobStatus>,INewJobStatusService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public NewJobStatusService(IUnitOfWork unitOfWork,
        IMapper mapper) : base(unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<Dropdown<NewJobStatusModel>> GetCompanyDropdownAsync(long? companyId = null, 
    string searchText = null,
    int size = CommonVariables.DropdownSize)
        {
            var data = await _unitOfWork.Repository<NewJobStatus>().GetDropdownAsync(
                s => ((string.IsNullOrEmpty(searchText) || s.StatusTitle.Contains(searchText))
                    && companyId == null || s.CompanyId == companyId),
                o => o.OrderBy(ob => ob.Id),
                se => new NewJobStatusModel { Id = se.Id, StatusTitle = se.StatusTitle, CompanyId = se.CompanyId},
                
            size);

            return data;
        }
        public async Task<Dropdown<NewJobStatusModel>> GetBranchDropdownAsync(long? branchId = null,
    string searchText = null,
    int size = CommonVariables.DropdownSize)
        {
            var data = await _unitOfWork.Repository<NewJobStatus>().GetDropdownAsync(
                s => ((string.IsNullOrEmpty(searchText) || s.StatusTitle.Contains(searchText))
                    && branchId == null || s.BranchId == branchId),
                o => o.OrderBy(ob => ob.Id),
                se => new NewJobStatusModel { Id = se.Id, StatusTitle = se.StatusTitle, BranchId = se.BranchId },

            size);

            return data;
        }
        public async Task<Dropdown<NewJobStatusModel>> GetProjectDropdownAsync(long? projectId = null,
    string searchText = null,
    int size = CommonVariables.DropdownSize)
        {
            var data = await _unitOfWork.Repository<NewJobStatus>().GetDropdownAsync(
                s => ((string.IsNullOrEmpty(searchText) || s.Project.ProjectName.Contains(searchText))
                    && projectId == null || s.ProjectId == projectId),
                o => o.OrderBy(ob => ob.Id),
                se => new NewJobStatusModel { Id = se.Id, StatusTitle = se.StatusTitle, ProjectId = se.ProjectId },

            size);

            return data;
        }
    }
}
