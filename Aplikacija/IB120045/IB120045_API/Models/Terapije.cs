//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IB120045_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Terapije
    {
        public int TerapijaID { get; set; }
        public string Naziv { get; set; }
        public System.DateTime DatumPocetkaTerapije { get; set; }
        public System.DateTime DatumKrajaTerapije { get; set; }
        public int Dijagnoze_DijagnozaID { get; set; }
    
        public virtual Dijagnoze Dijagnoze { get; set; }
    }
}
