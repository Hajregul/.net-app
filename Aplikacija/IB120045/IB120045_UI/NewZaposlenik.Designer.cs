namespace IB120045_UI
{
    partial class NewZaposlenik
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
            this.dodajButton = new System.Windows.Forms.Button();
            this.ulogeLabel = new System.Windows.Forms.Label();
            this.lozinkaLabel = new System.Windows.Forms.Label();
            this.korisnickoimeLabel = new System.Windows.Forms.Label();
            this.telefonLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.prezimeLabel = new System.Windows.Forms.Label();
            this.imeLabel = new System.Windows.Forms.Label();
            this.chbUlogeList = new System.Windows.Forms.CheckedListBox();
            this.lozinkaInput = new System.Windows.Forms.TextBox();
            this.korisnickoimeInput = new System.Windows.Forms.TextBox();
            this.telefonInput = new System.Windows.Forms.TextBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.prezimeInput = new System.Windows.Forms.TextBox();
            this.imeInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adresaInput = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dodajButton
            // 
            this.dodajButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dodajButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajButton.Location = new System.Drawing.Point(147, 423);
            this.dodajButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(208, 37);
            this.dodajButton.TabIndex = 29;
            this.dodajButton.Text = "Dodaj korisnika";
            this.dodajButton.UseVisualStyleBackColor = false;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // ulogeLabel
            // 
            this.ulogeLabel.AutoSize = true;
            this.ulogeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ulogeLabel.Location = new System.Drawing.Point(33, 330);
            this.ulogeLabel.Name = "ulogeLabel";
            this.ulogeLabel.Size = new System.Drawing.Size(45, 17);
            this.ulogeLabel.TabIndex = 28;
            this.ulogeLabel.Text = "Uloge";
            // 
            // lozinkaLabel
            // 
            this.lozinkaLabel.AutoSize = true;
            this.lozinkaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lozinkaLabel.Location = new System.Drawing.Point(32, 287);
            this.lozinkaLabel.Name = "lozinkaLabel";
            this.lozinkaLabel.Size = new System.Drawing.Size(57, 17);
            this.lozinkaLabel.TabIndex = 27;
            this.lozinkaLabel.Text = "Lozinka";
            // 
            // korisnickoimeLabel
            // 
            this.korisnickoimeLabel.AutoSize = true;
            this.korisnickoimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.korisnickoimeLabel.Location = new System.Drawing.Point(33, 259);
            this.korisnickoimeLabel.Name = "korisnickoimeLabel";
            this.korisnickoimeLabel.Size = new System.Drawing.Size(99, 17);
            this.korisnickoimeLabel.TabIndex = 26;
            this.korisnickoimeLabel.Text = "Korisničko Ime";
            // 
            // telefonLabel
            // 
            this.telefonLabel.AutoSize = true;
            this.telefonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonLabel.Location = new System.Drawing.Point(32, 156);
            this.telefonLabel.Name = "telefonLabel";
            this.telefonLabel.Size = new System.Drawing.Size(56, 17);
            this.telefonLabel.TabIndex = 25;
            this.telefonLabel.Text = "Telefon";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(33, 212);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(47, 17);
            this.emailLabel.TabIndex = 24;
            this.emailLabel.Text = "E-mail";
            // 
            // prezimeLabel
            // 
            this.prezimeLabel.AutoSize = true;
            this.prezimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prezimeLabel.Location = new System.Drawing.Point(33, 71);
            this.prezimeLabel.Name = "prezimeLabel";
            this.prezimeLabel.Size = new System.Drawing.Size(59, 17);
            this.prezimeLabel.TabIndex = 23;
            this.prezimeLabel.Text = "Prezime";
            // 
            // imeLabel
            // 
            this.imeLabel.AutoSize = true;
            this.imeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imeLabel.Location = new System.Drawing.Point(33, 42);
            this.imeLabel.Name = "imeLabel";
            this.imeLabel.Size = new System.Drawing.Size(30, 17);
            this.imeLabel.TabIndex = 22;
            this.imeLabel.Text = "Ime";
            // 
            // chbUlogeList
            // 
            this.chbUlogeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbUlogeList.FormattingEnabled = true;
            this.chbUlogeList.Location = new System.Drawing.Point(147, 330);
            this.chbUlogeList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbUlogeList.Name = "chbUlogeList";
            this.chbUlogeList.Size = new System.Drawing.Size(208, 76);
            this.chbUlogeList.TabIndex = 21;
            // 
            // lozinkaInput
            // 
            this.lozinkaInput.Location = new System.Drawing.Point(147, 287);
            this.lozinkaInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lozinkaInput.Name = "lozinkaInput";
            this.lozinkaInput.PasswordChar = '*';
            this.lozinkaInput.Size = new System.Drawing.Size(208, 20);
            this.lozinkaInput.TabIndex = 20;
            this.lozinkaInput.Validating += new System.ComponentModel.CancelEventHandler(this.lozinkaInput_Validating);
            // 
            // korisnickoimeInput
            // 
            this.korisnickoimeInput.Location = new System.Drawing.Point(147, 258);
            this.korisnickoimeInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.korisnickoimeInput.Name = "korisnickoimeInput";
            this.korisnickoimeInput.Size = new System.Drawing.Size(208, 20);
            this.korisnickoimeInput.TabIndex = 19;
            this.korisnickoimeInput.Validating += new System.ComponentModel.CancelEventHandler(this.korisnickoimeInput_Validating);
            // 
            // telefonInput
            // 
            this.telefonInput.Location = new System.Drawing.Point(147, 156);
            this.telefonInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telefonInput.Name = "telefonInput";
            this.telefonInput.Size = new System.Drawing.Size(208, 20);
            this.telefonInput.TabIndex = 18;
            this.telefonInput.Validating += new System.ComponentModel.CancelEventHandler(this.telefonInput_Validating);
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(147, 211);
            this.emailInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(208, 20);
            this.emailInput.TabIndex = 17;
            this.emailInput.Validating += new System.ComponentModel.CancelEventHandler(this.emailInput_Validating);
            // 
            // prezimeInput
            // 
            this.prezimeInput.Location = new System.Drawing.Point(147, 68);
            this.prezimeInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prezimeInput.Name = "prezimeInput";
            this.prezimeInput.Size = new System.Drawing.Size(208, 20);
            this.prezimeInput.TabIndex = 16;
            this.prezimeInput.Validating += new System.ComponentModel.CancelEventHandler(this.prezimeInput_Validating);
            // 
            // imeInput
            // 
            this.imeInput.Location = new System.Drawing.Point(147, 37);
            this.imeInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imeInput.Name = "imeInput";
            this.imeInput.Size = new System.Drawing.Size(208, 20);
            this.imeInput.TabIndex = 15;
            this.imeInput.Validating += new System.ComponentModel.CancelEventHandler(this.imeInput_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Datum rođenja";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(147, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 20);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Adresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Spol";
            // 
            // adresaInput
            // 
            this.adresaInput.Location = new System.Drawing.Point(147, 187);
            this.adresaInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adresaInput.Name = "adresaInput";
            this.adresaInput.Size = new System.Drawing.Size(208, 20);
            this.adresaInput.TabIndex = 35;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(266, 125);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Žena";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(163, 125);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Muškarac";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // NewZaposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(390, 488);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.adresaInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.ulogeLabel);
            this.Controls.Add(this.lozinkaLabel);
            this.Controls.Add(this.korisnickoimeLabel);
            this.Controls.Add(this.telefonLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.prezimeLabel);
            this.Controls.Add(this.imeLabel);
            this.Controls.Add(this.chbUlogeList);
            this.Controls.Add(this.lozinkaInput);
            this.Controls.Add(this.korisnickoimeInput);
            this.Controls.Add(this.telefonInput);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.prezimeInput);
            this.Controls.Add(this.imeInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewZaposlenik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi zaposlenik";
            this.Load += new System.EventHandler(this.NewZaposlenik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Label ulogeLabel;
        private System.Windows.Forms.Label lozinkaLabel;
        private System.Windows.Forms.Label korisnickoimeLabel;
        private System.Windows.Forms.Label telefonLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label prezimeLabel;
        private System.Windows.Forms.Label imeLabel;
        private System.Windows.Forms.CheckedListBox chbUlogeList;
        private System.Windows.Forms.TextBox lozinkaInput;
        private System.Windows.Forms.TextBox korisnickoimeInput;
        private System.Windows.Forms.TextBox telefonInput;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox prezimeInput;
        private System.Windows.Forms.TextBox imeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox adresaInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}