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
    public partial class PretraziPreglede : Form
    {

        APIServices _apiService = new APIServices("Pregledi");
        APIServices _apiServicePacijenti = new APIServices("Pacijenti");
        APIServices _apiServicePregledPacijenti = new APIServices("Pregledi/PregledByPacijentID");
        
        bool klik;
        int pacijentID; 

        public PretraziPreglede()
        {
            InitializeComponent();
        }

        private void PretraziPreglede_Load(object sender, EventArgs e)
        {
            LoadPacijenti();
            LoadGrid();
            klik = false;
        }

        private async void LoadGrid()
        {
            var list = await _apiService.GetT<List<esp_AllPregledi1_Result>>();
            dataGridView1.DataSource = list;
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


        private async void button1_Click(object sender, EventArgs e)
        {
            pacijentID = Convert.ToInt32(comboBox2.SelectedValue);
            if (pacijentID == 0)
            {
                LoadGrid();
            }
            else
            {      
            var list = await _apiServicePregledPacijenti.GetById<List<esp_PregledByPacijentID_Result>>(pacijentID);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = list;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pregledID = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            EditPregled pregled = new EditPregled(pregledID);
            pregled.Show();
            this.Close();
        }
    }
}
