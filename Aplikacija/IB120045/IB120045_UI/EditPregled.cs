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
    public partial class EditPregled : Form
    {
        APIServices _apiService = new APIServices("Pregledi/PregledByPregledID");
        APIServices _apiServiceLastPregled = new APIServices("Pregledi/LastPregled");
        APIServices _apiServicePacijenti = new APIServices("Pacijenti");
        APIServices _apiServiceTerapije = new APIServices("Terapije");
        APIServices _apiServiceDijagnoze = new APIServices("Dijagnoze");
        APIServices _apiServiceLastDijagnoze = new APIServices("Dijagnoze/LastDijagnoza");

        int pregledID;
        esp_PregledByID_Result p;

        public EditPregled( int pregledID)
        {
            InitializeComponent();
            this.pregledID = pregledID;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {


            var pregled = await _apiService.GetById<esp_PregledByID_Result>(pregledID);
            Pregledi pp = new Pregledi();
           
            pp.PregledID = pregled.PregledID;
            pp.DatumPregleda = dateTimePicker3.Value;
            pp.Visina = Convert.ToDecimal(textBox4.Text);
            pp.Tezina = Convert.ToDecimal(textBox3.Text);
            pp.Secer = Convert.ToDecimal(textBox1.Text);
            pp.Tlak = textBox2.Text;
            pp.Opis = textBox5.Text;
            pp.Zaposlenici_ZaposlenikID = GlobalPrijavljeni.TrenutnoPrijavljeniZaposlenik.ZaposlenikID;
            pp.Zaposlenici = GlobalPrijavljeni.TrenutnoPrijavljeniZaposlenik;
            pp.Pacijenti_PacijentID = Convert.ToInt32(pregled.PacijentID);

            var update = _apiService.Update<Pregledi>(pp.PregledID,pp);

            if (pp.PregledID != 0)
            {
                var dijagnoza = await _apiService.GetById<esp_PregledByID_Result>(pp.PregledID);
                Dijagnoze d = new Dijagnoze();
                d.Naziv = textBox6.Text;
                d.Opis = textBox5.Text;
                d.Pregledi_PregledID = pp.PregledID;
                d.DijagnozaID = dijagnoza.DijagnozaID;
                await _apiServiceDijagnoze.Update<Dijagnoze>(d.DijagnozaID,d);
                if (d.DijagnozaID != 0)
                {
                    var terapija = await _apiService.GetById<esp_PregledByID_Result>(pp.PregledID);
                    Terapije t = new Terapije();
                    t.DatumKrajaTerapije = dateTimePicker3.Value;
                    t.TerapijaID = terapija.TerapijaID;
                    t.DatumPocetkaTerapije = dateTimePicker2.Value;
                    t.Naziv = textBox7.Text;
                    t.Dijagnoze_DijagnozaID = d.DijagnozaID;

                    var status =  _apiServiceTerapije.Update<Terapije>(t.TerapijaID,t);
                    if (status != null)
                    {
                        const string message = "Pregled uspješno izmjenjen!";
                        const string caption = "Informacija";

                        var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearAll();
                        pregledID = 0;
                    }
                }
            }
        }

        private void ClearAll()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = "";
          
            dateTimePicker1.Value = dateTimePicker2.Value = dateTimePicker3.Value = DateTime.Now;
        }

        private async void EditPregled_Load(object sender, EventArgs e)
        {
            var list = await _apiServicePacijenti.GetT<List<AllPacijenti_Result>>();
            
            var p = await _apiService.GetById<esp_PregledByID_Result>(pregledID);

            if (p != null)
            {
                dateTimePicker3.Value = p.DatumPregleda;
                textBox5.Text = p.OpisDijagnoze;
                textBox4.Text = Convert.ToString(p.Tezina);
                textBox1.Text = Convert.ToString(p.Secer);
                textBox3.Text = Convert.ToString(p.Visina);
                textBox2.Text = p.Tlak;
                textBox6.Text = p.Dijagnoza;
                textBox7.Text = p.Terapija;
                dateTimePicker1.Value = p.DatumPocetkaTerapije;
                dateTimePicker2.Value = p.DatumKrajaTerapije;
            }
        }       
    }
}
