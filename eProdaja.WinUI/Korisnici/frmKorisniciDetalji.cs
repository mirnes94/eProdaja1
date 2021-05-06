using eProdaja.Model;
using eProdaja.Model.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eProdaja.WinUI.Korisnici
{
    public partial class frmKorisniciDetalji : Form
    {
        private readonly APIService _service = new APIService("korisnici");
        private readonly APIService _serviceUloge = new APIService("uloge");
        private int? _id = null;
        public frmKorisniciDetalji(int? korisnikId=null)
        {
            InitializeComponent();
            _id = korisnikId;
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {

            var uloge = clbRole.CheckedItems.Cast<Model.Uloge>().Select(x=>x.UlogaId).ToList();

            if(this.ValidateChildren())
            {
                var request = new KorisniciInsertRequest()
                {
                    Email = txtEmail.Text,
                    Ime = txtIme.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Password = txtPassword.Text,
                    PasswordConfirmation = txtPasswordPotvrda.Text,
                    Prezime = txtPrezime.Text,
                    Telefon = txtTelefon.Text,
                    Uloge = uloge
                };

                if (_id.HasValue)
                {
                    await _service.Update<KorisniciModel>((int)_id, request);
                }
                else
                {
                    await _service.Insert<KorisniciModel>(request);
                }

                MessageBox.Show("Operacija uspješna");
            }
           
        }

        private async void frmKorisniciDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var korisnik = await _service.GetById<KorisniciModel>(_id);
                txtEmail.Text = korisnik.Email;
                txtIme.Text = korisnik.Ime;
                txtKorisnickoIme.Text = korisnik.KorisnickoIme;
                txtPrezime.Text = korisnik.Prezime;
                txtTelefon.Text = korisnik.Telefon;
            }
            var uloge = await _serviceUloge.Get<List<Model.Uloge>>(null);
            clbRole.DisplayMember = "Naziv";
            clbRole.DataSource = uloge;

        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtIme.Text))
            {
                errorProvider.SetError(txtIme, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                errorProvider.SetError(txtPrezime, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPrezime, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
            }
        }

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                errorProvider.SetError(txtTelefon, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtTelefon, null);
            }
        }

        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text) && txtKorisnickoIme.Text.Length<3)
            {
                errorProvider.SetError(txtKorisnickoIme, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtKorisnickoIme, null);
            }
        }
    }
}
