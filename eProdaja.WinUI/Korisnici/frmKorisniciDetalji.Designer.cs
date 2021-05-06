namespace eProdaja.WinUI.Korisnici
{
    partial class frmKorisniciDetalji
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.Ime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Telefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.KorisnickoIme = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Potvrda = new System.Windows.Forms.Label();
            this.txtPasswordPotvrda = new System.Windows.Forms.TextBox();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.clbRole = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(37, 36);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(371, 20);
            this.txtIme.TabIndex = 0;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // Ime
            // 
            this.Ime.AutoSize = true;
            this.Ime.Location = new System.Drawing.Point(37, 17);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(24, 13);
            this.Ime.TabIndex = 3;
            this.Ime.Text = "Ime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Prezime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(37, 88);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(371, 20);
            this.txtPrezime.TabIndex = 4;
            this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime_Validating);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(37, 117);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 7;
            this.Email.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(37, 136);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(371, 20);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // Telefon
            // 
            this.Telefon.AutoSize = true;
            this.Telefon.Location = new System.Drawing.Point(37, 159);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(43, 13);
            this.Telefon.TabIndex = 9;
            this.Telefon.Text = "Telefon";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(37, 178);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(371, 20);
            this.txtTelefon.TabIndex = 8;
            this.txtTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelefon_Validating);
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.AutoSize = true;
            this.KorisnickoIme.Location = new System.Drawing.Point(37, 214);
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.Size = new System.Drawing.Size(75, 13);
            this.KorisnickoIme.TabIndex = 11;
            this.KorisnickoIme.Text = "Korisnicko ime";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(37, 233);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(371, 20);
            this.txtKorisnickoIme.TabIndex = 10;
            this.txtKorisnickoIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtKorisnickoIme_Validating);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(37, 275);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 13;
            this.Password.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(37, 294);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(163, 20);
            this.txtPassword.TabIndex = 12;
            // 
            // Potvrda
            // 
            this.Potvrda.AutoSize = true;
            this.Potvrda.Location = new System.Drawing.Point(244, 275);
            this.Potvrda.Name = "Potvrda";
            this.Potvrda.Size = new System.Drawing.Size(44, 13);
            this.Potvrda.TabIndex = 15;
            this.Potvrda.Text = "Potvrda";
            // 
            // txtPasswordPotvrda
            // 
            this.txtPasswordPotvrda.Location = new System.Drawing.Point(244, 294);
            this.txtPasswordPotvrda.Name = "txtPasswordPotvrda";
            this.txtPasswordPotvrda.PasswordChar = '*';
            this.txtPasswordPotvrda.Size = new System.Drawing.Size(163, 20);
            this.txtPasswordPotvrda.TabIndex = 14;
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(275, 447);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(132, 23);
            this.btnSnimi.TabIndex = 16;
            this.btnSnimi.Text = "Sačuvaj";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // clbRole
            // 
            this.clbRole.FormattingEnabled = true;
            this.clbRole.Location = new System.Drawing.Point(37, 341);
            this.clbRole.Name = "clbRole";
            this.clbRole.Size = new System.Drawing.Size(370, 79);
            this.clbRole.TabIndex = 17;
            // 
            // frmKorisniciDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 482);
            this.Controls.Add(this.clbRole);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.Potvrda);
            this.Controls.Add(this.txtPasswordPotvrda);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.KorisnickoIme);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.txtIme);
            this.Name = "frmKorisniciDetalji";
            this.Text = "frmKorisniciDetalji";
            this.Load += new System.EventHandler(this.frmKorisniciDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label Ime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label Telefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label KorisnickoIme;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label Potvrda;
        private System.Windows.Forms.TextBox txtPasswordPotvrda;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckedListBox clbRole;
    }
}