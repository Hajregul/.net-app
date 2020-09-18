using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB120045_PCL.Model
{
   public class Skrbnici
    {
        public int SkrbnikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Nullable<System.DateTime> DatumRodjenja { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> SpolID { get; set; }
    }
}
