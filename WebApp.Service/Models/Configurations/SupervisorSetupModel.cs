using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Service.Models.Configurations
{
    public class SupervisorSetupModel : MasterModel
    {
        public long? CompanyId { get; set; }
        public long? EmployeeId { get; set; }
        public DateTime EffectedDate { get; set; }
    }
}
