//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZadatakEdeja.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Detail
    {
        public int detailsID { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<decimal> totalDetails { get; set; }
        public Nullable<int> orderID { get; set; }
    
        public virtual Order Order { get; set; }
    }
}
