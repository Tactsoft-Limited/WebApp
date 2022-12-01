using System.Threading.Tasks;
using WebApp.Core;
using WebApp.Core.Collections;
using WebApp.Service.Models.Configurations;
using WebApp.Services;
using WebApp.Sql.Entities.Configurations;

namespace WebApp.Service.Services.Configurations
{
    public interface IProficiencyService:IBaseService<Proficiency>
    {
        Task<Dropdown<ProficiencyModel>> GetDropdownAsync(string searchText = null, int size = CommonVariables.DropdownSize);
    }
}
