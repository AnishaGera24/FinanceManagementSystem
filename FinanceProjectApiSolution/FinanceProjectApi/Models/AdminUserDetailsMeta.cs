using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MyFinanceMgmtProject.Models
{
    [MetadataType(typeof(MetadataTypeForAdminUserDetails))]
    public partial class AdminUserDetails
    {
    }
    [DataContract]
    public class MetadataTypeForAdminUserDetails
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string Firstname { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public string DOB { get; set; }
        [DataMember]
        public string DOJ { get; set; }
        [DataMember]
        public string EduQualification { get; set; }
    }
}
