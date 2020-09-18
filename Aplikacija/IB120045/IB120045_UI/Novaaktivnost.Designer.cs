namespace IB120045_UI
{
    partial class Novaaktivnost
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.dodajSlikuBtn = new System.Windows.Forms.Button();
            this.slikaInput = new System.Windows.Forms.TextBox();
            this.nazivOpremaLbl = new System.Windows.Forms.Label();
            this.dodajAktivnostButton = new System.Windows.Forms.Button();
            this.nazivInput = new System.Windows.Forms.TextBox();
            this.datmLbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AktivnostID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaAktivnosti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.Ograničenje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stalna = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox.Location = new System.Drawing.Point(498, 24);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(125, 121);
            this.pictureBox.TabIndex = 58;
            this.pictureBox.TabStop = false;
            // 
            // dodajSlikuBtn
            // 
            this.dodajSlikuBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dodajSlikuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajSlikuBtn.Location = new System.Drawing.Point(640, 51);
            this.dodajSlikuBtn.Margin = new System.Windows.Forms.Padding(2);
            this.dodajSlikuBtn.Name = "dodajSlikuBtn";
            this.dodajSlikuBtn.Size = new System.Drawing.Size(157, 44);
            this.dodajSlikuBtn.TabIndex = 57;
            this.dodajSlikuBtn.Text = "Dodaj sliku";
            this.dodajSlikuBtn.UseVisualStyleBackColor = false;
            this.dodajSlikuBtn.Click += new System.EventHandler(this.dodajSlikuBtn_Click);
            // 
            // slikaInput
            // 
            this.slikaInput.Location = new System.Drawing.Point(640, 24);
            this.slikaInput.Margin = new System.Windows.Forms.Padding(2);
            this.slikaInput.Name = "slikaInput";
            this.slikaInput.Size = new System.Drawing.Size(157, 20);
            this.slikaInput.TabIndex = 56;
            // 
            // nazivOpremaLbl
            // 
            this.nazivOpremaLbl.AutoSize = true;
            this.nazivOpremaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazivOpremaLbl.Location = new System.Drawing.Point(68, 27);
            this.nazivOpremaLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nazivOpremaLbl.Name = "nazivOpremaLbl";
            this.nazivOpremaLbl.Size = new System.Drawing.Size(43, 17);
            this.nazivOpremaLbl.TabIndex = 54;
            this.nazivOpremaLbl.Text = "Naziv";
            // 
            // dodajAktivnostButton
            // 
            this.dodajAktivnostButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dodajAktivnostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajAktivnostButton.Location = new System.Drawing.Point(640, 100);
            this.dodajAktivnostButton.Margin = new System.Windows.Forms.Padding(2);
            this.dodajAktivnostButton.Name = "dodajAktivnostButton";
            this.dodajAktivnostButton.Size = new System.Drawing.Size(157, 45);
            this.dodajAktivnostButton.TabIndex = 53;
            this.dodajAktivnostButton.Text = "SPREMI AKTIVNOST";
            this.dodajAktivnostButton.UseVisualStyleBackColor = false;
            this.dodajAktivnostButton.Click += new System.EventHandler(this.dodajAktivnostButton_Click);
            // 
            // nazivInput
            // 
            this.nazivInput.Location = new System.Drawing.Point(205, 25);
            this.nazivInput.Margin = new System.Windows.Forms.Padding(2);
            this.nazivInput.Name = "nazivInput";
            this.nazivInput.Size = new System.Drawing.Size(157, 20);
            this.nazivInput.TabIndex = 51;
            this.nazivInput.Validating += new System.ComponentModel.CancelEventHandler(this.nazivInput_Validating);
            // 
            // datmLbl
            // 
            this.datmLbl.AutoSize = true;
            this.datmLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datmLbl.Location = new System.Drawing.Point(68, 51);
            this.datmLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.datmLbl.Name = "datmLbl";
            this.datmLbl.Size = new System.Drawing.Size(123, 17);
            this.datmLbl.TabIndex = 49;
            this.datmLbl.Text = "Datum održavanja";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(205, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 20);
            this.dateTimePicker1.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "Ograničenje";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(205, 75);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 20);
            this.textBox1.TabIndex = 62;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AktivnostID,
            this.Naziv,
            this.Datum,
            this.VrstaAktivnosti,
            this.Slika,
            this.Ograničenje});
            this.dataGridView1.Location = new System.Drawing.Point(37, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(598, 211);
            this.dataGridView1.TabIndex = 64;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AktivnostID
            // 
            this.AktivnostID.DataPropertyName = "AktivnostID";
            this.AktivnostID.HeaderText = "AktivnostID";
            this.AktivnostID.Name = "AktivnostID";
            this.AktivnostID.ReadOnly = true;
            this.AktivnostID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AktivnostID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AktivnostID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum održavnja";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            this.Datum.Width = 120;
            // 
            // VrstaAktivnosti
            // 
            this.VrstaAktivnosti.DataPropertyName = "Vrsta";
            this.VrstaAktivnosti.HeaderText = "Vrsta aktivnosti";
            this.VrstaAktivnosti.Name = "VrstaAktivnosti";
            this.VrstaAktivnosti.ReadOnly = true;
            this.VrstaAktivnosti.Width = 120;
            // 
            // Slika
            // 
            this.Slika.DataPropertyName = "Slika";
            this.Slika.HeaderText = "Slika";
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            // 
            // Ograničenje
            // 
            this.Ograničenje.DataPropertyName = "Ogranicenja";
            this.Ograničenje.HeaderText = "Ograničenje";
            this.Ograničenje.Name = "Ograničenje";
            this.Ograničenje.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(205, 100);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 21);
            this.comboBox1.TabIndex = 66;
            this.comboBox1.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox1_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 65;
            this.label2.Text = "Vrsta aktivnosti";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(640, 219);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 41);
            this.button1.TabIndex = 67;
            this.button1.Text = "Dodaj vrstu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(640, 390);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 41);
            this.button2.TabIndex = 68;
            this.button2.Text = "Pretraži";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(640, 332);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 43);
            this.button4.TabIndex = 70;
            this.button4.Text = "Obriši";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 73;
            this.label3.Text = "Vrijeme aktivnosti";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 71;
            this.label4.Text = "Stalna aktivnost";
            // 
            // stalna
            // 
            this.stalna.AutoSize = true;
            this.stalna.Location = new System.Drawing.Point(205, 152);
            this.stalna.Name = "stalna";
            this.stalna.Size = new System.Drawing.Size(15, 14);
            this.stalna.TabIndex = 75;
            this.stalna.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "HH:mm";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(205, 174);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(157, 20);
            this.dateTimePicker2.TabIndex = 76;
            this.dateTimePicker2.Value = new System.DateTime(2019, 8, 27, 1, 2, 0, 0);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(640, 275);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 43);
            this.button3.TabIndex = 77;
            this.button3.Text = "Uredi";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Novaaktivnost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(858, 442);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.stalna);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.dodajSlikuBtn);
            this.Controls.Add(this.slikaInput);
            this.Controls.Add(this.nazivOpremaLbl);
            this.Controls.Add(this.dodajAktivnostButton);
            this.Controls.Add(this.nazivInput);
            this.Controls.Add(this.datmLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Novaaktivnost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova aktivnost";
            this.Load += new System.EventHandler(this.Novaaktivnost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button dodajSlikuBtn;
        private System.Windows.Forms.TextBox slikaInput;
        private System.Windows.Forms.Label nazivOpremaLbl;
        private System.Windows.Forms.Button dodajAktivnostButton;
        private System.Windows.Forms.TextBox nazivInput;
        private System.Windows.Forms.Label datmLbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckBox stalna;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn AktivnostID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaAktivnosti;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ograničenje;
        private System.Windows.Forms.Button button3;
    }
}