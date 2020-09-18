using IB120045_Mobile.Services;
using IB120045_PCL.Model;
using IB120045_PCL.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IB120045_Mobile
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KorisnickiProfil : ContentPage
	{

		public KorisnickiProfil ()
		{
			InitializeComponent ();
		}
        APIService _apiService = new APIService("Korisnici");
      //  private WebAPIHelper korisnikService = new WebAPIHelper("http://192.168.1.6/", "api/Korisnici");
        Korisnici k;
        
        protected override void OnAppearing()
        {
            Korisnici k = Global.LogiraniKorisnik.LogiranKorisnik;

            inputUsername.Text = k.KorisnickoIme;
            inputIme.Text = k.Ime;
            inputPrezime.Text = k.Prezime;
            inputMail.Text = k.Mail;
            inputGrad.Text = k.Grad;
            inputPassword.Text = null;
            base.OnAppearing();
        }
        private async void BtnIzmjeni_Clicked(object sender, EventArgs e)
        {
            k = Global.LogiraniKorisnik.LogiranKorisnik;
            k.Ime = inputIme.Text;
            k.Prezime = inputPrezime.Text;
            k.KorisnickoIme = inputUsername.Text;
            k.Mail = inputMail.Text;
            k.Grad = inputGrad.Text;
            k.DatumRegistracije = DateTime.Now;
            k.LozinkaSlt = UIHelper.GenerateSalt();
            k.LozinkaHash = UIHelper.GenerateHash(inputPassword.Text, k.LozinkaSlt);
            k.StatusPrijave = true;
            if (k.Ime == null || k.Prezime == null || k.KorisnickoIme == null || k.Mail == null || k.LozinkaSlt == null || inputPassword.Text == null || k.Grad==null)
            {

              await  DisplayAlert("Upozorenje", "Za izmjenu je potrebno popuniti sva polja!", "OK");

            }
            else
            {
             //   HttpResponseMessage response = korisnikService.PutResponse(k.KorisnikID, k);
               // if (response.IsSuccessStatusCode)
                
                    var korisnikPostoji = await _apiService.Update<Korisnici>(k.KorisnikID,k);
                    if (korisnikPostoji != null)
                    {
                      await  DisplayAlert("Uspjeh", "Uspješno ste izmjenuli podatke!", "OK");
                    App.Current.MainPage =new Navigation.MasterDetailPage1(new Aktivnosti.PregledAktivnosti());

                }
                else
                {
                  await  DisplayAlert("Greška", "Došlo je do greške!", "OK");
                }
            }
        }
    }
}