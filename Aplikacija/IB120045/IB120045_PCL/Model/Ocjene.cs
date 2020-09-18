using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB120045_PCL.Model
{
  public class Ocjene
    {
        public int OcjenaID { get; set; }
        public Nullable<int> Ocjena { get; set; }
        public Nullable<System.DateTime> Datum { get; set; }
        public Nullable<int> KorisnikID { get; set; }
        public Nullable<int> AktivnostID { get; set; }
        
    }
}
