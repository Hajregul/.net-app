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
    public partial class Zahtjevizaregistraciju : Form
    {
        
        APIServices _apiService = new APIServices("Korisnici/ZahtjeviKorisnikaZaRegistraciju");
        APIServices _apiServiceOR = new APIServices("Korisnici/OdobrenjeRegistracije");

        public Zahtjevizaregistraciju()
        {
            InitializeComponent();
        }

        private void Zahtjevizaregistraciju_Load(object sender, EventArgs e)
        {
         
            GriidLoad();
        }

        private async void GriidLoad()
        {
            var list = await _apiService.GetT<List<esp_ZahtjeviKorisnikaZaRegistraciju_Result>>();
            List<esp_ZahtjeviKorisnikaZaRegistraciju_Result> users = list;
                if (users == null || users.Count==0)
                {
                    dataGridView1.DataSource = users;
                    MessageBox.Show("Trenutno nema zahtjeva za registraciju!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);            
                }
                else
                {
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = users;
                }        
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int KorisnikID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
        
            var or = await _apiServiceOR.GetById<int>(KorisnikID);
                if (or!=0 && dataGridView1.CurrentCell.ColumnIndex.Equals(5))
                {
                    MessageBox.Show("Uspješno ste odobrili registraciju!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GriidLoad();
                }
                
                else
                {
                    MessageBox.Show("Nije moguće odobrit registraciju.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }              
            
        }
    }
}
