using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WebApp.Sql.Entities.Identities.IdentityModel;
using WebApp.Core;
using WebApp.Sql.Entities.Configurations;

namespace WebApp.Service.Models.Enrols
{
    public class FamilyInfoModel: MasterModel
    {
        public FamilyInfoModel()
        {

        }
        public long? UserId { get; set; }
        public int EmoloyeeId { get; set; }
        public string FemilyMemberName { get; set; }
        public Relationship RelationshipId { get; set; }
        public long? GenderId { get; set; }
        public DateTime DOB { get; set; }
        public long? NationalityId { get; set; }
        public string ContactNumber { get; set; }
        public string Profession { get; set; }
        public string Address { get; set; }
        public string EmergencyContact { get; set; }

        public User User { get; set; }
        public Gender Gender { get; set; }

    }
}
