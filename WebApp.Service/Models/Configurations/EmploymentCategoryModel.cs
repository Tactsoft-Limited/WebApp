using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Service.Models.Configurations
{
    public class EmploymentCategoryModel : MasterModel
    {
        public long? CompanyId { get; set; }
        public string CategoryName { get; set; }
        public bool Status { get; set; }
    }
}
