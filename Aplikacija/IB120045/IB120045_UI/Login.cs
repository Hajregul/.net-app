using IB120045_API.Models;
using IB120045_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IB120045_UI
{
    public partial class Login : Form
    {
        APIServices _apiService = new APIServices("Zaposlenici/ZaposlenikByUserName");

        public Login()
        {
            InitializeComponent();
        }

        private async void btnPrijava_Click(object sender, EventArgs e)
        {
            var list = await _apiService.GetByName<ZaposlenikByUserName_Result>(txtUsername.Text);
            Zaposlenici k= new Zaposlenici();
            k.Adresa = list.Adresa;
            k.DatumRodjenja = list.DatumRodjenja;
            k.Email = list.Email;
            k.Ime = list.Ime;
            k.KorisnickoIme = list.KorisnickoIme;
            k.LozinkaHash = list.LozinkaHash;
            k.LozinkaSalt = list.LozinkaSalt;
            k.Prezime = list.Prezime;
            k.Spol = list.Spol;
            k.Status = list.Status;
            k.Telefon = list.Telefon;
            k.Uloge_UlogaID = list.Uloge_UlogaID;
            k.ZaposlenikID = list.ZaposlenikID;

            if (k.LozinkaHash == UIHelper.GenerateHash(txtPass.Text, k.LozinkaSalt))
            {
                MessageBox.Show("Dobrodošli " + k.Ime + " " + k.Prezime);
                DialogResult = DialogResult.OK;
                GlobalPrijavljeni.TrenutnoPrijavljeniZaposlenik = k;
                Close();
            }
            else
            {
                MessageBox.Show("Error Code ");
                txtPass.Text = String.Empty;
            }
        }
    }
}
