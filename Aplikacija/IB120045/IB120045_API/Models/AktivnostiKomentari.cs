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
    
    public partial class AktivnostiKomentari
    {
        public int AktivnostiKomentariID { get; set; }
        public Nullable<System.DateTime> DatumKomentiranja { get; set; }
        public Nullable<int> KorisnikID { get; set; }
        public Nullable<int> AktivnostID { get; set; }
        public string Komentar { get; set; }
    
        public virtual Aktovnosti Aktovnosti { get; set; }
        public virtual Korisnici Korisnici { get; set; }
    }
}
