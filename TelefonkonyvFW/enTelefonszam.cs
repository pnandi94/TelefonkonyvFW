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
    
    public partial class enTelefonszam
    {
        public int Id { get; set; }
        public string Szam { get; set; }
    
        public virtual enSzemely enSzemely { get; set; }
    }
}
