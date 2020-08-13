using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace FinanceProjectApi.Models
{
    [MetadataType(typeof(MetaDataForPaymentSchedule))]
    public partial class PayementSchedule
    {

    }
    [DataContract]
    public class MetaDataForPaymentSchedule
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public int PurchasalId { get; set; }
        [DataMember]
        public System.DateTime payementDate { get; set; }
        [DataMember]
        public int Amount { get; set; }
        [DataMember]
        public byte Paid { get; set; }
      

    }
}