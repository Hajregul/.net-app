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
    public partial class PretragaKorisnika : Form
    {
        APIServices _apiService = new APIServices("Korisnici/Search");
        APIServices _apiServiceAll = new APIServices("Korisnici/PregledKorisnikaDomaALL");
        
        public PretragaKorisnika()
        {
            InitializeComponent();
        }
        string kime ,jmbg= null;
      
     
        private void PretragaKorisnika_Load_1(object sender, EventArgs e)
        {
            GridUcitaj();
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            kime = textBox2.Text.ToString();
            jmbg = textBox1.Text.ToString();

            if (kime == "")
            {
                kime = "null";
            }
            if (jmbg == "")
            {

                jmbg = "null";
            }
            var list = await _apiService.GetByNameJmbg<List<esp_PregledKorisnikaDoma_Result>>(jmbg, kime);

            if (list != null)
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = list;
            }
            else
            {
                MessageBox.Show("Nije moguć pregled.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (list.Count() == 0)
            {
                GridUcitaj();
            }

        }

        private async void GridUcitaj()
        {          
            var list = await _apiServiceAll.GetT<List<esp_PregledKorisnikaDomaALL_Result>>();

            if (list != null)
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = list;
            }
            else
            {
                MessageBox.Show("Nije moguće odobrit aktivnost.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
