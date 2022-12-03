﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Core;
using WebApp.Sql.Entities.Configurations;
using static WebApp.Sql.Entities.Identities.IdentityModel;

namespace WebApp.Sql.Entities.Enrols
{
    public class Employees : BaseEntity
    {
        public long? UserId { get; set; }   
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public long? GenderId { get; set; }
        public string Address { get; set; }
        public int BasicSalary { get; set; }

        public bool Status { get; set; }
        public DateTime JoiningDate { get; set; }
        public DateTime ResignDate { get; set; } 
        public long? DepartmentId { get; set; }  
        public long? DesignationId { get; set; }

        public string AcountName { get; set; }
        public string AcountNumber { get; set; }
        public string SwiftCode { get; set; }
        public string Brance { get; set; }
        public string Avatar { get; set; }
        public Department Department { get; set; }
        public Designation Designation { get; set; }
        public User  User { get; set; }

        public Gender Gender { get; set; }
        public IList<FunctionalDesignation> FunctionalDesignations { get; set; }
        public IList<Supervisor> Supervisors { get; set; }
        public IList<Contact> Contacts { get; set; }   
        public IList<DepartmentSetup> DepartmentSetups { get; set;}
        public IList<Warning> Warnings { get; set; }
        public IList<Language> Languages { get; set; }
        public IList<SupervisorSetup> SupervisorSetups { get; set; }
        public IList<WorkflowMaping> WorkflowMapings { get; set; }
    }
}
