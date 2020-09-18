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
    public partial class NovavrstaAktivnosti : Form
    {
        APIServices _apiService = new APIServices("VrstaAktivnosti");

        public NovavrstaAktivnosti()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            VrstaAktivnosti v = new VrstaAktivnosti();
            v.Naziv = textBox1.Text;

            var r = await _apiService.Insert<VrstaAktivnosti>(v);
            if (r != null)
            {
                const string message = "Vrsta aktivnosti uspješno dodana!";
                const string caption = "Informacija";

                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textBox1, "Naziv je obavezno.");
            }
        }      
    }
}
