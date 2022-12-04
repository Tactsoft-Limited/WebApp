﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WebApp.Sql.Entities.Identities.IdentityModel;

namespace WebApp.Sql.Entities.Enrols
{
    public class Document: BaseEntity
    {
        public long? UserId { get; set; }
        public long? EmployeeId { get; set; }
        public int DocumentTypeId { get; set; }
        public string Attachment { get; set; }
        public string Remark { get; set; }
        public User User { get; set; }
        public Employees Employees { get; set; }
    }
}
