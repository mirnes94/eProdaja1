using eProdaja.Model;
using eProdaja.Model.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eProdaja.WinUI.Proizvodi
{
    public partial class frmProizvodi : Form
    {
        private readonly APIService _vrsteProizvoda = new APIService("VrsteProizvoda");
        private readonly APIService _jediniceMjere = new APIService("JediniceMjere");
        private readonly APIService _proizvodi = new APIService("Proizvod");
        public frmProizvodi()
        {
            InitializeComponent();
       
        }

        private async void frmProizvodi_Load(object sender, EventArgs e)
        {
            await LoadVrsteProizvoda();
            await LoadJediniceMjere();
        }
        private async Task LoadVrsteProizvoda()
        {
            var result= await _vrsteProizvoda.GetById<List<VrsteProizvodaModel>>(null);

            result.Insert(0, new VrsteProizvodaModel());//da se ne ucitavaju odmah vrijednosti
            cmbVrstaProizvoda.DisplayMember = "Naziv";//vrijednost
            cmbVrstaProizvoda.ValueMember = "VrstaId";//id
            cmbVrstaProizvoda.DataSource = result;

        }
        private async Task LoadJediniceMjere()
        {
            var result = await _jediniceMjere.GetById<List<JediniceMjereModel>>(null);

            result.Insert(0, new JediniceMjereModel());
            cmbJediniceMjere.DisplayMember = "Naziv";//vrijednost
            cmbJediniceMjere.ValueMember = "JedinicaMjereId";//id
            cmbJediniceMjere.DataSource = result;

        }

        private async void cmbVrstaProizvoda_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbVrstaProizvoda.SelectedValue;
            
            if(int.TryParse(idObj.ToString(),out int id))
            {
                LoadProizvodi(id);
            }
        }
        private async Task LoadProizvodi(int vrstaId)
        {
            var result = await _proizvodi.Get<List<Model.Proizvod>>(new ProizvodSearchRequest()
            {
                VrstaId = vrstaId
            }) ;

            proizvodiGrid.DataSource = result;
        }

        ProizvodInsertUpdateRequest request = new ProizvodInsertUpdateRequest();
        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
           

            var idObj = cmbVrstaProizvoda.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int vrstaId))
            {
                request.VrstaId = vrstaId;
            }
            var idObj1 = cmbJediniceMjere.SelectedValue;

            if (int.TryParse(idObj1.ToString(), out int jedinicaMjereId))
            {
                request.JedinicaMjereId = jedinicaMjereId;
            }
            request.Naziv = txtNaziv.Text;
            request.Sifra = txtSifra.Text;
            request.Cijena = Decimal.Parse(txtCijena.Text);
            request.Status = true;


            await _proizvodi.Insert<Model.Proizvod>(request);

            MessageBox.Show("Operacija uspješna");

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
           var result= openFileDialog1.ShowDialog();

            if(result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;

                var file = File.ReadAllBytes(fileName);

                request.Slika = file;
                request.SlikaThumb = file;

                txtSlika.Text = fileName;

                Image image = Image.FromFile(fileName);

                pbSlikaProizvoda.Image = image;
            }
        }
    }
}
