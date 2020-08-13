using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace FinanceProjectApi.Models
{
    [MetadataType(typeof(MetaDataForProductList))]
    public partial class ProductList
    {

    }
    [DataContract]
    public class MetaDataForProductList
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public Nullable<int> TypeId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Stock { get; set; }
        [DataMember]
        public string UnitPrice { get; set; }
        [DataMember]
        public string images { get; set; }
    }
}