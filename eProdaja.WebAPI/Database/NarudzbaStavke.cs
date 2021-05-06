using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eProdaja.WebAPI.Database
{
    public partial class NarudzbaStavke
    {
        public int NarudzbaStavkaId { get; set; }
        public int NarudzbaId { get; set; }
        public int ProizvodId { get; set; }
        public int Kolicina { get; set; }

        public virtual Narudzbe Narudzba { get; set; }
        public virtual Proizvodi Proizvod { get; set; }
    }
}
