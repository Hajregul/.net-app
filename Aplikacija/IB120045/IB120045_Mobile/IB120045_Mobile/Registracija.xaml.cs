
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
    public partial class Registracija : ContentPage
    {
        APIService _apiService = new APIService("Korisnici");
        public Registracija()
        {
            InitializeComponent();
        }

        private async void BtnRegistracija_Clicked(object sender, EventArgs e)
        {
            Korisnici k = new Korisnici();
            k.Ime = inputIme.Text;
            k.Prezime = inputPrezime.Text;
            k.KorisnickoIme = inputUsername.Text;
            k.Mail = inputMail.Text;
            k.DatumRegistracije = DateTime.Now;
            k.LozinkaSlt = UIHelper.GenerateSalt();
            string d = inputPasswordReg.Text;
            k.LozinkaHash = UIHelper.GenerateHash(d, k.LozinkaSlt);
            k.StatusPrijave = false;
            k.Grad = inputGrad.Text;
            if (k.Ime == null || k.Prezime == null || k.KorisnickoIme == null || k.Mail == null || k.LozinkaSlt == null)
            {

               await DisplayAlert("Upozorenje", "Za registraciju je potrebno popuniti sva polja!", "OK");

            }
            else
            {
            //    HttpResponseMessage response = klijentiService.PostResponse(k);
                var korisnikPostoji = await _apiService.Insert<Korisnici>(k);
                if (korisnikPostoji!=null)
                {
                  await  DisplayAlert("Uspjeh", "Uspješno ste se registrovali!", "OK");
                    App.Current.MainPage = new Login();
                    //      Navigation.PushModalAsync(new Login());
                }
                else
                {
                   await DisplayAlert("Greška", "Došlo je do greške!", "OK");
                }
            }
        }

        private void BtnLogin_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new Navigation.MasterDetailPage1(new Login()));
        }
    }
}