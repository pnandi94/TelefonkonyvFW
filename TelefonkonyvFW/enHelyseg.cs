//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TelefonkonyvFW
{
    using System;
    using System.Collections.Generic;
    
    public partial class enHelyseg
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public enHelyseg()
        {
            this.enSzemelyek = new HashSet<enSzemely>();
        }
    
        public int Id { get; set; }
        public string Irsz { get; set; }
        public string Nev { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<enSzemely> enSzemelyek { get; set; }
    }
}
