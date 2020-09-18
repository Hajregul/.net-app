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
using Flurl.Http;
using Flurl;

namespace IB120045_UI
{
    public partial class AllKorisnici : Form
    {
        
        APIServices _apiService = new APIServices("AktivnostiKorisnici/AllKorisniciNaAktivnosti");
        APIServices _apiServiceOdobri = new APIServices("AktivnostiKorisnici/OdobriAktivnost");

        int AktivnostiID;

        public AllKorisnici(int AktivnostiID)
        {
            InitializeComponent();
            this.AktivnostiID = AktivnostiID;
        }

        private void AllKorisnici_Load(object sender, EventArgs e)
        {
            LoadAll();           
        }

        private async void LoadAll()
        {
            var list = await _apiService.GetById<List<AllKorisniciNaAktivnosti_Result>>(AktivnostiID);
          
            if (list!=null)
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = list;
            }
            else
            {
                MessageBox.Show("Nije moguće odobrit aktivnost.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCell cell = row.Cells[4];//Column Index
                cell.Value = "Odobri";
            }

        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[0].Selected) {
                bool odobrena = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                if (odobrena)
                {
                    MessageBox.Show("Prijava je već odobrena.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int AktivnostKorisnikID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());

                    if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                    {
                        if (AktivnostKorisnikID != 0)
                        {
                            var list = await _apiServiceOdobri.GetById<int>(AktivnostKorisnikID);

                            if(list!=0)
                            {
                                LoadAll();
                                MessageBox.Show("Odobrili ste prijavu.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                    }
                }
            }
            
        }
    }
}
