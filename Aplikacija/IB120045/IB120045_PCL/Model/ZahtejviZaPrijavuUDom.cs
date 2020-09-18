using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB120045_PCL.Model
{
  public  class ZahtejviZaPrijavuUDom
    {
        public int ZahtjevID { get; set; }
        public bool Odobreno { get; set; }
        public Nullable<System.DateTime> DatumPrijave { get; set; }
        public Nullable<System.DateTime> DatumOdobrenja { get; set; }
        public Nullable<int> KorisnikID { get; set; }
        public Nullable<int> PacijentID { get; set; }

        public virtual Korisnici Korisnici { get; set; }
        public virtual Pacijenti Pacijenti { get; set; }
    }
}
