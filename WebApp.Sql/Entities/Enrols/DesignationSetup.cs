using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Sql.Entities.Configurations;
using WebApp.Sql.Migrations;

namespace WebApp.Sql.Entities.Enrols
{
    public class DesignationSetup:BaseEntity
    {
        public long? EmployeeId { get; set; }
        public long? DesignationId { get; set; }
        public DateTime EffectedDate { get; set; }
        public string RemarK { get; set; }

        public Employees Employees { get; set; }
        public Designation Designation { get; set; }
    }
}
