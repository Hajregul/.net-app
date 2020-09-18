using IB120045_API.Models;
using IB120045_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IB120045_UI
{
    public partial class NewZaposlenik : Form
    {
        APIServices _apiService = new APIServices("Zaposlenici");
        APIServices _apiServiceUloge = new APIServices("Uloge");

        public NewZaposlenik()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }
        Zaposlenici k;
        string spol;
        private void dodajButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                k = new Zaposlenici();
                k.Ime = imeInput.Text;
                k.Prezime = prezimeInput.Text;
                k.Email = emailInput.Text;
                k.Telefon = telefonInput.Text;
                k.KorisnickoIme = korisnickoimeInput.Text;
                k.Spol = spol;
                k.DatumRodjenja = dateTimePicker1.Value;
                k.Adresa = adresaInput.Text;
                k.LozinkaSalt = UIHelper.GenerateSalt();
                k.LozinkaHash = UIHelper.GenerateHash(lozinkaInput.Text, k.LozinkaSalt);
                k.Status = true;
                var selected = chbUlogeList.CheckedItems.Cast<Uloge>().FirstOrDefault();

                k.Uloge = selected;
                k.Uloge_UlogaID = selected.UlogaID;

                var d = _apiService.Insert<Pregledi>(k);
                if (d!=null)
                {
                    MessageBox.Show("Zaposlenik uspješno dodan!");
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

        private void emailInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(emailInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(emailInput, "Email je obavezno.");
            }
            else
            {
                try
                {
                    MailAddress mail = new MailAddress(emailInput.Text);
                }
                catch (Exception)
                {
                    e.Cancel = true;
                    errorProvider.SetError(emailInput, "Email mora biti u pravom formatu.");
                }
            }
        }

        private void telefonInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(telefonInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(telefonInput, "Telefon je obavezan.");
            }
        }

        private void korisnickoimeInput_Validating(object sender, CancelEventArgs e)
        {

            if (String.IsNullOrEmpty(korisnickoimeInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(korisnickoimeInput, "Telefon je obavezan.");
            }
        }

        private void lozinkaInput_Validating(object sender, CancelEventArgs e)
        {

            if (String.IsNullOrEmpty(lozinkaInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(lozinkaInput, "Lozinka je obavezna.");
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                spol = "Muškarac";
            }
            else
            {
                spol = "Žena";
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                spol = "Žena";
            }
            else
            {
                spol = "Muškarac";
            }
        }

        private async void NewZaposlenik_Load(object sender, EventArgs e)
        {
            var Uloge = await _apiServiceUloge.GetT<List<Uloge>>();

            if (Uloge!=null)
            {
                List<Uloge> uloge = Uloge;

                chbUlogeList.DataSource = uloge;
                chbUlogeList.DisplayMember = "NazivUloge";
                chbUlogeList.ValueMember = "UlogaID";
            }
        }
    }
}
