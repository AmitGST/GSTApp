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
    
    public partial class EWB_TRN_REPONSE_EWBILL
    {
        public int ReponseEW_ID { get; set; }
        public Nullable<long> InvoiceID { get; set; }
        public Nullable<int> EWB_ID { get; set; }
        public string InvoiceNo { get; set; }
        public Nullable<int> EwaybillNo { get; set; }
        public Nullable<System.DateTime> EwayBillDate { get; set; }
        public Nullable<System.DateTime> ValidUpto { get; set; }
        public Nullable<int> ErrorCode { get; set; }
        public string ErrorDescription { get; set; }
        public Nullable<byte> Status { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual EWB_TRN_EWBILL EWB_TRN_EWBILL { get; set; }
        public virtual GST_TRN_INVOICE GST_TRN_INVOICE { get; set; }
    }
}
