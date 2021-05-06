namespace eProdaja.WinUI.Proizvodi
{
    partial class frmProizvodi
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
            this.cmbVrstaProizvoda = new System.Windows.Forms.ComboBox();
            this.proizvodiGrid = new System.Windows.Forms.DataGridView();
            this.vrstaProizvoda = new System.Windows.Forms.Label();
            this.sifra = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.naziv = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.cijena = new System.Windows.Forms.Label();
            this.jedMjere = new System.Windows.Forms.Label();
            this.cmbJediniceMjere = new System.Windows.Forms.ComboBox();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.slika = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.pbSlikaProizvoda = new System.Windows.Forms.PictureBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaProizvoda)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbVrstaProizvoda
            // 
            this.cmbVrstaProizvoda.FormattingEnabled = true;
            this.cmbVrstaProizvoda.Location = new System.Drawing.Point(109, 22);
            this.cmbVrstaProizvoda.Name = "cmbVrstaProizvoda";
            this.cmbVrstaProizvoda.Size = new System.Drawing.Size(215, 21);
            this.cmbVrstaProizvoda.TabIndex = 0;
            this.cmbVrstaProizvoda.SelectedIndexChanged += new System.EventHandler(this.cmbVrstaProizvoda_SelectedIndexChanged);
            // 
            // proizvodiGrid
            // 
            this.proizvodiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proizvodiGrid.Location = new System.Drawing.Point(3, 288);
            this.proizvodiGrid.Name = "proizvodiGrid";
            this.proizvodiGrid.Size = new System.Drawing.Size(644, 150);
            this.proizvodiGrid.TabIndex = 1;
            // 
            // vrstaProizvoda
            // 
            this.vrstaProizvoda.AutoSize = true;
            this.vrstaProizvoda.Location = new System.Drawing.Point(20, 25);
            this.vrstaProizvoda.Name = "vrstaProizvoda";
            this.vrstaProizvoda.Size = new System.Drawing.Size(83, 13);
            this.vrstaProizvoda.TabIndex = 2;
            this.vrstaProizvoda.Text = "Vrsta proizvoda:";
            // 
            // sifra
            // 
            this.sifra.AutoSize = true;
            this.sifra.Location = new System.Drawing.Point(72, 64);
            this.sifra.Name = "sifra";
            this.sifra.Size = new System.Drawing.Size(31, 13);
            this.sifra.TabIndex = 3;
            this.sifra.Text = "Šifra:";
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(109, 61);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(215, 20);
            this.txtSifra.TabIndex = 4;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(109, 97);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(215, 20);
            this.txtNaziv.TabIndex = 6;
            // 
            // naziv
            // 
            this.naziv.AutoSize = true;
            this.naziv.Location = new System.Drawing.Point(72, 100);
            this.naziv.Name = "naziv";
            this.naziv.Size = new System.Drawing.Size(37, 13);
            this.naziv.TabIndex = 5;
            this.naziv.Text = "Naziv:";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(109, 135);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(63, 20);
            this.txtCijena.TabIndex = 8;
            // 
            // cijena
            // 
            this.cijena.AutoSize = true;
            this.cijena.Location = new System.Drawing.Point(72, 138);
            this.cijena.Name = "cijena";
            this.cijena.Size = new System.Drawing.Size(39, 13);
            this.cijena.TabIndex = 7;
            this.cijena.Text = "Cijena:";
            // 
            // jedMjere
            // 
            this.jedMjere.AutoSize = true;
            this.jedMjere.Location = new System.Drawing.Point(188, 138);
            this.jedMjere.Name = "jedMjere";
            this.jedMjere.Size = new System.Drawing.Size(58, 13);
            this.jedMjere.TabIndex = 10;
            this.jedMjere.Text = "Jed. mjere:";
            // 
            // cmbJediniceMjere
            // 
            this.cmbJediniceMjere.FormattingEnabled = true;
            this.cmbJediniceMjere.Location = new System.Drawing.Point(252, 134);
            this.cmbJediniceMjere.Name = "cmbJediniceMjere";
            this.cmbJediniceMjere.Size = new System.Drawing.Size(72, 21);
            this.cmbJediniceMjere.TabIndex = 9;
            // 
            // txtSlika
            // 
            this.txtSlika.Location = new System.Drawing.Point(109, 176);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(215, 20);
            this.txtSlika.TabIndex = 12;
            // 
            // slika
            // 
            this.slika.AutoSize = true;
            this.slika.Location = new System.Drawing.Point(72, 179);
            this.slika.Name = "slika";
            this.slika.Size = new System.Drawing.Size(33, 13);
            this.slika.TabIndex = 11;
            this.slika.Text = "Slika:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(339, 174);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 13;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // pbSlikaProizvoda
            // 
            this.pbSlikaProizvoda.Location = new System.Drawing.Point(502, 22);
            this.pbSlikaProizvoda.Name = "pbSlikaProizvoda";
            this.pbSlikaProizvoda.Size = new System.Drawing.Size(121, 133);
            this.pbSlikaProizvoda.TabIndex = 14;
            this.pbSlikaProizvoda.TabStop = false;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(538, 194);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(109, 52);
            this.btnSacuvaj.TabIndex = 15;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmProizvodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 450);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.pbSlikaProizvoda);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.slika);
            this.Controls.Add(this.jedMjere);
            this.Controls.Add(this.cmbJediniceMjere);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.cijena);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.naziv);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.sifra);
            this.Controls.Add(this.vrstaProizvoda);
            this.Controls.Add(this.proizvodiGrid);
            this.Controls.Add(this.cmbVrstaProizvoda);
            this.Name = "frmProizvodi";
            this.Text = "frmProizvodi";
            this.Load += new System.EventHandler(this.frmProizvodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaProizvoda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVrstaProizvoda;
        private System.Windows.Forms.DataGridView proizvodiGrid;
        private System.Windows.Forms.Label vrstaProizvoda;
        private System.Windows.Forms.Label sifra;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label naziv;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label cijena;
        private System.Windows.Forms.Label jedMjere;
        private System.Windows.Forms.ComboBox cmbJediniceMjere;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.Label slika;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.PictureBox pbSlikaProizvoda;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}