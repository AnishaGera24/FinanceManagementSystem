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
    
    public partial class userDoc
    {
        public int id { get; set; }
        public int CustId { get; set; }
        public int docId { get; set; }
        public byte[] DocData { get; set; }
    
        public virtual CustomerMaster CustomerMaster { get; set; }
        public virtual docMaster docMaster { get; set; }
    }
}