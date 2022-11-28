using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Core;
using static WebApp.Sql.Entities.Identities.IdentityModel;

namespace WebApp.Sql.Entities.Enrols
{
    public class FamilyInfo:BaseEntity
    {
        public long? UserId { get; set; }
        public int EmoloyeeId { get; set; }
        public string FemilyMemberName { get; set; }
        public Relationship RelationshipId { get; set; }
        public Gender GenderId { get; set; }
        public DateTime DOB { get; set; }
        public long? NationalityId { get; set; }
        public string ContactNumber { get; set; }
        public string Profession { get; set; }
        public string Address { get; set; }
        public string EmergencyContact { get; set; }

        public User User { get; set; }

    }
}