//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BodyBuldingWorkout.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class OlcumTipi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OlcumTipi()
        {
            this.Olcum = new HashSet<Olcum>();
        }
    
        public int Id { get; set; }
        public string OlcumTipi1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Olcum> Olcum { get; set; }
    }
}
