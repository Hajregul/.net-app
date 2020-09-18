using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB120045_PCL.Model
{
    public class ProvjeraPrijaveNaAktivnost
    {
        public int AktivnostiKorisniciID { get; set; }
        public Nullable<System.DateTime> Datum { get; set; }
        public Nullable<bool> Prijava { get; set; }
        public Nullable<bool> Odobreno { get; set; }
        public Nullable<int> KorisnkiID { get; set; }
        public Nullable<int> AktivnostID { get; set; }
    }
}
