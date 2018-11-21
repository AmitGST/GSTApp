//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class GST_MST_SALE_REGISTER
    {
        public long SaleRegisterID { get; set; }
        public Nullable<int> Item_ID { get; set; }
        public Nullable<long> InvoiceID { get; set; }
        public string Id { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> PerUnitRate { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<byte> SaleStatus { get; set; }
        public Nullable<System.DateTime> ActiveFrom { get; set; }
        public Nullable<System.DateTime> ActiveTo { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual GST_MST_ITEM GST_MST_ITEM { get; set; }
        public virtual GST_TRN_INVOICE GST_TRN_INVOICE { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
