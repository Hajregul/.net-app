using IB120045_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB120045_UI
{
   public class GlobalPrijavljeni
    {
        public static Zaposlenici TrenutnoPrijavljeniZaposlenik { get; set; }
     
        #region API Routes

        public const string AktivnostiRoute = "api/Aktovnosti";
        public const string AktivnostiKomentarisRoute = "api/AktivnostiKomentaris";
        public const string AktivnostiKorisniciRoute = "api/AktivnostiKorisnici";
        public const string DijagnozeRoute = "api/Dijagnoze";
        public const string KorisniciRoute = "api/Korisnici";
        public const string OcjeneRoute = "api/Ocjene";
        public const string PacijentiRoute = "api/Pacijenti";
        public const string PreglediRoute = "api/Pregledi";
        public const string SkrbnicisRoute = "api/Skrbnicis";
        public const string SobeRoute = "api/Sobe";
        public const string SpolRoute = "api/Spol";
        public const string TerapijeRoute = "api/Terapije";
        public const string UlogeRoute = "api/Uloge";
        public const string VrstaAktivnostiRoute = "api/VrstaAktivnosti";
        public const string ZahtejviZaPrijavuUDomRoute = "api/ZahtejviZaPrijavuUDom";
        public const string ZaposleniciRoute = "api/Zaposlenici";
        public const string ZaposlenicisRoute = "api/Zaposlenicis";

        #endregion
    }
}
