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
    
    public partial class Zaposlenici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zaposlenici()
        {
            this.Aktovnosti = new HashSet<Aktovnosti>();
            this.Pacijenti = new HashSet<Pacijenti>();
            this.Pregledi = new HashSet<Pregledi>();
        }
    
        public int ZaposlenikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Nullable<System.DateTime> DatumRodjenja { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Spol { get; set; }
        public int Uloge_UlogaID { get; set; }
        public Nullable<bool> Status { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Aktovnosti> Aktovnosti { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pacijenti> Pacijenti { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pregledi> Pregledi { get; set; }
        public virtual Uloge Uloge { get; set; }
    }
}
