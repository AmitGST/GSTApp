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
    
    public partial class GST_MST_CLASS
    {
        public GST_MST_CLASS()
        {
            this.GST_MST_SUBCLASS = new HashSet<GST_MST_SUBCLASS>();
        }
    
        public int ClassID { get; set; }
        public Nullable<int> SubGroupID { get; set; }
        public string ClassCode { get; set; }
        public string ClassDescription { get; set; }
        public Nullable<bool> Status { get; set; }
    
        public virtual GST_MST_SUBGROUP GST_MST_SUBGROUP { get; set; }
        public virtual ICollection<GST_MST_SUBCLASS> GST_MST_SUBCLASS { get; set; }
    }
}
