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
    
    public partial class PROC_FILERETURN_GSTR1_4A4B4C6B6C_B2B_Result
    {
        public long InvoiceID { get; set; }
        public string INVOICENO { get; set; }
        public Nullable<System.DateTime> INVOICEDATE { get; set; }
        public string RECIVERGSTN { get; set; }
        public Nullable<decimal> TOTALVALUE { get; set; }
        public Nullable<decimal> TOTALTAXABLEVALUE { get; set; }
        public Nullable<decimal> IGSTAMT { get; set; }
        public Nullable<decimal> CESSAMT { get; set; }
        public Nullable<decimal> CGSTAMT { get; set; }
        public Nullable<decimal> SGSTAMT { get; set; }
        public string DESCRIPTION { get; set; }
    }
}
