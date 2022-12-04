using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Sql.Entities.Enrols
{
    public class NewJobStatus : BaseEntity
    {
        public long? CompanyId { get; set; }
        public long? BranchId { get; set; }
        public long? ProjectId { get; set; }
        public string StatusCode { get; set; }
        public string StatusTitle { get; set; }
        public CompanyInfo Company { get; set; }
        public BranchInfo Branch { get; set; }
        public Project Project { get; set; }
    }
}
