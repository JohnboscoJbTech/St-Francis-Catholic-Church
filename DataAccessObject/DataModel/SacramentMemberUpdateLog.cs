//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessObject.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class SacramentMemberUpdateLog
    {
        public int Id { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<int> UpdateType { get; set; }
        public int SacramentMemberLinkId { get; set; }
    
        public virtual SacramentMemberLink SacramentMemberLink { get; set; }
    }
}
