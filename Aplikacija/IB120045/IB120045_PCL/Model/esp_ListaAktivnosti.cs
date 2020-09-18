using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB120045_PCL.Model
{
   public class esp_ListaAktivnosti
    {
        public int AktivnostID { get; set; }
        public string Naziv { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public Nullable<System.DateTime> Datum { get; set; }
        public Nullable<System.TimeSpan> Vrijeme { get; set; }
        public string Ogranicenja { get; set; }
        public string VrstaNaziv { get; set; }
    }
}
