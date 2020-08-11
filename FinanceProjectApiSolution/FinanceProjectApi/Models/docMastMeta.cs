using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MyFinanceMgmtProject.Models
{
    [MetadataType(typeof(MetaDataFordocmaster))]
    public partial class docMaster
    {
    }
    [DataContract]
    public class MetaDataFordocmaster
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public int Name { get; set; }
        [DataMember]
        public string data { get; set; }
    }
}