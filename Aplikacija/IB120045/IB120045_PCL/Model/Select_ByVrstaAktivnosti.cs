using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB120045_PCL.Model
{
    public class Select_ByVrstaAktivnosti
    {
        public int AktivnostID { get; set; }
        public string Naziv { get; set; }
        public Nullable<System.DateTime> Datum { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public Nullable<bool> PrijavaNaAktivnost { get; set; }
        public Nullable<bool> OdobrenjePrijaveNaAktivnost { get; set; }
        public Nullable<int> ZaposlenikID { get; set; }
        public string Ogranicenja { get; set; }
        public Nullable<int> VrstaAktivnostiID { get; set; }
        public Nullable<bool> Stalna { get; set; }
        public Nullable<System.TimeSpan> VrijemeAktivnosti { get; set; }
    }
}
