using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MyFinanceMgmtProject.Models
{
    [MetadataType(typeof(MetadataTypeForCardDetails))]
    public partial class Carddetails
    {
    }
    [DataContract]
    public class MetadataTypeForCardDetails
    {
        [DataMember]
        public int CardNmber { get; set; }
        [DataMember]
        public int cvv { get; set; }
        [DataMember]
        public int CustId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public System.DateTime ExpiraDate { get; set; }
        [DataMember]
        public int cardtype { get; set; }
        [DataMember]
        public int balence { get; set; }
        [DataMember]
        public byte Satus { get; set; }
    }
}