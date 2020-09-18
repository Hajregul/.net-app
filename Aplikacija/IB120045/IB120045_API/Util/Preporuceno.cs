using IB120045_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IB120045_API.Util
{
    public class Preporuceno
    {
        Dictionary<int?, List<Ocjene>> oprema = new Dictionary<int?, List<Ocjene>>();
        private StarackiEntities db = new StarackiEntities();


        public List<PreporucenoById_Result> GetSlicneAktivnosti(int AktivnostID)
        {
            UcitajKorisnike(AktivnostID);
            List<Ocjene> ocjene = db.Ocjene.Where(x => x.AktivnostID == AktivnostID).OrderBy(x => x.KorisnikID).ToList();

            List<Ocjene> zajednickeOcjene1 = new List<Ocjene>();
            List<Ocjene> zajednickeOcjene2 = new List<Ocjene>();

            List<PreporucenoById_Result> preporuceno = new List<PreporucenoById_Result>();


            foreach (var item in oprema)
            {
                foreach (Ocjene o in ocjene)
                {

                    if (item.Value.Where(x => x.KorisnikID == o.KorisnikID).Count() > 0)
                    {
                        zajednickeOcjene1.Add(o);
                        zajednickeOcjene2.Add(item.Value.Where(x => x.KorisnikID == o.KorisnikID).First());
                    }
                }


                double slicnost = GetSlicnost(zajednickeOcjene1, zajednickeOcjene2);
                if (slicnost > 0.6)
                    preporuceno.Add(db.PreporucenoById(item.Key).FirstOrDefault());


                zajednickeOcjene1.Clear();
                zajednickeOcjene2.Clear();
            }


            return preporuceno;
        }


        private void UcitajKorisnike(int OpremaID)
        {
            List<Aktovnosti> aktivnaOprema = db.Aktovnosti.Where(x=>x.AktivnostID != OpremaID).ToList();

            List<Ocjene> ocjene;
            foreach (Aktovnosti k in aktivnaOprema)
            {
                ocjene = db.Ocjene.Where(x => x.AktivnostID == k.AktivnostID).OrderBy(x => x.KorisnikID).ToList();
                if (ocjene.Count > 0)
                    oprema.Add(k.AktivnostID, ocjene);

            }
        }


        double GetSlicnost(List<Ocjene> ocjene1, List<Ocjene> ocjene2)
        {
            if (ocjene1.Count != ocjene2.Count)
                return 0;

            int? brojnik = 0;
            int? int1 = 0;
            int? int2 = 0;

            for (int i = 0; i < ocjene1.Count; i++)
            {
                brojnik += ocjene1[i].Ocjena * ocjene2[i].Ocjena;
                int1 += ocjene1[i].Ocjena * ocjene1[i].Ocjena;
                int2 += ocjene2[i].Ocjena * ocjene2[i].Ocjena;
            }
            
           double int11 = Math.Sqrt(Convert.ToDouble(int1));
          double  int22 = Math.Sqrt(Convert.ToDouble(int2));

            double nazivnik = int11 * int22;
            double brojnik1 = Convert.ToDouble(brojnik);
            if (nazivnik != 0)
                return brojnik1 / nazivnik;

            return 0;

        }
    }
}