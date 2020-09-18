
using IB120045_Mobile;
using IB120045_Mobile.Global;
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

namespace IB120045_Mobile
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
        
        APIService _apiService = new APIService("Korisnici/KorisnikByKorisnickoImeStatus");
        public Login ()
		{
			InitializeComponent ();
		}

        private async void BtnLogin_Clicked(object sender, EventArgs e)
        {
            var korisnikPostoji = await _apiService.GetById<KorisnikByKorisnickoImeStatusPrijava>(inputUsername.Text.ToString());
            if (korisnikPostoji!=null)
            {
                
                if (korisnikPostoji.StatusPrijave == false)
                {

                    await DisplayAlert("Informacija", "Registracija nije odobrena od administratora, molimo sačekajte na odobrenje!", "OK");
                }
                else


                {
                    Korisnici k = new Korisnici();
                    k.StatusPrijave = korisnikPostoji.StatusPrijave;
                    k.Prezime = korisnikPostoji.Prezime;
                    k.Mail = korisnikPostoji.Mail;
                    k.LozinkaSlt = korisnikPostoji.LozinkaSlt;
                    k.LozinkaHash = korisnikPostoji.LozinkaHash;
                    k.KorisnickoIme = korisnikPostoji.KorisnickoIme;
                    k.KorisnikID = korisnikPostoji.KorisnikID;
                    k.Ime = korisnikPostoji.Ime;
                    k.Grad = korisnikPostoji.Grad;
                    k.DatumRegistracije = korisnikPostoji.DatumRegistracije;
                   
                    LogiraniKorisnik.LogiranKorisnik = k;
                    LogiraniKorisnik.Aktivan = true;
                    if (k == null) {

                        await DisplayAlert("Informacija", "Registracija nije odobrena od administratora, molimo sačekajte na odobrenje!", "OK");
                    }
                    else
                    {
                        string d = inputPassword.Text;
                        string s = UIHelper.GenerateHash(d, k.LozinkaSlt);

                        if (k.LozinkaHash == s)
                        {
                            await this.Navigation.PushModalAsync(new Navigation.MasterDetailPage1(new Aktivnosti.PregledAktivnosti()));
                        }
                        else
                        {
                            await DisplayAlert("Upozorenje", "Lozinka nije ispravna!", "OK");
                        }
                    }
                }

            }
            else
            {
                await DisplayAlert("Informacija", "Registracija nije odobrena od administratora, molimo sačekajte na odobrenje!", "OK");
            }

        }

        private void BtnRegistracija_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new Navigation.MasterDetailPage1(new Registracija()));
        }
    }
}