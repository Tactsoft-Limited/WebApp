﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WebApp.Sql.Entities.Identities.IdentityModel;

namespace WebApp.Sql.Entities.Enrols
{
    public class AwardInfo:BaseEntity
    {
        public long? UserId { get; set; }
        public long? EmployeeId { get; set; }
        public long? AwardTypeId { get; set; }
        public string AwardName { get; set; }
        public string Gift { get; set; }
        public float PriceAmount { get; set; }
        public string Attachment { get; set; }
        public string Remark { get; set; }
        public User User { get; set; }
        public Employees Employees { get; set; }
    }
}
