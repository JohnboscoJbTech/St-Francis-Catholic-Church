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
    
    public partial class Sacrament
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sacrament()
        {
            this.SacramentMemberLinks = new HashSet<SacramentMemberLink>();
        }
    
        public int Id { get; set; }
        public string Sacrament1 { get; set; }
        public string SacramentDescription { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SacramentMemberLink> SacramentMemberLinks { get; set; }
    }
}