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
    
    public partial class GST_MST_ITEM_NOTIFIED
    {
        public GST_MST_ITEM_NOTIFIED()
        {
            this.GST_MST_ITEM_CONDITION = new HashSet<GST_MST_ITEM_CONDITION>();
        }
    
        public int Notified_Id { get; set; }
        public string NotificationNo { get; set; }
        public string NotificationSNo { get; set; }
        public int Item_ID { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<decimal> TarrifDuty { get; set; }
        public string Description { get; set; }
        public Nullable<bool> IsCondition { get; set; }
        public Nullable<bool> IsNilRated { get; set; }
        public Nullable<bool> IsExempted { get; set; }
        public Nullable<bool> IsZeroRated { get; set; }
        public Nullable<bool> IsNonGSTGoods { get; set; }
        public Nullable<byte> SpecialConditionApplied { get; set; }
        public Nullable<System.DateTime> ActiveFrom { get; set; }
        public Nullable<System.DateTime> ActiveTo { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual GST_MST_ITEM GST_MST_ITEM { get; set; }
        public virtual ICollection<GST_MST_ITEM_CONDITION> GST_MST_ITEM_CONDITION { get; set; }
    }
}
