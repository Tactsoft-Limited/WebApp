using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Sql.Entities.Enrols;

namespace WebApp.Sql.Entities.Configurations
{
    public class EducationType : BaseEntity
    {
        public long? CompanyId { get; set; }
        public string EducationTypeName { get; set; }
        public bool Status { get; set; }
        public CompanyInfo Company { get; set; }

        public IList<Education> Educations { get; set; }
    }
}
