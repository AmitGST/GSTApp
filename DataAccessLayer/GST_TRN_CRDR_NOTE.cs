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
    
    public partial class GST_TRN_CRDR_NOTE
    {
        public GST_TRN_CRDR_NOTE()
        {
            this.GST_TRN_CRDR_AUDIT_TRAIL = new HashSet<GST_TRN_CRDR_AUDIT_TRAIL>();
            this.GST_TRN_CRDR_NOTE_DATA = new HashSet<GST_TRN_CRDR_NOTE_DATA>();
        }
    
        public long CreditDebitID { get; set; }
        public string From_UserID { get; set; }
        public string To_UserID { get; set; }
        public Nullable<long> InvoiceID { get; set; }
        public Nullable<long> CDN_ParentID { get; set; }
        public Nullable<System.DateTime> CDN_Date { get; set; }
        public Nullable<byte> NoteType { get; set; }
        public Nullable<byte> NoteTypeStatus { get; set; }
        public Nullable<decimal> TotalNoteValue { get; set; }
        public string NoteNumber { get; set; }
        public string Description { get; set; }
        public Nullable<byte> P_Gst { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual AspNetUser AspNetUser1 { get; set; }
        public virtual ICollection<GST_TRN_CRDR_AUDIT_TRAIL> GST_TRN_CRDR_AUDIT_TRAIL { get; set; }
        public virtual ICollection<GST_TRN_CRDR_NOTE_DATA> GST_TRN_CRDR_NOTE_DATA { get; set; }
        public virtual GST_TRN_INVOICE GST_TRN_INVOICE { get; set; }
    }
}
