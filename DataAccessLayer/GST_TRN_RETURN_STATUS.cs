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
    
    public partial class GST_TRN_RETURN_STATUS
    {
        public int StatusID { get; set; }
        public Nullable<int> Period { get; set; }
        public Nullable<int> FinYear_ID { get; set; }
        public Nullable<int> Signatory_Id { get; set; }
        public string User_id { get; set; }
        public Nullable<int> ParentStatusId { get; set; }
        public Nullable<int> NoofInvoices { get; set; }
        public Nullable<byte> ReturnStatus { get; set; }
        public Nullable<byte> Action { get; set; }
        public Nullable<byte> Status { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual GST_MST_USER_SIGNATORY GST_MST_USER_SIGNATORY { get; set; }
    }
}
