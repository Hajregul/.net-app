using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB120045_PCL.Model
{
  public  class AktivnostiKomentaris
    {
        public int AktivnostiKomentariID { get; set; }
        public Nullable<System.DateTime> DatumKomentiranja { get; set; }
        public Nullable<int> KorisnikID { get; set; }
        public Nullable<int> AktivnostID { get; set; }
        public string Komentar { get; set; }
    }
}
