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
    
    public partial class GST_MST_SECTION
    {
        public GST_MST_SECTION()
        {
            this.GST_MST_SUBSECTION = new HashSet<GST_MST_SUBSECTION>();
        }
    
        public int SectionID { get; set; }
        public Nullable<int> HeaderCodeID { get; set; }
        public string SectionCode { get; set; }
        public string SectionName { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    
        public virtual ICollection<GST_MST_SUBSECTION> GST_MST_SUBSECTION { get; set; }
        public virtual GST_MST_HEADER GST_MST_HEADER { get; set; }
    }
}