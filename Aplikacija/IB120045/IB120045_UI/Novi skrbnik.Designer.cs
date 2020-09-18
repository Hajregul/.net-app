namespace IB120045_UI
{
    partial class Novi_skrbnik
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.adresalInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.telefonInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.prezimeInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.imeInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Unos = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(173, 259);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(172, 49);
            this.checkedListBox1.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(51, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Spol";
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(173, 218);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(172, 20);
            this.emailInput.TabIndex = 25;
            this.emailInput.Validating += new System.ComponentModel.CancelEventHandler(this.emailInput_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Datum rođenja";
            // 
            // adresalInput
            // 
            this.adresalInput.Location = new System.Drawing.Point(173, 180);
            this.adresalInput.Name = "adresalInput";
            this.adresalInput.Size = new System.Drawing.Size(172, 20);
            this.adresalInput.TabIndex = 23;
            this.adresalInput.Validating += new System.ComponentModel.CancelEventHandler(this.adresalInput_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Adresa";
            // 
            // telefonInput
            // 
            this.telefonInput.Location = new System.Drawing.Point(173, 144);
            this.telefonInput.Name = "telefonInput";
            this.telefonInput.Size = new System.Drawing.Size(172, 20);
            this.telefonInput.TabIndex = 21;
            this.telefonInput.Validating += new System.ComponentModel.CancelEventHandler(this.telefonInput_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "E-mail";
            // 
            // prezimeInput
            // 
            this.prezimeInput.Location = new System.Drawing.Point(173, 76);
            this.prezimeInput.Name = "prezimeInput";
            this.prezimeInput.Size = new System.Drawing.Size(172, 20);
            this.prezimeInput.TabIndex = 17;
            this.prezimeInput.Validating += new System.ComponentModel.CancelEventHandler(this.prezimeInput_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Prezime";
            // 
            // imeInput
            // 
            this.imeInput.Location = new System.Drawing.Point(173, 44);
            this.imeInput.Name = "imeInput";
            this.imeInput.Size = new System.Drawing.Size(172, 20);
            this.imeInput.TabIndex = 15;
            this.imeInput.Validating += new System.ComponentModel.CancelEventHandler(this.imeInput_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ime";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(51, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 37);
            this.button1.TabIndex = 28;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Unos
            // 
            this.Unos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Unos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unos.Location = new System.Drawing.Point(173, 336);
            this.Unos.Name = "Unos";
            this.Unos.Size = new System.Drawing.Size(172, 37);
            this.Unos.TabIndex = 29;
            this.Unos.Text = "Unos";
            this.Unos.UseVisualStyleBackColor = false;
            this.Unos.Click += new System.EventHandler(this.Unos_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(173, 111);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(172, 20);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Novi_skrbnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(389, 419);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Unos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.adresalInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.telefonInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.prezimeInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.imeInput);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Novi_skrbnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi skrbnik";
            this.Load += new System.EventHandler(this.Novi_skrbnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox adresalInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox telefonInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox prezimeInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox imeInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Unos;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}