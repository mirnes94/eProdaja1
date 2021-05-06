﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using Flurl;
using eProdaja.Model;
using eProdaja.Model.Request;

namespace eProdaja.WinUI.Korisnici
{
    public partial class frmKorisnici : Form
    {
        private readonly APIService _apiService = new APIService("korisnici");
        public frmKorisnici()
        {
            InitializeComponent();
        }


        private async void btnPrikazi_Click(object sender, EventArgs e)
        {

            var search = new KorisniciSearchRequest()
            {
                Ime=txtPretraga.Text
            };
            var result = await _apiService.Get<List<KorisniciModel>>(search);
            dgvKorisnici.AutoGenerateColumns = false;
            dgvKorisnici.DataSource = result;

        }


        private void dgvKorisnici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvKorisnici.SelectedRows[0].Cells[0].Value;

            frmKorisniciDetalji frm = new frmKorisniciDetalji(int.Parse(id.ToString()));

            frm.Show();
        }
    }
}
