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
    
    public partial class GST_MST_FINYEAR
    {
        public GST_MST_FINYEAR()
        {
            this.GST_TRN_INVOICE = new HashSet<GST_TRN_INVOICE>();
        }
    
        public int Fin_ID { get; set; }
        public string Finyear { get; set; }
        public string Finyear_Format { get; set; }
        public Nullable<bool> Status { get; set; }
    
        public virtual ICollection<GST_TRN_INVOICE> GST_TRN_INVOICE { get; set; }
    }
}