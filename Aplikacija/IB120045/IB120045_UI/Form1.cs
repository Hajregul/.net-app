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
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IB120045_UI
{
    public partial class Form1 : Form
    {

        private WebAPIHelper zaposleniciService = new WebAPIHelper("http://localhost:55393/", "api/Zaposlenici");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response= zaposleniciService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Zaposlenici> users = response.Content.ReadAsAsync<List<Zaposlenici>>().Result;
                dataGridView1.DataSource = users;

            }

            else
                MessageBox.Show("Error Code :" + response.StatusCode + "Message :" + response.ReasonPhrase);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
