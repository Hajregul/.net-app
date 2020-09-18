using Flurl.Http;
using Flurl;
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
using System.Configuration;

namespace IB120045_UI
{
    public partial class Evidencijaaktivnosti : Form
    {

        APIServices _apiService = new APIServices("Aktovnosti");
        APIServices _apiServiceS = new APIServices("Aktovnosti/SearchByNaziv");

        public Evidencijaaktivnosti()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                GridBind();
            }
            else
            {
                var list = await _apiServiceS.GetByNaziv<List<SearchByNaziv_Result>>(textBox1.Text);
               
                if (list != null)
                {
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = list;
                }
                else
                {
                    MessageBox.Show("Error Code");
                }
            }
        }
        private void Evidencijaaktivnosti_Load(object sender, EventArgs e)
        {
            GridBind();
        }

        private async void GridBind()
        {
            var list = await _apiService.GetT<List<AllAktivnostii_Result>>();
            if (list != null)
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = list;
            }
            else
            {
                MessageBox.Show("Error Code");
            }

        }
    }
    
}
