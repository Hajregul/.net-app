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
    
    public partial class LastPregled_Result
    {
        public int PregledID { get; set; }
        public System.DateTime DatumPregleda { get; set; }
        public decimal Tezina { get; set; }
        public decimal Visina { get; set; }
        public string Tlak { get; set; }
        public decimal Secer { get; set; }
        public string Opis { get; set; }
        public int Zaposlenici_ZaposlenikID { get; set; }
        public int Pacijenti_PacijentID { get; set; }
    }
}