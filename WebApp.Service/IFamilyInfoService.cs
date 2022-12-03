using Microsoft.AspNetCore.Http;
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
    public interface IFamilyInfoService : IBaseService<FamilyInfo>
    {
        Task<FamilyInfoModel> GetFamilyInfoDetailAsync(long employeesId);
        Task<FamilyInfoModel> AddFamilyInfoDetailAsync(FamilyInfoModel model);
        Task<FamilyInfoModel> UpdateFamilyInfoDetailAsync(long employeesId, FamilyInfoModel model);
        Task<FamilyInfoModel> UpdateFamilyInfoDetailAsync(long employeesId, string model);
    }
}
