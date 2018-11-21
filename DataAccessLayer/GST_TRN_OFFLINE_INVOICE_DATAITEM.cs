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
    
    public partial class GST_TRN_OFFLINE_INVOICE_DATAITEM
    {
        public int OfflineDataID { get; set; }
        public Nullable<int> ValueID { get; set; }
        public Nullable<decimal> TotalQuantity { get; set; }
        public Nullable<int> RateId { get; set; }
        public Nullable<decimal> TaxableAmount { get; set; }
        public Nullable<decimal> TotalTaxableValue { get; set; }
        public Nullable<decimal> IGSTRate { get; set; }
        public Nullable<decimal> IGSTAmt { get; set; }
        public Nullable<decimal> CGSTRate { get; set; }
        public Nullable<decimal> CGSTAmt { get; set; }
        public Nullable<decimal> SGSTRate { get; set; }
        public Nullable<decimal> SGSTAmt { get; set; }
        public Nullable<decimal> UTGSTRate { get; set; }
        public Nullable<decimal> UTGSTAmt { get; set; }
        public Nullable<decimal> CessRate { get; set; }
        public Nullable<decimal> CessAmt { get; set; }
        public Nullable<decimal> TotalValue { get; set; }
        public Nullable<decimal> ITC_IGST { get; set; }
        public Nullable<decimal> ITC_SGST { get; set; }
        public Nullable<decimal> ITC_CGST { get; set; }
        public Nullable<decimal> ITC_UTGST { get; set; }
        public Nullable<decimal> ITC_Cess { get; set; }
        public Nullable<bool> ITC_Eligibility { get; set; }
        public Nullable<decimal> GrossAdvance { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    
        public virtual GST_TRN_OFFLINE_INVOICE GST_TRN_OFFLINE_INVOICE { get; set; }
        public virtual GST_TRN_OFFLINE_INVOICE_RATE GST_TRN_OFFLINE_INVOICE_RATE { get; set; }
    }
}
