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
    
    public partial class PROC_FILERETURN_GSTR3B_ITC_Result
    {
        public Nullable<decimal> TotalTaxableValue { get; set; }
        public Nullable<decimal> IntegratedTax { get; set; }
        public Nullable<decimal> CentralTax { get; set; }
        public Nullable<decimal> StateTax { get; set; }
        public Nullable<decimal> CESS { get; set; }
        public string Details { get; set; }
        public string Description { get; set; }
    }
}