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
    
    public partial class PROC_FILE_GSTR_6_3_Result
    {
        public string GSTNNO { get; set; }
        public string INVOICENO { get; set; }
        public Nullable<System.DateTime> INVOICEDATE { get; set; }
        public Nullable<decimal> TOTALAMOUNT { get; set; }
        public Nullable<decimal> RATE { get; set; }
        public Nullable<decimal> TAXABLEAMOUNT { get; set; }
        public Nullable<decimal> IGSTAMT { get; set; }
        public Nullable<decimal> CGSTAMT { get; set; }
        public Nullable<decimal> SGSTAMT { get; set; }
        public Nullable<decimal> UGSTAMT { get; set; }
        public Nullable<decimal> CESSAMT { get; set; }
        public string STATENAME { get; set; }
    }
}
