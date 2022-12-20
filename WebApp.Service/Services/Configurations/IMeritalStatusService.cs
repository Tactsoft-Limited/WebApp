using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Core.Collections;
using WebApp.Core;
using WebApp.Service.Models.Configurations;
using WebApp.Services;
using WebApp.Sql.Entities.Configurations;

namespace WebApp.Service.Services.Configurations
{
    public interface IMeritalStatusService:IBaseService<MeritalStatus>
    {
        Task<Dropdown<MeritalStatusModel>> GetDropdownAsync(string searchText = null, int size = CommonVariables.DropdownSize);
        Task<Paging<MeritalStatusModel>> GetSearchAsync(int pageIndex = CommonVariables.pageIndex, int pageSize = CommonVariables.pageSize, string searchText = null);
        Task<Paging<MeritalStatusModel>> GetFilterAsync(int pageIndex = CommonVariables.pageIndex, int pageSize = CommonVariables.pageSize, string filterText1 = null);
        Task<MeritalStatusModel> AddMeritalStatusDetailsAsync(MeritalStatusModel model);
        Task<MeritalStatusModel> UpdateMeritalStatusDetailsAsync(long meritalStatusId, MeritalStatusModel model);
        Task<MeritalStatusModel> UpdateMeritalStatusDetailsAsync(long meritalStatusId, string model);
        Task<MeritalStatusModel> GetMeritalStatusDetailsAsync(long meritalStatusId);
    }
}
