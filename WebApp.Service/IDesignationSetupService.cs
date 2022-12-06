using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Service.Models.Enrols;
using WebApp.Services;
using WebApp.Sql.Entities.Enrols;

namespace WebApp.Service
{
    public interface IDesignationSetupService:IBaseService<DesignationSetup>
    {
        Task<DesignationSetupModel> GetDesignationSetupDetailAsync(long designationSetupId);
        Task<DesignationSetupModel> AddDesignationSetupDetailAsync(DesignationSetupModel model);
        Task<DesignationSetupModel> UpdateDesignationSetupDetailAsync(long designationSetupId, DesignationSetupModel model);
        Task<DesignationSetupModel> UpdateDesignationSetupDetailAsync(long designationSetupId, string model);
    }
}
