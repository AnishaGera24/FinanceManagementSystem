using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace FinanceProjectApi.Models
{
    [MetadataType(typeof(MetaDataForAccount))]
    public partial class Account
    {

    }
    [DataContract]
    public class MetaDataForAccount
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public int PurchaseId { get; set; }
        [DataMember]
        public Nullable<System.DateTime> Date { get; set; }
        [DataMember]
        public int Paid { get; set; }
        [DataMember]
        public int Balence { get; set; }

        
    }
}