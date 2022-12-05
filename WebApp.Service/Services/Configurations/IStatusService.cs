using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Core.Collections;
using WebApp.Core;
using WebApp.Services;
using WebApp.Sql.Entities.Configurations;
using WebApp.Service.Models.Configurations;

namespace WebApp.Service.Services.Configurations
{
    public interface IStatusService:IBaseService<Status>
    {
        Task<Dropdown<StatusModel>> GetDropdownAsync(string searchText = null, int size = CommonVariables.DropdownSize);
    }
}
