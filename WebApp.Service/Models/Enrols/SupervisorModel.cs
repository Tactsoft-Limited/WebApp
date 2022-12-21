﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Service.Models.Configurations;
using WebApp.Sql.Entities.Configurations;
using WebApp.Sql.Entities.Enrols;
using static WebApp.Sql.Entities.Identities.IdentityModel;

namespace WebApp.Service.Models.Enrols
{
    public class SupervisorModel:MasterModel
    {
        public SupervisorModel()
        {

        }
        public long? UserId { get; set; }
        public long? SuppervisorSetupId { get; set; }
        public long? EmployeeId { get; set; }
        public long? SuppervisorEmployeeId { get; set; }
        public bool IsDirectSupervisor { get; set; }
        public DateTime EffectedDate { get; set; }
        public string Remark { get; set; }
        public UserModel User { get; set; }
        public EmployeesModel Employees { get; set; }
        public SupervisorSetupModel SupervisorSetup { get; set; }
    }
}
