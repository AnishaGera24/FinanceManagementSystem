using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MyFinanceMgmtProject.Models
{
    [MetadataType(typeof(MetaDataForCustomerMaster))]
    public partial class CustomerMaster
    {
    }
    [Serializable]
    public class MetaDataForCustomerMaster
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string PhoneAlt { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Bank { get; set; }
        public string SavingsAccountNumber { get; set; }
        public string IFSCCode { get; set; }
        public string ques1 { get; set; }
        public string ans1 { get; set; }
        public string ques2 { get; set; }
        public string ans2 { get; set; }
        public string ques3 { get; set; }
        public string ans3 { get; set; }
    }
}