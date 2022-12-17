using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WebApp.Sql.Entities.Identities.IdentityModel;
using WebApp.Sql.Entities.Enrols;
using Microsoft.AspNetCore.Http;

namespace WebApp.Service.Models.Enrols
{
    public class AwardInfoModel:MasterModel
    {
        public AwardInfoModel()
        {

        }
        public long? UserId { get; set; }
        public long? EmployeeId { get; set; }
        public long? AwardTypeId { get; set; }
        public string AwardName { get; set; }
        public string Gift { get; set; }
        public float PriceAmount { get; set; }
        public string Attachment { get; set; }
        public IFormFile AttachmentFile { get; set; }
        public string Remark { get; set; }
        public User User { get; set; }
        public Employees Employees { get; set; }
    }
}
