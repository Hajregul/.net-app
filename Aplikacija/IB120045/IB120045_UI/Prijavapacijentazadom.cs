using IB120045_API.Models;
using IB120045_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IB120045_UI
{
    public partial class Prijavapacijentazadom : Form
    {
        APIServices _apiServiceZahtjevi = new APIServices("ZahtejviZaPrijavuUDom");
        APIServices _apiServiceSobe = new APIServices("Sobe");
        APIServices _apiServiceSobeZauzmi = new APIServices("Sobe/ZauzmiSobuIKrevet");
        APIServices _apiServiceZahtjeviOdobri = new APIServices("ZahtejviZaPrijavuUDom/OdobriPrijavuUDom");
        APIServices _apiServiceZahtjeviBy = new APIServices("ZahtejviZaPrijavuUDom/ZahtjeviByParametri");

        int zahtjevID, korisnikID, pacijentID;

        private async void Unos_Click(object sender, EventArgs e)
        {
            int soba = Convert.ToInt32(comboBox2.SelectedValue);
            bool odobreno=false;
            if (checkBox1.Checked)
            {
                odobreno = true;
            }
            else {
                odobreno = false;
            }
            var sobe = await _apiServiceSobeZauzmi.GetByName<int>(soba);
            if (sobe!=0)
            {                
                 var odobri = await _apiServiceZahtjeviOdobri.GetByZahtjevOdobri<int>(zahtjevID,odobreno);
                if (odobri!=0)
                {
                    const string message = "Prijava u dom je uspješno odobrena!";
                    const string caption = "Informacija";
                
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        public Prijavapacijentazadom(int zahtjevID,int korisnikID,int pacijentID)
        {
            InitializeComponent();
            this.zahtjevID = zahtjevID;
            this.korisnikID = korisnikID;
            this.pacijentID = pacijentID;
        }

        private void Prijavapacijentazadom_Load(object sender, EventArgs e)
        {
            LoadSobe();
            LoadPacijent();
        }

        private async void LoadPacijent()
        {

            var zahtjebiby = await _apiServiceZahtjeviBy.GetByParametri<ZahtjeviByParametri1_Result>(zahtjevID, korisnikID, pacijentID);
            if (zahtjebiby != null)
            {
                ZahtjeviByParametri1_Result zahtjev = zahtjebiby;
                if (zahtjev.Odobreno)
                {
                    this.Close();
                    const string message =
                   "Ovaj zahtjev je već odobren!";
                    const string caption = "Informacija";

                    var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    label12.Text = zahtjev.Ime;
                    label13.Text = zahtjev.Prezime;
                    label14.Text = zahtjev.DatumRodjenja.ToShortDateString();
                    label15.Text = zahtjev.JMBG;
                    label16.Text = zahtjev.Spol;
                    label17.Text = zahtjev.Skrbnik;
                    label18.Text = zahtjev.Grad;
                    label19.Text = zahtjev.Mail;
                    label21.Text = zahtjev.KorisnickoIme;
                }
            }
        }

        private async void LoadSobe()
        {           
                var sobe = await _apiServiceSobe.GetT<List<AllSobe2_Result>>();
                sobe.Insert(0, new AllSobe2_Result());
                sobe[0].Soba = " ";
                comboBox2.DataSource = sobe;
                comboBox2.DisplayMember = "Soba";
                comboBox2.ValueMember = "SobaID";            
        }
    }
}
