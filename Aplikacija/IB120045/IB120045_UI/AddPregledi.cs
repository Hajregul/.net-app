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
    public partial class AddPregledi : Form
    {

        APIServices _apiService = new APIServices("Pregledi");
        APIServices _apiServiceLastPregled = new APIServices("Pregledi/LastPregled");
        APIServices _apiServicePacijenti = new APIServices("Pacijenti");
        APIServices _apiServiceTerapije = new APIServices("Terapije");
        APIServices _apiServiceDijagnoze= new APIServices("Dijagnoze");
        APIServices _apiServiceLastDijagnoze = new APIServices("Dijagnoze/LastDijagnoza");

        public AddPregledi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Pregledi p = new Pregledi();
            p.DatumPregleda = dateTimePicker1.Value;
            p.Visina = Convert.ToDecimal(textBox4.Text);
            p.Tezina = Convert.ToDecimal(textBox3.Text);
            p.Secer = Convert.ToDecimal(textBox1.Text);
            p.Tlak = textBox2.Text;
            p.Opis = textBox5.Text;
            p.Zaposlenici_ZaposlenikID = GlobalPrijavljeni.TrenutnoPrijavljeniZaposlenik.ZaposlenikID;
            p.Zaposlenici = GlobalPrijavljeni.TrenutnoPrijavljeniZaposlenik;
            p.Pacijenti_PacijentID = Convert.ToInt32(comboBox2.SelectedValue);
            p.Pacijenti = (comboBox2.SelectedItem as Pacijenti);

            await _apiService.Insert<Pregledi>(p);
         
            var pregledID = await _apiServiceLastPregled.GetT<int>();

            if (pregledID != 0) { 
            Dijagnoze d = new Dijagnoze();
            d.Naziv = textBox6.Text;
            d.Opis = textBox5.Text;
            d.Pregledi_PregledID = pregledID;
            await _apiServiceDijagnoze.Insert<Dijagnoze>(d);
            var dijagnozaID = await _apiServiceLastDijagnoze.GetT<int>();
            if(dijagnozaID!=0)
                { 
                    Terapije t = new Terapije();
                    t.DatumKrajaTerapije = dateTimePicker3.Value;

                    t.DatumPocetkaTerapije = dateTimePicker2.Value;
                    t.Naziv = textBox7.Text;
                    t.Dijagnoze_DijagnozaID = dijagnozaID;

                    var status =await _apiServiceTerapije.Insert<Terapije>(t);
                    if (status!=null)
                    {
                        const string message = "Pregled uspješno dodan!";
                        const string caption = "Informacija";

                        var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearAll();
                        dijagnozaID = 0;
                        pregledID = 0;
                    }

                }
            
           
            }
        
    }

    private void ClearAll()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = "";
            comboBox2.SelectedValue = 0;
            dateTimePicker1.Value = dateTimePicker2.Value = dateTimePicker3.Value = DateTime.Now;
        }

        private void AddPregledi_Load(object sender, EventArgs e)
        {
            LoadPacijenti();
        }

        private async void LoadPacijenti()
        {
            var list = await _apiServicePacijenti.GetT<List<AllPacijenti_Result>>();
            list.Insert(0, new AllPacijenti_Result());
            list[0].Korisnik = "Odaberite pacijenta";
            comboBox2.DataSource = list;
            comboBox2.DisplayMember = "Korisnik";
            comboBox2.ValueMember = "KorisnikID";
        }

     
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '/'))
            {
                e.Handled = true;
            }
            
            if ((e.KeyChar == '/') && ((sender as TextBox).Text.IndexOf('/') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
