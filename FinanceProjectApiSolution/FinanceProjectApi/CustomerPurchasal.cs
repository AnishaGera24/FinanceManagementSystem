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
    
    public partial class CustomerPurchasal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerPurchasal()
        {
            this.Accounts = new HashSet<Account>();
            this.PayementSchedules = new HashSet<PayementSchedule>();
        }
    
        public int id { get; set; }
        public int CardNumber { get; set; }
        public Nullable<int> PayementPlan { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<System.DateTime> PuchaseDate { get; set; }
        public Nullable<int> BillAmount { get; set; }
        public Nullable<int> ProcessingFee { get; set; }
        public Nullable<int> NetAmount { get; set; }
        public Nullable<int> DownPayement { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual CardDetail CardDetail { get; set; }
        public virtual PayementPlan PayementPlan1 { get; set; }
        public virtual ProductList ProductList { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PayementSchedule> PayementSchedules { get; set; }
    }
}
