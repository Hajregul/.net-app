using IB120045_Mobile.Services;
using IB120045_Mobile.ViewModel;
using IB120045_PCL.Model;
using IB120045_PCL.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IB120045_Mobile.Aktivnosti
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PregledAktivnosti : ContentPage
    {
        APIService _apiService = new APIService("Aktovnosti/ListaAktivnosti");
        APIService _apiServiceVrstaPretraga = new APIService("Aktovnosti/Select_ByVrstaAktivnosti");
        APIService _apiServiceVrstaNaziv = new APIService("Aktovnosti/Select_ByVrstaNazivAktivnosti");
        APIService _apiServiceVrsta = new APIService("VrstaAktivnosti");
        public  List<ViewModel.VrstaAktivnosti> vrsteAktivnosti;

        public PregledAktivnosti()
        {
            InitializeComponent();
            this.BindingContext = new RootModel1
            {
                VrsteList = GetJobsInfo()

            };
        }

        private  List<ViewModel.VrstaAktivnosti> GetJobsInfo()
        {
            var b = GetJobsAll();
            List<AllVrstaAktivnosti1_Result> v = b.Result;
            var json = JsonConvert.SerializeObject(v);
            vrsteAktivnosti = JsonConvert.DeserializeObject<List<ViewModel.VrstaAktivnosti>>(json);
            return vrsteAktivnosti;
        }


        private Task<List<AllVrstaAktivnosti1_Result>> GetJobsAll()
        {
            return Task.Run(() => _apiServiceVrsta.GetT<List<AllVrstaAktivnosti1_Result>>().Result);
        }

        protected async override void OnAppearing()
        {
            try
            {
              
                var listaAktivnosti= await _apiService.GetT<List<esp_ListaAktivnosti>>();
                List<esp_ListaAktivnosti> d = listaAktivnosti;
                if (d != null)
                {
                    var json = JsonConvert.SerializeObject(d);
                    List<esp_ListaAktivnosti> vrsta = JsonConvert.DeserializeObject<List<esp_ListaAktivnosti>>(json);

                         MenuItemsListView.ItemsSource = vrsta;
                }
            }
            catch (HttpRequestException e)
            {
                //Console.WriteLine(e.InnerException.Message);
            }
            base.OnAppearing();
        }
        private void MenuItemsListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (pickerh.SelectedItem != null)
            {
                int aktivnostID = ((Select_ByVrstaAktivnosti)e.Item).AktivnostID;
              
                if (Global.LogiraniKorisnik.LogiranKorisnik.KorisnikID != 0)
                {

                    this.Navigation.PushModalAsync(new Navigation.MasterDetailPage1(new DetaljiAktivnosti(aktivnostID)));
                }
            }
            else
            {
                int aktivnostID = ((esp_ListaAktivnosti)e.Item).AktivnostID;
              
                if (Global.LogiraniKorisnik.LogiranKorisnik.KorisnikID != 0)
                {

                    this.Navigation.PushModalAsync(new Navigation.MasterDetailPage1(new DetaljiAktivnosti(aktivnostID)));
                }
                
            }
        }

        private async void BtnTrazi_Clicked(object sender, EventArgs e)
        {
            int vrstaID = 0;
            string naziv = inputNaziv.Text;
            if (naziv.Length !=0)
            {
                if (pickerh.SelectedItem != null)
                {
                    vrstaID = Convert.ToInt32((pickerh.SelectedItem as ViewModel.VrstaAktivnosti).VrstaAktivnostiID);
                }
               
            
                var aktivnostiByVrsta = await _apiServiceVrstaNaziv.GetByVrstaName<List<Select_AktivnostiVrstaNazivTest>>(vrstaID,naziv);
                List<Select_AktivnostiVrstaNazivTest> d = aktivnostiByVrsta;
                if (d != null)
                {
                    var json = JsonConvert.SerializeObject(d);
                    List<Select_AktivnostiVrstaNazivTest> vrsta = JsonConvert.DeserializeObject<List<Select_AktivnostiVrstaNazivTest>>(json);

                    MenuItemsListView.ItemsSource = vrsta;
                }
            }
            else {
              await  DisplayAlert("Upozorenje", "Unesite naziv aktivnosti za pretragu!", "OK");
            }
        }

        private async void Pickerh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pickerh.SelectedItem != null)
            {

                int vrstaID = Convert.ToInt32((pickerh.SelectedItem as ViewModel.VrstaAktivnosti).VrstaAktivnostiID);
        
                var aktivnostiByVrsta = await _apiServiceVrstaPretraga.GetById<List<Select_ByVrstaAktivnosti>>(vrstaID.ToString());
                List<Select_ByVrstaAktivnosti> d = aktivnostiByVrsta;
                if (d != null)
                {
                    var json = JsonConvert.SerializeObject(d);
                    List<Select_ByVrstaAktivnosti> vrsta = JsonConvert.DeserializeObject<List<Select_ByVrstaAktivnosti>>(json);

                    MenuItemsListView.ItemsSource = vrsta;
                }
            }
        }
    }
}