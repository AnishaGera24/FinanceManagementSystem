using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MyFinanceMgmtProject.Models
{
    [MetadataType(typeof(MetaDataForCardTypeMaster))]
    public partial class CardTypeMaster
    {
    }
    [DataContract]
    public class MetaDataForCardTypeMaster
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string data { get; set; }
        [DataMember]
        public Nullable<int> limit { get; set; }
    }
}