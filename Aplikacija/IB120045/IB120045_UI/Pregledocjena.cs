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
    public partial class Pregledocjena : Form
    {

        APIServices _apiService = new APIServices("Ocjene/AllOcjene");

        public Pregledocjena()
        {
            InitializeComponent();
        }

        private async void Pregledocjena_Load(object sender, EventArgs e)
        {
            var list = await _apiService.GetT<List<AllOcjene_Result>>();

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
