using System.Threading.Tasks;
using WebApp.Core;
using WebApp.Core.Collections;
using WebApp.Service.Models.Configurations;
using WebApp.Services;
using WebApp.Sql.Entities.Configurations;
namespace WebApp.Service.Services.Configurations
{
    public interface IBloodGroupService : IBaseService<BloodGroup>
    {
        Task<Dropdown<BloodGroupModel>> GetDropdownAsync(string searchText = null, int size = CommonVariables.DropdownSize);
    }
}
