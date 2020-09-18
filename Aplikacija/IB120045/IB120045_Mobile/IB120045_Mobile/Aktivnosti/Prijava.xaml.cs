using IB120045_Mobile.Services;
using IB120045_Mobile.ViewModel;
using IB120045_PCL.Model;
using IB120045_PCL.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IB120045_Mobile.Aktivnosti
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Prijava : ContentPage
	{
        APIService _apiServiceSpol = new APIService("Spol");
        APIService _apiServiceZahtjevOdobreno = new APIService("ZahtejviZaPrijavuUDom/Odobreno");
        APIService _apiServiceOdobrenja = new APIService("ZahtejviZaPrijavuUDom/PregledOdobrenjaKorisnika");
        APIService _apiServiceZahtjev = new APIService("ZahtejviZaPrijavuUDom");
        APIService _apiServiceSkrbnicis = new APIService("Skrbnicis");
        APIService _apiServicePacijenti = new APIService("Pacijenti");
        APIService _apiServiceSkrbnicisById = new APIService("Skrbnicis/SkrbniciById");
        APIService _apiServicePacijentiById = new APIService("Pacijenti/PacijentById");
        public List<ViewModel.Spol> spol;
        int spolID,skrbnikSpolID;
        public Prijava ()
		{
			InitializeComponent ();
            this.BindingContext = new RootModel
            {
                SpolList = GetJobsInfo()

            };
        }

        private List<ViewModel.Spol> GetJobsInfo()
        {
            var b = GetJobsAll();
            List<AllSpol_Result> v = b.Result;
            var json = JsonConvert.SerializeObject(v);
            spol = JsonConvert.DeserializeObject<List<ViewModel.Spol>>(json);
            return spol;
        }

        private Task<List<AllSpol_Result>> GetJobsAll()
        {
            return Task.Run(() => _apiServiceSpol.GetT<List<AllSpol_Result>>().Result);
        }

        protected override void OnAppearing()
        {
            var zahtjev1= _apiServiceZahtjevOdobreno.GetById<ZahtejviZaPrijavuUDom>(Global.LogiraniKorisnik.LogiranKorisnik.KorisnikID.ToString());
     
                if (zahtjev1 != null)
                {
                    DisplayAlert("Informacija", "Već ste prijavljeni u dom!", "OK");
                    this.Navigation.PushModalAsync(new Navigation.MasterDetailPage1(new Aktivnosti.PregledAktivnosti()));
                }
                else
                {
                var zahtjev= _apiServiceOdobrenja.GetById<ZahtejviZaPrijavuUDom>(Global.LogiraniKorisnik.LogiranKorisnik.KorisnikID.ToString());
                
                        if (zahtjev == null)
                        {
                            
                        }
                        else
                        {
                            DisplayAlert("Informacija", "Vaša prijava u dom još uvijek nije odobrena, molimo sačekajte odobrenje!", "OK");
                            this.Navigation.PushModalAsync(new Navigation.MasterDetailPage1(new Aktivnosti.PregledAktivnosti()));
                        }
                    
                }
                base.OnAppearing();
            
        }
    
        private void Button_Clicked(object sender, EventArgs e)
        {
            Skrbnici s = new Skrbnici();
            s.Ime = inputImeE.Text;
            s.Prezime = inputPrezimeE.Text;
            s.Telefon = inputTelefon.Text;
            s.Status = false;
            s.DatumRodjenja = dateRodjenja.Date;
            s.Adresa = inputAdresa.Text;
            s.Email = inputMail.Text;
            s.SpolID = skrbnikSpolID;

            if (s.Ime == null || s.Prezime == null || s.Adresa == null || s.Telefon == null || s.Email == null || s.DatumRodjenja == null || s.SpolID == null)
            {

                DisplayAlert("Upozorenje", "Za prijavu potrebno je popuniti sva polja za skrbnika!", "OK");

            }
            else
            {
                var response1 =  _apiServiceSkrbnicis.Insert<Skrbnici>(s);
                if (response1!=null)
                {
                    Pacijenti p = new Pacijenti();
                    p.Ime = inputIme.Text;
                    p.Prezime = inputPrezime.Text;
                    p.JMBG = inputJMBG.Text;
                    p.DatumPrijave = DateTime.Now;
                    p.Status = false;
                    p.DatumRodjenja = dateRodjenja.Date;
                    p.SpolID = spolID;
                    p.ZaposlenikID = null;
                    p.SobaID = null;


                    var zahtjev1 = _apiServiceSkrbnicisById.GetT<int>();
                    if (zahtjev1!=null)
                    {
                        var json = JsonConvert.SerializeObject(zahtjev1);
                        int skrbnikID = JsonConvert.DeserializeObject<int>(json);
                        p.Skrbnici_SkrbnikID = skrbnikID;
                        if (p.Ime == null || p.Prezime == null || p.JMBG == null || p.DatumPrijave == null || p.DatumRodjenja == null || p.SpolID == null)
                        {

                            DisplayAlert("Upozorenje", "Za prijavu potrebno je popuniti sva polja za pacijenta!", "OK");

                        }
                        else
                        {
                            var response = _apiServicePacijenti.Insert<Pacijenti>(p);
                            if (response!= null)
                            {
                                ZahtejviZaPrijavuUDom z = new ZahtejviZaPrijavuUDom();
                                z.DatumPrijave = DateTime.Now;
                                z.DatumOdobrenja = DateTime.Now;
                                z.Odobreno = false;
                                int k = Global.LogiraniKorisnik.LogiranKorisnik.KorisnikID;
                                z.KorisnikID = k;
                                var zahtjev = _apiServicePacijentiById.GetT<int>();

                                if (zahtjev != null)
                                {
                                    var jsonnn = JsonConvert.SerializeObject(zahtjev);
                                    int pacijentID = JsonConvert.DeserializeObject<int>(jsonnn);

                                    z.PacijentID = pacijentID;

                                    var response2 = _apiServiceZahtjev.Insert<ZahtejviZaPrijavuUDom>(z);
                                    if (response2 != null)
                                    {
                                    
                                        DisplayAlert("Uspjeh", "Uspješno ste poslali zahtjev za prijavu u dom!", "OK");
                                        this.Navigation.PushModalAsync(new Navigation.MasterDetailPage1(new Aktivnosti.PregledAktivnosti()));
                                    }
                                    else
                                    {
                                        DisplayAlert("Greška", "Došlo je do greške!", "OK");
                                    }
                                }
                            }
                            else
                            {
                                DisplayAlert("Greška", "Došlo je do greške!", "OK");
                            }
                        }
                    }
                }
                else
                {
                    DisplayAlert("Greška", "Došlo je do greške!", "OK");
                }
            }
        }

        private void SpolPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (spolPicker.SelectedItem != null)
            {

                 spolID = Convert.ToInt32((spolPicker.SelectedItem as ViewModel.Spol).SpolID);
               
            }
        }

        private void SpolSkrbnikaPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                 if (spolSkrbnikaPicker.SelectedItem != null)
            {

                skrbnikSpolID = Convert.ToInt32((spolSkrbnikaPicker.SelectedItem as ViewModel.Spol).SpolID);

            }
        }
    }
}