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
    public interface IEducationService:IBaseService<Education>
    {
        Task<EducationModel> GetEducationDetailsAsync(long educationId);
        Task<EducationModel> AddEducationDetailsAsync(EducationModel model);
        Task<EducationModel> UpdateEducationDetailsAsync(long educationId, EducationModel model);
        Task<EducationModel> UpdateEducationDetailsAsync(long educationId, string model);

    }
}
