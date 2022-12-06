using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Service.Models.Configurations
{
    public class GradeModel : MasterModel
    {
        public long? CompanyId { get; set; }
        public string GradeName { get; set; }
        public float GradePoint { get; set; }
    }
}
