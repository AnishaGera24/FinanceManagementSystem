using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MyFinanceMgmtProject.Models
{
    [MetadataType(typeof(MetaDataForuserDoc))]
    public partial class userDoc
    {
    }
    [DataContract]
    public class MetaDataForuserDoc
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public int CustId { get; set; }
        [DataMember]
        public int docId { get; set; }
        [DataMember]
        public byte[] DocData { get; set; }
    }
}