using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB120045_PCL.Model
{
   public class Korisnici
    {

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Nullable<System.DateTime> DatumRegistracije { get; set; }
        public string Grad { get; set; }
        public string Mail { get; set; }
        public Nullable<bool> StatusPrijave { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaSlt { get; set; }
        public string LozinkaHash { get; set; }
        public int KorisnikID { get; set; }
    }
}
