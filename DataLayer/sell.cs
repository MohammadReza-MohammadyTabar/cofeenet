//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class sell
    {
        public int sellid { get; set; }
        public System.DateTime date { get; set; }
        public Nullable<int> typeid { get; set; }
        public Nullable<int> number { get; set; }
        public Nullable<int> paymoney { get; set; }
        public Nullable<int> paymentmethodeid { get; set; }
        public int money { get; set; }
    
        public virtual paymentmethode paymentmethode { get; set; }
        public virtual type type { get; set; }
    }
}