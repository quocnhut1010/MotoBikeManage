//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MotoBikeManage.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Import_Details
    {
        public int import_detail_id { get; set; }
        public int import_id { get; set; }
        public int vehicle_id { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
    
        public virtual Import_Stock Import_Stock { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
