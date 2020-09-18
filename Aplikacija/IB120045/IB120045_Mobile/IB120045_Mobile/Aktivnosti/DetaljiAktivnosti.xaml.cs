using IB120045_Mobile.Services;
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
	public partial class DetaljiAktivnosti : ContentPage
	{

        APIService _apiServiceZahtjev = new APIService("ZahtejviZaPrijavuUDom");
        APIService _apiServiceKorisnici = new APIService("AktivnostiKorisnici");
        APIService _apiServiceOcjene = new APIService("Ocjene");
        APIService _apiServiceKomentari = new APIService("AktivnostiKomentaris");
        APIService _apiServiceAktovnosti = new APIService("Aktovnosti/GetAktivnostById");
        APIService _apiServiceAktovnostiPreporuceno = new APIService("Aktovnosti/Preporuceno");
        
              APIService _apiServiceAktovnostiProvjera = new APIService("AktivnostiKorisnici/ProvjeraPrijaveNaAktivnost");
        APIService _apiServiceOdobrenja = new APIService("ZahtejviZaPrijavuUDom/PregledOdobrenjaKorisnika");
        APIService _apiServiceAktovnostiPrijava = new APIService("AktivnostiKorisnici/PrijavaNaAktivnost");
        

        int aktivnostID;
        Ocjene a;
        public DetaljiAktivnosti (int aktivnostID)
		{
			InitializeComponent ();
            this.aktivnostID = aktivnostID;
		}


        protected override void OnAppearing()
        {
            BindData();

            base.OnAppearing();
        }

        private async void BindData()
        {
            var zahtjev1 = await _apiServiceAktovnosti.GetById<AktivnostById>(aktivnostID.ToString());

            if (zahtjev1 != null)
            {
                var json = JsonConvert.SerializeObject(zahtjev1);
                AktivnostById aktivnostID = JsonConvert.DeserializeObject<AktivnostById>(json);
                odabranaAktivnost.BindingContext = aktivnostID;

            }

            var zahtjev = await _apiServiceAktovnostiPreporuceno.GetByAktivnostId<List<PreporucenoById_Result>>(aktivnostID.ToString());

            if (zahtjev != null)
            {
                var json = JsonConvert.SerializeObject(zahtjev);
                List<PreporucenoById_Result> preporuceeno = JsonConvert.DeserializeObject<List<PreporucenoById_Result>>(json);
                MenuItemsListView.ItemsSource = preporuceeno;

            }

        }

        private async void Prijavise_Clicked(object sender, EventArgs e)
        {
            int id = Global.LogiraniKorisnik.LogiranKorisnik.KorisnikID;
            var zahtjev1 = await _apiServiceOdobrenja.GetById<ZahtejviZaPrijavuUDom>(id.ToString());

            if (zahtjev1 == null)
            {
                var json = JsonConvert.SerializeObject(zahtjev1);
             ZahtejviZaPrijavuUDom pregled = JsonConvert.DeserializeObject<ZahtejviZaPrijavuUDom>(json);
                if (pregled != null)
                {
                  await  DisplayAlert("Informacija", "Da biste se prijavili na aktivnost, morate biti prijavljeni u dom!", "OK");
                }
                else
                {
                    var response2 = await _apiServiceAktovnostiProvjera.GetByIdAktivnostID<ProvjeraPrijaveNaAktivnost>(id,aktivnostID);

                     if (response2 != null)
                    {
                        
                        var json1 = JsonConvert.SerializeObject(response2);
                        ProvjeraPrijaveNaAktivnost provjera = JsonConvert.DeserializeObject<ProvjeraPrijaveNaAktivnost>(json1);
                        if (provjera != null)
                        {
                    await        DisplayAlert("Informacija", "Već ste prijavljeni na aktivnost!", "OK");
                        }
                        else
                        {
                            var response1 = _apiServiceAktovnostiPrijava.GetByVrstaName<int>(Global.LogiraniKorisnik.LogiranKorisnik.KorisnikID, aktivnostID.ToString());

                            if (response1 !=null)
                            {
                             await   DisplayAlert("Uspjeh", "Uspješno ste se prijavili na aktivnost!", "OK");
                            }
                        }
                    }
                    else
                    {
                        var response1 = _apiServiceAktovnostiPrijava.GetByVrstaName<int>(Global.LogiraniKorisnik.LogiranKorisnik.KorisnikID, aktivnostID.ToString());

                        if (response1 != null)
                        {
                          await  DisplayAlert("Uspjeh", "Uspješno ste se prijavili na aktivnost!", "OK");
                        }
                    }
                }
            }
            else
            {
                DisplayAlert("Informacija", "Da biste se prijavili na aktivnost, morate biti prijavljeni u dom!", "OK");
            }

        }

        private void Zvjezdica1_Clicked(object sender, EventArgs e)
        {
            a = new Ocjene();
            a.Datum = DateTime.Now;
            a.Ocjena = 1;
            a.AktivnostID = aktivnostID;
            a.KorisnikID = Global.LogiraniKorisnik.LogiranKorisnik.KorisnikID;

            var response = _apiServiceOcjene.Insert<Ocjene>(a);
            if (response != null)
            {
                DisplayAlert("Uspjeh", "Uspješno ste ocjenuli aktivnost ocjenom 1 !", "OK");
                BindData();
            }

        }

        private void Zvjezdica2_Clicked(object sender, EventArgs e)
        {
            a = new Ocjene();
            a.Datum = DateTime.Now;
            a.Ocjena = 2;
            a.AktivnostID = aktivnostID;
            a.KorisnikID = Global.LogiraniKorisnik.LogiranKorisnik.KorisnikID;

            var response = _apiServiceOcjene.Insert<Ocjene>(a);
            if (response != null)
            {
                DisplayAlert("Uspjeh", "Uspješno ste ocjenuli aktivnost ocjenom 2 !", "OK");
                BindData();
            }

        }

        private void Zvjezdica3_Clicked(object sender, EventArgs e)
        {
            a = new Ocjene();
            a.Datum = DateTime.Now;
            a.Ocjena = 3;
            a.AktivnostID = aktivnostID;
            a.KorisnikID = Global.LogiraniKorisnik.LogiranKorisnik.KorisnikID;

            var response = _apiServiceOcjene.Insert<Ocjene>(a);
            if (response != null)
            {
                DisplayAlert("Uspjeh", "Uspješno ste ocjenuli aktivnost ocjenom 3 !", "OK");
                BindData();
            }

        }

        private void Zvjezdica4_Clicked(object sender, EventArgs e)
        {
            a = new Ocjene();
            a.Datum = DateTime.Now;
            a.Ocjena = 4;
            a.AktivnostID = aktivnostID;
            a.KorisnikID = Global.LogiraniKorisnik.LogiranKorisnik.KorisnikID;

            var response = _apiServiceOcjene.Insert<Ocjene>(a);
            if (response != null)
            {
              
                DisplayAlert("Uspjeh", "Uspješno ste ocjenuli aktivnost ocjenom 4 !", "OK");
                BindData();
            }

        }

        private void Zvjezdica5_Clicked(object sender, EventArgs e)
        {
            a = new Ocjene();
            a.Datum = DateTime.Now;
            a.Ocjena = 5;
            a.AktivnostID = aktivnostID;
            a.KorisnikID = Global.LogiraniKorisnik.LogiranKorisnik.KorisnikID;

           
                var response = _apiServiceOcjene.Insert<Ocjene>(a);
                if (response != null)
                {
                    DisplayAlert("Uspjeh", "Uspješno ste ocjenuli aktivnost ocjenom 5 !", "OK");
                BindData();
            }

        }

        private void MenuItemsListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            aktivnostID = ((PreporucenoById_Result)e.Item).AktivnostID;
            var zahtjev1 = _apiServiceAktovnosti.GetById<AktivnostById>(aktivnostID.ToString());

            if (zahtjev1 != null)
            {
                var json = JsonConvert.SerializeObject(zahtjev1);
                AktivnostById aktivnostID = JsonConvert.DeserializeObject<AktivnostById>(json);
                odabranaAktivnost.BindingContext = aktivnostID;

            }

            var zahtjev = _apiServiceAktovnostiPreporuceno.GetById<PreporucenoById_Result>(aktivnostID.ToString());

            if (zahtjev != null)
            {
                var json = JsonConvert.SerializeObject(zahtjev);
                List<PreporucenoById_Result> preporuceeno = JsonConvert.DeserializeObject<List<PreporucenoById_Result>>(json);
                odabranaAktivnost.BindingContext = preporuceeno;

            }
        }

        private void Komentiraj_Clicked(object sender, EventArgs e)
        {
            AktivnostiKomentaris aktivnostiKomentaris = new AktivnostiKomentaris();
            aktivnostiKomentaris.DatumKomentiranja = DateTime.Now;
            aktivnostiKomentaris.KorisnikID = Global.LogiraniKorisnik.LogiranKorisnik.KorisnikID;
            aktivnostiKomentaris.AktivnostID = aktivnostID;
            aktivnostiKomentaris.Komentar = inputKomentar.Text;
            var response = _apiServiceKomentari.Insert<AktivnostiKomentaris>(aktivnostiKomentaris);
            if (response != null)
            {
                DisplayAlert("Uspjeh", "Uspješno ste ostavili komentar na odabranu aktivnost!", "OK");
                inputKomentar.Text = "";
            }
        }
    }
}