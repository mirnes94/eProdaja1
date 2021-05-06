using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eProdaja.WebAPI.Database
{
    public partial class Ocjene
    {
        public int OcjenaId { get; set; }
        public int ProizvodId { get; set; }
        public int KupacId { get; set; }
        public DateTime Datum { get; set; }
        public int Ocjena { get; set; }

        public virtual Kupci Kupac { get; set; }
        public virtual Proizvodi Proizvod { get; set; }
    }
}
