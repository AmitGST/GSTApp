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
    
    public partial class GST_TRN_ITC
    {
        public GST_TRN_ITC()
        {
            this.GST_TRN_ITC_DATA = new HashSet<GST_TRN_ITC_DATA>();
        }
    
        public long ITC_ID { get; set; }
        public string UserID { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<long> InvoiceID { get; set; }
        public Nullable<byte> ITCStatus { get; set; }
        public Nullable<long> ITCParentID { get; set; }
        public Nullable<byte> ITCVoucherType { get; set; }
        public Nullable<System.DateTime> ITCDate { get; set; }
        public Nullable<byte> ITCMovement { get; set; }
        public Nullable<byte> TaxType { get; set; }
        public Nullable<decimal> IGST { get; set; }
        public Nullable<decimal> CGST { get; set; }
        public Nullable<decimal> SGST { get; set; }
        public Nullable<decimal> Cess { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual GST_TRN_INVOICE GST_TRN_INVOICE { get; set; }
        public virtual ICollection<GST_TRN_ITC_DATA> GST_TRN_ITC_DATA { get; set; }
    }
}
