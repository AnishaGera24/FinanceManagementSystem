using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace FinanceProjectApi.Models
{
    [MetadataType(typeof(MetaDataForPaymentPlan))]
    public partial class PayementPlan
    {

    }
    [DataContract]
    public class MetaDataForPaymentPlan
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public int Duration { get; set; }
        [DataMember]
        public string data { get; set; }
    }
}