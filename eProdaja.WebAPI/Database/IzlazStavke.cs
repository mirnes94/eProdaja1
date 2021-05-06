using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eProdaja.WebAPI.Database
{
    public partial class IzlazStavke
    {
        public int IzlazStavkaId { get; set; }
        public int IzlazId { get; set; }
        public int ProizvodId { get; set; }
        public int Kolicina { get; set; }
        public decimal Cijena { get; set; }
        public decimal? Popust { get; set; }

        public virtual Izlazi Izlaz { get; set; }
        public virtual Proizvodi Proizvod { get; set; }
    }
}
