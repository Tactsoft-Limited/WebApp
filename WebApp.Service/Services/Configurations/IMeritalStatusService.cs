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
    }
}
