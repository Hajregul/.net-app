using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB120045_PCL.Model
{
   public class KorisnikByKorisnickoImeStatusPrijava
    {
        public int KorisnikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Mail { get; set; }
        public string KorisnickoIme { get; set; }
        public Nullable<bool> StatusPrijave { get; set; }
        public Nullable<System.DateTime> DatumRegistracije { get; set; }
        public string Grad { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSlt { get; set; }
    }
}
