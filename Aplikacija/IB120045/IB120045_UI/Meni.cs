using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IB120045_UI
{
    public partial class Meni : Form
    {
        public Meni()
        {
            InitializeComponent();
        }

        private void noviKorisnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Novi_korisnik form = new Novi_korisnik();
            IsMdiContainer = true;
            form.MdiParent = this;
            form.Show();
        }

        private void noviSkrbnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Novi_skrbnik f = new Novi_skrbnik();
            IsMdiContainer = true;
            f.MdiParent = this;
            f.Show();
        }

        private void evidencijaAktivnostiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Novaaktivnost form = new Novaaktivnost();
            IsMdiContainer = true;
            form.MdiParent = this;
            form.Show();
        }

        private void pregledOcjenaAktivnostiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            Pregledocjena form = new Pregledocjena();
            form.MdiParent = this;
            form.Show();
        }

        private void Meni_Load(object sender, EventArgs e)
        {
            label3.Text = GlobalPrijavljeni.TrenutnoPrijavljeniZaposlenik.Ime.ToString() + ' ' + GlobalPrijavljeni.TrenutnoPrijavljeniZaposlenik.Prezime.ToString();
        }

        private void noviZaposlenikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            NewZaposlenik z = new NewZaposlenik();
            z.MdiParent = this;
            z.Show();
        }

        private void pregledIObradaZahtjevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            Zahtjevizaregistraciju z = new Zahtjevizaregistraciju();
            z.MdiParent = this;
            z.Show();
        }

        private void pregledZahtjevaZaPrijavuUDomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            Zahtjevizaprijavuudom z = new Zahtjevizaprijavuudom();
            z.MdiParent = this;
            z.Show();
        }

        private void preglediOdabranogPacijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            Report.Rpt1 z = new Report.Rpt1();
            z.MdiParent = this;
            z.Show();
        }       
    }
}
