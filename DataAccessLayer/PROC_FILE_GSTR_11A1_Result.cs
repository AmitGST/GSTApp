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
    
    public partial class PROC_FILE_GSTR_11A1_Result
    {
        public long INVOICEID { get; set; }
        public string GSTNNO { get; set; }
        public Nullable<decimal> RATE { get; set; }
        public Nullable<decimal> TAXABLEAMOUNT { get; set; }
        public Nullable<decimal> IGSTAMT { get; set; }
        public string STATENAME { get; set; }
        public Nullable<decimal> CGSTAMT { get; set; }
        public Nullable<decimal> SGSTAMT { get; set; }
        public Nullable<decimal> UGSTAMT { get; set; }
        public Nullable<decimal> CESSAMT { get; set; }
    }
}
