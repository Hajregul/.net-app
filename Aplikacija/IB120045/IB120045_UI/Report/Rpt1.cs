using IB120045_API.Models;
using IB120045_UI.Util;
using Microsoft.Reporting.WinForms;
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

namespace IB120045_UI.Report
{
    public partial class Rpt1 : Form
    {

        private WebAPIHelper preglediService = new WebAPIHelper("http://localhost:55393/", "api/Pregledi");
        private WebAPIHelper pacijentiService = new WebAPIHelper("http://localhost:55393/", "api/Pacijenti");
        public Rpt1()
        {
            InitializeComponent();
        }

        private void Rpt1_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = pacijentiService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                List<AllPacijenti_Result> p = response.Content.ReadAsAsync<List<AllPacijenti_Result>>().Result;
                p.Insert(0, new AllPacijenti_Result());
                p[0].Korisnik = "Odaberite pacijenta";
                comboBox2.DataSource = p;
                comboBox2.DisplayMember = "Korisnik";
                comboBox2.ValueMember = "KorisnikID";
            }
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int pacijentID = Convert.ToInt32(comboBox2.SelectedValue);
            
        

            HttpResponseMessage response = preglediService.GetActionResponse("PregledByPacijentID", pacijentID);
            if (response.IsSuccessStatusCode)
            {
                List<esp_PregledByPacijentID_Result> pregledi = response.Content.ReadAsAsync<List<esp_PregledByPacijentID_Result>>().Result;
                
               

                ReportDataSource rds = new ReportDataSource("DataSet1", pregledi);

                reportViewer1.LocalReport.ReportEmbeddedResource = "IB120045_UI.Report.Report1.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                pregledi = null;
                
            }
            pacijentID = 0;
            this.reportViewer1.RefreshReport();

            
        }
    }
}
