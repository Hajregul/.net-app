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
    
    public partial class Pregledi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pregledi()
        {
            this.Dijagnoze = new HashSet<Dijagnoze>();
        }
    
        public int PregledID { get; set; }
        public System.DateTime DatumPregleda { get; set; }
        public decimal Tezina { get; set; }
        public decimal Visina { get; set; }
        public string Tlak { get; set; }
        public decimal Secer { get; set; }
        public string Opis { get; set; }
        public int Zaposlenici_ZaposlenikID { get; set; }
        public int Pacijenti_PacijentID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dijagnoze> Dijagnoze { get; set; }
        public virtual Pacijenti Pacijenti { get; set; }
        public virtual Zaposlenici Zaposlenici { get; set; }
    }
}
