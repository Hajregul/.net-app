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
    
    public partial class pacijentLastByID_Result
    {
        public int PacijentID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public System.DateTime DatumRodjenja { get; set; }
        public string JMBG { get; set; }
        public System.DateTime DatumPrijave { get; set; }
        public int Skrbnici_SkrbnikID { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> SpolID { get; set; }
        public Nullable<int> ZaposlenikID { get; set; }
        public Nullable<int> SobaID { get; set; }
    }
}
