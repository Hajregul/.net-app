namespace IB120045_UI
{
    partial class AllKorisnici
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AktivnostiKorisniciID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Korisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odobreno = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Odobri = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AktivnostiKorisniciID,
            this.Korisnik,
            this.Datum,
            this.Odobreno,
            this.Odobri});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(498, 239);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AktivnostiKorisniciID
            // 
            this.AktivnostiKorisniciID.DataPropertyName = "AktivnostiKorisniciID";
            this.AktivnostiKorisniciID.HeaderText = "AktivnostiKorisniciID";
            this.AktivnostiKorisniciID.Name = "AktivnostiKorisniciID";
            this.AktivnostiKorisniciID.Visible = false;
            // 
            // Korisnik
            // 
            this.Korisnik.DataPropertyName = "Korisnik";
            this.Korisnik.HeaderText = "Korisnik";
            this.Korisnik.Name = "Korisnik";
            this.Korisnik.ReadOnly = true;
            this.Korisnik.Width = 120;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum prijave";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            this.Datum.Width = 120;
            // 
            // Odobreno
            // 
            this.Odobreno.DataPropertyName = "Odobreno";
            this.Odobreno.HeaderText = "Odobreno";
            this.Odobreno.Name = "Odobreno";
            this.Odobreno.ReadOnly = true;
            this.Odobreno.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Odobreno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Odobri
            // 
            this.Odobri.HeaderText = "Odobri";
            this.Odobri.Name = "Odobri";
            this.Odobri.ReadOnly = true;
            this.Odobri.Text = "Odobri";
            this.Odobri.ToolTipText = "Odobri";
            this.Odobri.UseColumnTextForButtonValue = true;
            // 
            // AllKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 264);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "AllKorisnici";
            this.Text = "Prijavljeni korisnici na odabranoj aktivnosti";
            this.Load += new System.EventHandler(this.AllKorisnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AktivnostiKorisniciID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korisnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Odobreno;
        private System.Windows.Forms.DataGridViewButtonColumn Odobri;
    }
}