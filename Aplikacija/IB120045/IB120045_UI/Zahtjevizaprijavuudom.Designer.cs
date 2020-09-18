namespace IB120045_UI
{
    partial class Zahtjevizaprijavuudom
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
            this.ZahtjevID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odobreno = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DatumPrijave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumOdobrenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnikID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacijentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ZahtjevID,
            this.Odobreno,
            this.DatumPrijave,
            this.DatumOdobrenja,
            this.KorisnikID,
            this.PacijentID});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(372, 426);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ZahtjevID
            // 
            this.ZahtjevID.DataPropertyName = "ZahtjevID";
            this.ZahtjevID.HeaderText = "ZahtjevID";
            this.ZahtjevID.Name = "ZahtjevID";
            this.ZahtjevID.ReadOnly = true;
            this.ZahtjevID.Visible = false;
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
            // DatumPrijave
            // 
            this.DatumPrijave.DataPropertyName = "DatumPrijave";
            this.DatumPrijave.HeaderText = "Datum prijave";
            this.DatumPrijave.Name = "DatumPrijave";
            this.DatumPrijave.ReadOnly = true;
            // 
            // DatumOdobrenja
            // 
            this.DatumOdobrenja.DataPropertyName = "DatumOdobrenja";
            this.DatumOdobrenja.HeaderText = "Datum odobrenja";
            this.DatumOdobrenja.Name = "DatumOdobrenja";
            this.DatumOdobrenja.ReadOnly = true;
            this.DatumOdobrenja.Width = 120;
            // 
            // KorisnikID
            // 
            this.KorisnikID.DataPropertyName = "KorisnikID";
            this.KorisnikID.HeaderText = "KorisnikID";
            this.KorisnikID.Name = "KorisnikID";
            this.KorisnikID.ReadOnly = true;
            this.KorisnikID.Visible = false;
            // 
            // PacijentID
            // 
            this.PacijentID.DataPropertyName = "PacijentID";
            this.PacijentID.HeaderText = "PacijentID";
            this.PacijentID.Name = "PacijentID";
            this.PacijentID.ReadOnly = true;
            this.PacijentID.Visible = false;
            // 
            // Zahtjevizaprijavuudom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 450);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Zahtjevizaprijavuudom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zahtjevi za prijavu u dom";
            this.Load += new System.EventHandler(this.Zahtjevizaprijavuudom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZahtjevID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Odobreno;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPrijave;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumOdobrenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacijentID;
    }
}