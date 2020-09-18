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
    public partial class Zahtjevizaprijavuudom : Form
    {
        APIServices _apiService = new APIServices("ZahtejviZaPrijavuUDom/GetZahtejviZaPrijavuUDoms");
        
        public Zahtjevizaprijavuudom()
        {
            InitializeComponent();
        }
        List<AllZahtjevi1_Result> zahtjevi;
        private async void Zahtjevizaprijavuudom_Load(object sender, EventArgs e)
        {
            var list = await _apiService.GetT<List<AllZahtjevi1_Result>>();

            if (list !=null)
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = list;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int zahtjevID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
            int korisnikID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString());
            int pacijentID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString());

            Prijavapacijentazadom prijava = new Prijavapacijentazadom(zahtjevID,korisnikID,pacijentID);
            prijava.Show();
            this.Close();
        }
    }
}
