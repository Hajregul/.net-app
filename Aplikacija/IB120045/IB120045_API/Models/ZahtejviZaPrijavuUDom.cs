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
    
    public partial class ZahtejviZaPrijavuUDom
    {
        public int ZahtjevID { get; set; }
        public bool Odobreno { get; set; }
        public Nullable<System.DateTime> DatumPrijave { get; set; }
        public Nullable<System.DateTime> DatumOdobrenja { get; set; }
        public Nullable<int> KorisnikID { get; set; }
        public Nullable<int> PacijentID { get; set; }
    
        public virtual Korisnici Korisnici { get; set; }
        public virtual Pacijenti Pacijenti { get; set; }
    }
}
