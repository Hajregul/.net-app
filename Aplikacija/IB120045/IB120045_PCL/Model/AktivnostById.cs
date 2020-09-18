using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB120045_PCL.Model
{
   public class AktivnostById
    {
        public int AktivnostID { get; set; }
        public string Datum { get; set; }
        public string Vrijeme { get; set; }
        public string Naziv { get; set; }
        public string Ogranicenja { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public string VrstaNaziv { get; set; }
        public Nullable<decimal> ProsjecnaOcjena { get; set; }
    }
}
