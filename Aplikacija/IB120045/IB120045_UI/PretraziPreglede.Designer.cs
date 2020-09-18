namespace IB120045_UI
{
    partial class PretraziPreglede
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PregledID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DijagnozaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pacijent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPregleda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tezina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tlak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dijagnoza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Terapija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPocetkaTerapije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumKrajaTerapije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 78;
            this.label1.Text = "Pacijent";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PregledID,
            this.DijagnozaID,
            this.Pacijent,
            this.DatumPregleda,
            this.Tezina,
            this.Visina,
            this.Tlak,
            this.Dijagnoza,
            this.Terapija,
            this.DatumPocetkaTerapije,
            this.DatumKrajaTerapije});
            this.dataGridView1.Location = new System.Drawing.Point(35, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(969, 238);
            this.dataGridView1.TabIndex = 77;
            // 
            // PregledID
            // 
            this.PregledID.DataPropertyName = "PregledID";
            this.PregledID.HeaderText = "PregledID";
            this.PregledID.Name = "PregledID";
            this.PregledID.Visible = false;
            // 
            // DijagnozaID
            // 
            this.DijagnozaID.DataPropertyName = "DijagnozaID";
            this.DijagnozaID.HeaderText = "DijagnozaID";
            this.DijagnozaID.Name = "DijagnozaID";
            this.DijagnozaID.Visible = false;
            // 
            // Pacijent
            // 
            this.Pacijent.DataPropertyName = "Pacijent";
            this.Pacijent.HeaderText = "Pacijent";
            this.Pacijent.Name = "Pacijent";
            this.Pacijent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Pacijent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DatumPregleda
            // 
            this.DatumPregleda.DataPropertyName = "DatumPregleda";
            this.DatumPregleda.HeaderText = "Datum pregleda";
            this.DatumPregleda.Name = "DatumPregleda";
            this.DatumPregleda.Width = 110;
            // 
            // Tezina
            // 
            this.Tezina.DataPropertyName = "Tezina";
            this.Tezina.HeaderText = "Tezina";
            this.Tezina.Name = "Tezina";
            // 
            // Visina
            // 
            this.Visina.DataPropertyName = "Visina";
            this.Visina.HeaderText = "Visina";
            this.Visina.Name = "Visina";
            // 
            // Tlak
            // 
            this.Tlak.DataPropertyName = "Tlak";
            this.Tlak.HeaderText = "Tlak";
            this.Tlak.Name = "Tlak";
            // 
            // Dijagnoza
            // 
            this.Dijagnoza.DataPropertyName = "Dijagnoza";
            this.Dijagnoza.HeaderText = "Dijagnoza";
            this.Dijagnoza.Name = "Dijagnoza";
            // 
            // Terapija
            // 
            this.Terapija.DataPropertyName = "Terapija";
            this.Terapija.HeaderText = "Terapija";
            this.Terapija.Name = "Terapija";
            // 
            // DatumPocetkaTerapije
            // 
            this.DatumPocetkaTerapije.DataPropertyName = "DatumPocetkaTerapije";
            this.DatumPocetkaTerapije.HeaderText = "Datum početka";
            this.DatumPocetkaTerapije.Name = "DatumPocetkaTerapije";
            this.DatumPocetkaTerapije.Width = 110;
            // 
            // DatumKrajaTerapije
            // 
            this.DatumKrajaTerapije.DataPropertyName = "DatumKrajaTerapije";
            this.DatumKrajaTerapije.HeaderText = "Datum kraja";
            this.DatumKrajaTerapije.Name = "DatumKrajaTerapije";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(174, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 80;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(409, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 42);
            this.button1.TabIndex = 81;
            this.button1.Text = "Pretraži";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(606, 28);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 42);
            this.button2.TabIndex = 82;
            this.button2.Text = "Uredi";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PretraziPreglede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1036, 352);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PretraziPreglede";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga pregleda";
            this.Load += new System.EventHandler(this.PretraziPreglede_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PregledID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DijagnozaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pacijent;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPregleda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tezina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tlak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dijagnoza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Terapija;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPocetkaTerapije;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumKrajaTerapije;
    }
}