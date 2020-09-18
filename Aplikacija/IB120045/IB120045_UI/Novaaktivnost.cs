using IB120045_API.Models;
using IB120045_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IB120045_UI
{
    public partial class Novaaktivnost : Form
    {

   
        APIServices _apiService = new APIServices("Pacijenti");
        APIServices _apiServiceVrsta = new APIServices("VrstaAktivnosti");
              APIServices _apiServiceAktivnostiDel = new APIServices("Aktovnosti/DeleteAktovnosti");
        APIServices _apiServiceAktivnosti = new APIServices("Aktovnosti");
        APIServices _apiServiceAktivnostiID = new APIServices("Aktovnosti/GetAktivnostById");

        
        private Aktovnosti aktovnosti { get; set; }
        public AllAktivnostii_Result a;
        public AktivnostById_Result ak { get; set; }

        public Novaaktivnost()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void Novaaktivnost_Load(object sender, EventArgs e)
        {
            LoadVrsteAktivnosti();
            LoadGrid();
        }

        private async void LoadGrid()
        {
            var aktivnosti = await _apiServiceAktivnosti.GetT<List<AllAktivnostii_Result>>();
            if (aktivnosti!=null)
            {
                List<AllAktivnostii_Result> users = aktivnosti;
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = aktivnosti;
            }
            else
            {
                MessageBox.Show("Error Code");
            }
        }
        
        private async void LoadVrsteAktivnosti()
        {
                var  vrste = await _apiServiceVrsta.GetT<List<AllVrstaAktivnosti1_Result>>();
                vrste.Insert(0, new AllVrstaAktivnosti1_Result());
                vrste[0].Naziv = "Odaberite vrstu";
                comboBox1.DataSource = vrste;
                comboBox1.DisplayMember = "Naziv";
                comboBox1.ValueMember = "VrstaAktivnostiID";            
        }
    
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            int AktivnostiID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
            AllKorisnici sviKorisniciNaAktivnostima = new AllKorisnici(AktivnostiID);
            sviKorisniciNaAktivnostima.Show();      
        }   

        private void button1_Click(object sender, EventArgs e)
        {        
            NovavrstaAktivnosti form = new NovavrstaAktivnosti();
            form.Show();
        }
       
        private async void dodajAktivnostButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if ( Convert.ToInt32(comboBox1.SelectedValue) != 0)
                {
                    if (aktovnosti == null)
                    {
                        aktovnosti = new Aktovnosti();
                    }

                    aktovnosti.Naziv = nazivInput.Text;
                    aktovnosti.Datum = dateTimePicker1.Value; 
                    if (textBox1.Text == "")
                    {
                        aktovnosti.Ogranicenja = "Nema ograničenja";
                    }
                    else
                    {
                        aktovnosti.Ogranicenja = textBox1.Text;
                    }
                    aktovnosti.VrstaAktivnostiID = Convert.ToInt32(comboBox1.SelectedValue);
                    aktovnosti.ZaposlenikID = GlobalPrijavljeni.TrenutnoPrijavljeniZaposlenik.ZaposlenikID;
                    if (stalna.Checked)
                    {
                        aktovnosti.Stalna = true;
                    }
                    else {
                        aktovnosti.Stalna = false;
                    }
                    aktovnosti.VrijemeAktivnosti = dateTimePicker2.Value.TimeOfDay;
                    
                  
                    if (aktovnosti.AktivnostID == 0) {
                        await _apiServiceAktivnosti.Insert<Aktovnosti>(aktovnosti);
                        const string message = "Aktivnost uspješno dodana!";
                        const string caption = "Informacija";

                        var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                     var update=  _apiServiceAktivnosti.Update<int>(aktovnosti.AktivnostID, aktovnosti);
                       
                            const string message = "Aktivnost uspješno izmjenjena!";
                            const string caption = "Informacija";

                            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            DialogResult = DialogResult.OK;
                            LoadGrid();
                            aktovnosti = null;
                            Clear();
                        
                    }
                   
                }
            }
        }

        private void Clear()
        {
            textBox1.Text = nazivInput.Text = null;
            comboBox1.SelectedValue = 0;
            stalna.Checked = false;
            pictureBox.Image = null;
            slikaInput.Text = null;
        }

        private void dodajSlikuBtn_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (aktovnosti == null)
                {
                    aktovnosti = new Aktovnosti();
                }
              
                slikaInput.Text = openFileDialog1.FileName;
                Image orgImage = Image.FromFile(openFileDialog1.FileName);
                MemoryStream ms = new MemoryStream();
                orgImage.Save(ms, ImageFormat.Jpeg);
                aktovnosti.Slika = ms.ToArray();


                int resizedImageWidth = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImageWidth"]);
                int resizedImageHeight = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImageHeight"]);
                int croppedImageWidth = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImageWidth"]);
                int croppedImageHeight = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImageHeight"]);


                if (orgImage.Width > resizedImageWidth)
                {
                    Image resizedImg = UIHelper.ResizeImage(orgImage, new Size(resizedImageWidth, resizedImageHeight));

                    if (resizedImg.Width > croppedImageWidth && resizedImg.Height > croppedImageHeight)
                    {
                        int croppedXPosition = (resizedImg.Width - croppedImageWidth) / 2;
                        int croppedYPosition = (resizedImg.Height - croppedImageHeight) / 2;

                        Image croppedImg = UIHelper.CropImage(resizedImg, new Rectangle(croppedXPosition, croppedYPosition, croppedImageWidth, croppedImageHeight));
                        pictureBox.Image = croppedImg;

                        MemoryStream Ms = new MemoryStream();
                        croppedImg.Save(Ms, orgImage.RawFormat);

                        aktovnosti.SlikaThumb = Ms.ToArray();

                    }
                    else
                    {
                        aktovnosti = null;
                    }
                }
            }
        }        

        private void nazivInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(nazivInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(nazivInput, "Naziv je obavezno.");
            }
        }

       

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt32(comboBox1.SelectedValue) == 0)
            {
                const string message = "Odabir vrste aktivnosti je obavezan!";
                const string caption = "Informacija!";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Warning);
            }
        }

     

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            var deleteAktivost = _apiServiceAktivnostiDel.Delete<int>(id);
            if (deleteAktivost!=null)
            {
                const string message = "Uspešno obrisana aktivnost!";
                const string caption = "Informacija";

                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();              
            }
            else
            {
                MessageBox.Show("Error Code ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Evidencijaaktivnosti ev = new Evidencijaaktivnosti();
            ev.Show();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            AktivnostById_Result aktID = new AktivnostById_Result();
            aktID=await _apiServiceAktivnostiID.GetById<AktivnostById_Result>(id.ToString());

            if (aktID!=null)
            {
                ak = aktID;
                aktovnosti = new Aktovnosti();
                
                aktovnosti.AktivnostID = Convert.ToInt32( ak.AktivnostID);
                aktovnosti.ZaposlenikID=ak.ZaposlenikID;

            }
            
            nazivInput.Text = ak.Naziv;
            textBox1.Text = ak.Ogranicenja;
            comboBox1.SelectedValue = ak.VrstaAktivnostiID;
            dateTimePicker1.Value = Convert.ToDateTime( ak.Datum);
            dateTimePicker2.Value = Convert.ToDateTime(ak.Vrijeme);
            slikaInput.Text = "Možete odabrati novu sliku za izmjenu";

            if (ak.Slika == null)
            {
                pictureBox.Image = null;
            }
            else
            {
                var ms = new MemoryStream(ak.Slika);
                Image thumbImage = Image.FromStream(ms);
                pictureBox.Image = thumbImage;

                aktovnosti.Slika = ak.Slika;
                aktovnosti.SlikaThumb = ak.SlikaThumb;
            }
        }
    }
}
