namespace IB120045_UI
{
    partial class Meni
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meni));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviKorisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviSkrbnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviZaposlenikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projektiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evidencijaAktivnostiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klijentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledIObradaZahtjevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledZahtjevaZaPrijavuUDomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.računiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledOcjenaAktivnostiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preglediOdabranogPacijentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciToolStripMenuItem,
            this.projektiToolStripMenuItem,
            this.klijentiToolStripMenuItem,
            this.računiToolStripMenuItem,
            this.reportiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1604, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noviKorisnikToolStripMenuItem,
            this.noviSkrbnikToolStripMenuItem,
            this.noviZaposlenikToolStripMenuItem});
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // noviKorisnikToolStripMenuItem
            // 
            this.noviKorisnikToolStripMenuItem.Name = "noviKorisnikToolStripMenuItem";
            this.noviKorisnikToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.noviKorisnikToolStripMenuItem.Text = "Novi korisnik";
            this.noviKorisnikToolStripMenuItem.Click += new System.EventHandler(this.noviKorisnikToolStripMenuItem_Click);
            // 
            // noviSkrbnikToolStripMenuItem
            // 
            this.noviSkrbnikToolStripMenuItem.Name = "noviSkrbnikToolStripMenuItem";
            this.noviSkrbnikToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.noviSkrbnikToolStripMenuItem.Text = "Novi skrbnik";
            this.noviSkrbnikToolStripMenuItem.Click += new System.EventHandler(this.noviSkrbnikToolStripMenuItem_Click);
            // 
            // noviZaposlenikToolStripMenuItem
            // 
            this.noviZaposlenikToolStripMenuItem.Name = "noviZaposlenikToolStripMenuItem";
            this.noviZaposlenikToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.noviZaposlenikToolStripMenuItem.Text = "Novi zaposlenik";
            this.noviZaposlenikToolStripMenuItem.Click += new System.EventHandler(this.noviZaposlenikToolStripMenuItem_Click);
            // 
            // projektiToolStripMenuItem
            // 
            this.projektiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evidencijaAktivnostiToolStripMenuItem});
            this.projektiToolStripMenuItem.Name = "projektiToolStripMenuItem";
            this.projektiToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.projektiToolStripMenuItem.Text = "Aktivnosti";
            // 
            // evidencijaAktivnostiToolStripMenuItem
            // 
            this.evidencijaAktivnostiToolStripMenuItem.Name = "evidencijaAktivnostiToolStripMenuItem";
            this.evidencijaAktivnostiToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.evidencijaAktivnostiToolStripMenuItem.Text = "Evidencija aktivnosti";
            this.evidencijaAktivnostiToolStripMenuItem.Click += new System.EventHandler(this.evidencijaAktivnostiToolStripMenuItem_Click);
            // 
            // klijentiToolStripMenuItem
            // 
            this.klijentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledIObradaZahtjevaToolStripMenuItem,
            this.pregledZahtjevaZaPrijavuUDomToolStripMenuItem});
            this.klijentiToolStripMenuItem.Name = "klijentiToolStripMenuItem";
            this.klijentiToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.klijentiToolStripMenuItem.Text = "Zahtjevi";
            // 
            // pregledIObradaZahtjevaToolStripMenuItem
            // 
            this.pregledIObradaZahtjevaToolStripMenuItem.Name = "pregledIObradaZahtjevaToolStripMenuItem";
            this.pregledIObradaZahtjevaToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.pregledIObradaZahtjevaToolStripMenuItem.Text = "Pregled zahtjeva za registraciju";
            this.pregledIObradaZahtjevaToolStripMenuItem.Click += new System.EventHandler(this.pregledIObradaZahtjevaToolStripMenuItem_Click);
            // 
            // pregledZahtjevaZaPrijavuUDomToolStripMenuItem
            // 
            this.pregledZahtjevaZaPrijavuUDomToolStripMenuItem.Name = "pregledZahtjevaZaPrijavuUDomToolStripMenuItem";
            this.pregledZahtjevaZaPrijavuUDomToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.pregledZahtjevaZaPrijavuUDomToolStripMenuItem.Text = "Pregled zahtjeva za prijavu u dom";
            this.pregledZahtjevaZaPrijavuUDomToolStripMenuItem.Click += new System.EventHandler(this.pregledZahtjevaZaPrijavuUDomToolStripMenuItem_Click);
            // 
            // računiToolStripMenuItem
            // 
            this.računiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledOcjenaAktivnostiToolStripMenuItem});
            this.računiToolStripMenuItem.Name = "računiToolStripMenuItem";
            this.računiToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.računiToolStripMenuItem.Text = "Ocjene";
            // 
            // pregledOcjenaAktivnostiToolStripMenuItem
            // 
            this.pregledOcjenaAktivnostiToolStripMenuItem.Name = "pregledOcjenaAktivnostiToolStripMenuItem";
            this.pregledOcjenaAktivnostiToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.pregledOcjenaAktivnostiToolStripMenuItem.Text = "Pregled ocjena aktivnosti doma";
            this.pregledOcjenaAktivnostiToolStripMenuItem.Click += new System.EventHandler(this.pregledOcjenaAktivnostiToolStripMenuItem_Click);
            // 
            // reportiToolStripMenuItem
            // 
            this.reportiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preglediOdabranogPacijentaToolStripMenuItem});
            this.reportiToolStripMenuItem.Name = "reportiToolStripMenuItem";
            this.reportiToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.reportiToolStripMenuItem.Text = "Reporti";
            // 
            // preglediOdabranogPacijentaToolStripMenuItem
            // 
            this.preglediOdabranogPacijentaToolStripMenuItem.Name = "preglediOdabranogPacijentaToolStripMenuItem";
            this.preglediOdabranogPacijentaToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.preglediOdabranogPacijentaToolStripMenuItem.Text = "Pregledi odabranog pacijenta";
            this.preglediOdabranogPacijentaToolStripMenuItem.Click += new System.EventHandler(this.preglediOdabranogPacijentaToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Visible = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1290, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dobro došli:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1413, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "...";
            // 
            // Meni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1604, 771);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Meni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meni";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Meni_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projektiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klijentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem računiToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem noviKorisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviSkrbnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evidencijaAktivnostiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledIObradaZahtjevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledOcjenaAktivnostiToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem noviZaposlenikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledZahtjevaZaPrijavuUDomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preglediOdabranogPacijentaToolStripMenuItem;
    }
}