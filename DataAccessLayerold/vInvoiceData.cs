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
    
    public partial class vInvoiceData
    {
        public string Organizational_Name { get; set; }
        public string Seller_GSTIN_No { get; set; }
        public long InvoiceID { get; set; }
        public long AuditTrailID { get; set; }
        public Nullable<byte> AuditTrailStatus { get; set; }
        public Nullable<byte> ReceiverInvoiceAction { get; set; }
        public Nullable<System.DateTime> ReceiverInvoiceActionDate { get; set; }
        public Nullable<byte> SellerInvoiceAction { get; set; }
        public Nullable<System.DateTime> SellerInvoiceActionDate { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<decimal> TaxableAmount { get; set; }
        public Nullable<decimal> TotalAmountWithTax { get; set; }
    }
}