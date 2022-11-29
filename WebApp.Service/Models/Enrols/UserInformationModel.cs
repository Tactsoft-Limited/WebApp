﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using WebApp.Core;
using WebApp.Service.Models.Enrols;
using WebApp.Sql.Entities.Configurations;
using WebApp.Sql.Entities.Enrols;

namespace WebApp.Service.Models
{
    public class UserInformationModel : MasterModel
    {
        public UserInformationModel()
        {
        }

        public long? UserId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime? BirthDate { get; set; }
        public CountryModel NationalityId { get; set; }
        public Religion ReligionId { get; set; }
        public string ReligionText { get; set; }
        //public Gender GenderId { get; set; }
        public MaritalStatus MaritalStatusId { get; set; }

        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string NationalIdentificationNumber { get; set; }
        public string DrivingLicenseNumber { get; set; }
        public string PassportNumber { get; set; }

        public string FatherFirstname { get; set; }
        public string FatherLasttname { get; set; }
        public string FatherContactNumber { get; set; }
        public string MotherFirstname { get; set; }
        public string MotherLastname { get; set; }
        public string FatherLastname { get; set; }
        public string MotherContactNumber { get; set; }

        public IFormFile AvatarFile { get; set; }
        public string Avatar { get; set; }

        public long? CountryId { get; set; }
        public long? StateId { get; set; }
        public long? CityId { get; set; }
        public string ZipCode { get; set; }
        public string Address1 { get; set; }

        public UserModel User { get; set; }
        public IEnumerable<UserBasicInformationModel> UserBasicInformations { get; set; }
        public IEnumerable<UserHobbyInformationModel> UserHobbyInformations { get; set; }
        public IEnumerable<UserAddressInformationModel> UserAddressInformations { get; set; }

        public IEnumerable<UserEducationalInformationModel> UserEducationalInformations { get; set; }
        public IEnumerable<UserProfessionalInformationModel> UserProfessionalInformations { get; set; }
        public IEnumerable<UserCertificationModel> UserCertifications { get; set; }
        public IEnumerable<UserSkillModel> UserSkills { get; set; }
    }
}
