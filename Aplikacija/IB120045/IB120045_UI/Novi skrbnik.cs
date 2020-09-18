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
    public partial class Novi_skrbnik : Form
    {
        
        APIServices _apiService = new APIServices("Skrbnicis");

        public Novi_skrbnik()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }
        List<String> spol;
        private void Novi_skrbnik_Load(object sender, EventArgs e)
        {
            spol = new List<String>();
            spol.Add("Muškarac");
            spol.Add("Žena");


            checkedListBox1.DataSource = spol;
            checkedListBox1.SetItemCheckState(1, CheckState.Unchecked);
            checkedListBox1.SetItemCheckState(0, CheckState.Unchecked);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            imeInput.Text = "";
            prezimeInput.Text = "";
            adresalInput.Text = "";
            emailInput.Text = "";
            telefonInput.Text = "";


            checkedListBox1.SetItemCheckState(0, 0);
            checkedListBox1.SetItemCheckState(1, 0);
        }

        private async void Unos_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                Skrbnici k = new Skrbnici();
                k.Spol = new Spol();
                k.Ime = imeInput.Text;
                k.Prezime = prezimeInput.Text;
                k.Email = emailInput.Text;
                k.Telefon = telefonInput.Text;
                k.DatumRodjenja = dateTimePicker1.Value;
                k.Adresa = adresalInput.Text;
                k.Status = true;

                foreach (var item in checkedListBox1.CheckedItems)
                {
                   
                    if (item.ToString() == "Muškarac")
                    {
                        k.SpolID = 1;
                    }
                    else {
                        k.SpolID = 2;
                    }
                }


               var r=  await _apiService.Insert<Skrbnici>(k);
                if (r!=null)
                {
                    const string message = "Skrbnik uspješno dodan!";
                    const string caption = "Informacija";

                    var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                    MessageBox.Show("Error Code ");
            }
        }

        private void imeInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(imeInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(imeInput, "Ime je obavezno.");
            }
        }

        private void prezimeInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(prezimeInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(prezimeInput, "Prezime je obavezno.");
            }
        }

        private void telefonInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(telefonInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(telefonInput, "Telefon je obavezno.");
            }
        }

        private void adresalInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(adresalInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(adresalInput, "Adresa je obavezno.");
            }
        }

        private void emailInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(emailInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(emailInput, "E-mail je obavezno.");
            }
        }
    }
}
