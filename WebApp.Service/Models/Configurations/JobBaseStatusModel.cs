using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Service.Models.Configurations
{
    public class JobBaseStatusModel : MasterModel
    {
        public long? CompanyId { get; set; }
        public long? BranchId { get; set; }
        public long? ProjectId { get; set; }
        public string JobBaseStatusCode { get; set; }
        public string JobBaseStatusTitle { get; set; }
 
    }
}
