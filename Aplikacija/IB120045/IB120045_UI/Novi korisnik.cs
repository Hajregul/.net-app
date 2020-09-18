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
    public partial class Novi_korisnik : Form
    {
        APIServices _apiService = new APIServices("Spol");
        APIServices _apiServiceSobeZauzmi = new APIServices("Sobe/ZauzmiSobuIKrevet");
        APIServices _apiServiceSobe = new APIServices("Sobe");
        APIServices _apiServicePacijentiID = new APIServices("Pacijenti/PacijentById");
        APIServices _apiServicePacijenti = new APIServices("Pacijenti");
        APIServices _apiServiceSkrbnici = new APIServices("Skrbnicis");
        APIServices _apiServiceZahtjevi = new APIServices("ZahtejviZaPrijavuUDom");
        APIServices _apiServiceKorisnici = new APIServices("Korisnici");
        APIServices _apiServiceKorisniciID = new APIServices("Korisnici/KorisniciById");

        Pacijenti k;
        string spol;
        int spolID;
        //List<Spol> spol;
        public Novi_korisnik()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox7.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox1.SelectedValue = 0;

            comboBox2.SelectedValue = 0;
        }

        private async void Unos_Click(object sender, EventArgs e)
        {
            int soba;
            if (this.ValidateChildren())
            {
                 k = new Pacijenti();
                k.Ime = textBox1.Text;
                k.Prezime = textBox2.Text;
                k.JMBG = textBox4.Text;
                k.DatumRodjenja = dateTimePicker1.Value;
                k.DatumPrijave = DateTime.Now;
                k.Skrbnici_SkrbnikID =Convert.ToInt32(comboBox1.SelectedValue);
                k.ZaposlenikID = GlobalPrijavljeni.TrenutnoPrijavljeniZaposlenik.ZaposlenikID;
                soba = Convert.ToInt32(comboBox2.SelectedValue);
                k.SobaID = soba;
                k.Status = true;
            

                Korisnici korisnici = new Korisnici();
                korisnici.Ime = textBox1.Text;
                korisnici.Prezime = textBox2.Text;
                korisnici.StatusPrijave = true;
                korisnici.Mail = textBox5.Text;
                korisnici.Grad = textBox6.Text;
                korisnici.KorisnickoIme = textBox7.Text;
                korisnici.DatumRegistracije = DateTime.Now;
                korisnici.LozinkaSlt = UIHelper.GenerateSalt();
                korisnici.LozinkaHash = UIHelper.GenerateHash(textBox3.Text, korisnici.LozinkaSlt);
                k.SpolID  = spolID;

                ZahtejviZaPrijavuUDom zahtejv = new ZahtejviZaPrijavuUDom();
                zahtejv.DatumOdobrenja = DateTime.Now;
                zahtejv.DatumPrijave = DateTime.Now;
                zahtejv.Odobreno = true;

                var korisnik = await _apiServiceKorisnici.Insert<Korisnici>(korisnici);
               
                if (korisnici!=null)
                {
                    if (Convert.ToInt32(comboBox1.SelectedValue) != 0)
                    {
                      
                        var Pacijent = await _apiServicePacijenti.Insert<Pacijenti>(k);
                        if (Pacijent != null)
                        {
                            var Soba =await _apiServiceSobeZauzmi.GetById<int>(soba);
                            if (Soba!=0)
                            {
                                var korisnikID = await _apiServiceKorisniciID.GetT<int>();
                                if (korisnikID!=0)
                                {
                                    zahtejv.KorisnikID = Convert.ToInt32( korisnikID);
                                    var pacijent = await _apiServicePacijentiID.GetT<int>();
                                    if (pacijent!=0)
                                    {
                                        zahtejv.PacijentID = Convert.ToInt32(pacijent); ;
                                        var ZAHTJEV = await _apiServiceZahtjevi.Insert<ZahtejviZaPrijavuUDom>(zahtejv);
                                        if (ZAHTJEV!=null)
                                        {
                                            const string message = "Pacijent uspješno dodan!";
                                            const string caption = "Informacija";

                                            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            DialogResult = DialogResult.OK;
                                            Close();
                                        }
                                    }
                                }
                            }
                        }

                        else
                            MessageBox.Show("Error Code ");
                    }
                }

            }
        }
        private void Novi_korisnik_Load(object sender, EventArgs e)
        {     
            LoadSobe();
            LoadSkrbnik();
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
        
        private async void LoadSkrbnik()
        {            
                var  skrbnici = await _apiServiceSkrbnici.GetT<List<AllSkrbnici_Result>>();
                skrbnici.Insert(0, new AllSkrbnici_Result());
                skrbnici[0].Naziv = "Odaberite skrbnika";
                comboBox1.DataSource = skrbnici;
                comboBox1.DisplayMember = "Naziv";
                comboBox1.ValueMember = "SkrbnikID";            
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textBox1, "Ime je obavezno.");
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textBox2, "Prezime je obavezno.");
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox4.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textBox4, "JMBG je obavezno.");
            }
        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            if ( Convert.ToInt32(comboBox1.SelectedValue)==0)
            {
                const string message = "Da li želite dodati novog skrbnika?";
                const string caption = "Odabir skrbnika je obavezan!";
                var result = MessageBox.Show(message, caption,MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                   
                }
                if (result == DialogResult.Yes)
                {
                    Novi_skrbnik f = new Novi_skrbnik();

                
                    f.Show();
                }
            }
        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox6.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textBox6, "Grad je obavezno.");
            }
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox5.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textBox5, "E-mail je obavezno.");
            }
        }

        private void textBox7_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox7.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textBox7, "Korisničko ime je obavezno.");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox3.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textBox3, "Lozinka je obavezna.");
            }
        }

        private void comboBox2_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt32(comboBox2.SelectedValue) == 0)
            {
                const string message = "Informacija?";
                const string caption = "Odabir sobe je obavezan!";
                var result = MessageBox.Show(message, caption,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PretragaKorisnika p = new PretragaKorisnika();
            p.Show();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                spol = "Muškarac";
                spolID = 1;
            }
            else
            {
                spol = "Žena";
                spolID = 2;
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                spol = "Žena";
                spolID = 2;
            }
            else
            {
                spol = "Muškarac";
                spolID = 1;
            }
        }
    }
}
