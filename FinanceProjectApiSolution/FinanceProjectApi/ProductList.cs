//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinanceProjectApi
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductList()
        {
            this.CustomerPurchasals = new HashSet<CustomerPurchasal>();
        }
    
        public int id { get; set; }
        public Nullable<int> TypeId { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public string UnitPrice { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerPurchasal> CustomerPurchasals { get; set; }
        public virtual ProductMaster ProductMaster { get; set; }
    }
}