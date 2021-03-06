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
    
    public partial class Matrimony
    {
        public int Id { get; set; }
        public string DateOfMarriage { get; set; }
        public string PlaceOfMarriage { get; set; }
        public string BrideFullName { get; set; }
        public string GroomFullName { get; set; }
        public string BrideAddress { get; set; }
        public string GroomAddress { get; set; }
        public Nullable<int> BrideAge { get; set; }
        public Nullable<int> GroomAge { get; set; }
        public string BrideBaptismPlace { get; set; }
        public string BrideBaptismDate { get; set; }
        public string BrideBaptismNo { get; set; }
        public string GroomBaptismPlace { get; set; }
        public string GroomBaptismDate { get; set; }
        public string GroomBaptismNo { get; set; }
        public string AssistingPriest { get; set; }
        public string BannDetails { get; set; }
        public string BrideParentName { get; set; }
        public string BrideParentHomeTown { get; set; }
        public string GroomParentName { get; set; }
        public string GroomParentHomeTown { get; set; }
        public string Witness1 { get; set; }
        public string Witness2 { get; set; }
        public string Remark { get; set; }
        public int Deleted { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    }
}
