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
    
    public partial class MemberFamilyMetaData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Sex { get; set; }
        public string DateOfBirth { get; set; }
        public string Relationship { get; set; }
        public int MemberId { get; set; }
    
        public virtual LookUpTable LookUpTable { get; set; }
        public virtual Member Member { get; set; }
    }
}
