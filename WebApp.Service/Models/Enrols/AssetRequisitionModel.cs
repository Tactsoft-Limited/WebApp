﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Sql.Entities.Enrols;
using static WebApp.Sql.Entities.Identities.IdentityModel;

namespace WebApp.Service.Models.Enrols
{
    public class AssetRequisitionModel:MasterModel
    {
        public AssetRequisitionModel()
        {

        }
        public long? UserId { get; set; }
        public long? EmployeeId { get; set; }
        public long? AssetId { get; set; }
        public long? ApprovalById { get; set; }
        public DateTime ApprovalDate { get; set; }
        public string Remarks { get; set; }
        public User User { get; set; }
        public Employees Employees { get; set; }
        public Asset Assets { get; set; }
    }
}
