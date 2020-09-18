using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB120045_PCL.Model
{
   public class Pacijenti
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
