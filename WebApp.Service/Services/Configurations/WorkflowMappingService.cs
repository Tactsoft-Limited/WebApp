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
     public class WorkflowMappingService :BaseService<WorkflowMaping>, IWorkflowMappingService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public WorkflowMappingService(IUnitOfWork unitOfWork,
        IMapper mapper) : base(unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<Dropdown<WorkflowMappingModel>> GetCompanyDropdownAsync(long? companyId = null,
        string searchText = null,
        int size = CommonVariables.DropdownSize)
        {
            var data = await _unitOfWork.Repository<WorkflowMaping>().GetDropdownAsync(
                s => ((string.IsNullOrEmpty(searchText) || s.Company.CompanyName.Contains(searchText))
                    && companyId == null || s.CompanyId == companyId),
                o => o.OrderBy(ob => ob.Id),
                se => new WorkflowMappingModel { Id = se.Id, CompanyId = se.CompanyId },

            size);

            return data;
        }
        public async Task<Dropdown<WorkflowMappingModel>> GetBranchDropdownAsync(long? branchId = null,
                string searchText = null,
                int size = CommonVariables.DropdownSize)
        {
            var data = await _unitOfWork.Repository<WorkflowMaping>().GetDropdownAsync(
                s => ((string.IsNullOrEmpty(searchText) || s.Branch.BranchName.Contains(searchText))
                    && branchId == null || s.BranchId == branchId),
                o => o.OrderBy(ob => ob.Id),
                se => new WorkflowMappingModel { Id = se.Id, BranchId = se.BranchId },

            size);

            return data;
        }
        public async Task<Dropdown<WorkflowMappingModel>> GetEmployeeDropdownAsync(long? projectId = null,
    string searchText = null,
    int size = CommonVariables.DropdownSize)
        {
            var data = await _unitOfWork.Repository<WorkflowMaping>().GetDropdownAsync(
                s => ((string.IsNullOrEmpty(searchText) || s.Employees.Name.Contains(searchText))
                    && projectId == null || s.EmployeeId == projectId),
                o => o.OrderBy(ob => ob.Id),
                se => new WorkflowMappingModel { Id = se.Id, EmployeeId = se.EmployeeId },

            size);

            return data;
        }
        public async Task<Dropdown<WorkflowMappingModel>> GetDepartmentDropdownAsync(long? departmentId = null,
            string searchText = null,
            int size = CommonVariables.DropdownSize)
        {
            var data = await _unitOfWork.Repository<WorkflowMaping>().GetDropdownAsync(
                s => ((string.IsNullOrEmpty(searchText) || s.Department.Name.Contains(searchText))
                    && departmentId == null || s.DepartmentId == departmentId),
                o => o.OrderBy(ob => ob.Id),
                se => new WorkflowMappingModel { Id = se.Id, DepartmentId = se.DepartmentId },

            size);

            return data;
        }
        public async Task<Dropdown<WorkflowMappingModel>> GetWorkflowDropdownAsync(long? workflowId = null,
        string searchText = null,
        int size = CommonVariables.DropdownSize)
        {
            var data = await _unitOfWork.Repository<WorkflowMaping>().GetDropdownAsync(
                s => ((string.IsNullOrEmpty(searchText) || s.Workflow.NewApprovalWorkflowName.Contains(searchText))
                    && workflowId == null || s.WorkflowId == workflowId),
                o => o.OrderBy(ob => ob.Id),
                se => new WorkflowMappingModel { Id = se.Id, WorkflowId = se.WorkflowId },

            size);

            return data;
        }
    }
}
