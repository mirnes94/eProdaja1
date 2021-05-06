using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eProdaja.WebAPI.Database
{
    public partial class Narudzbe
    {
        public Narudzbe()
        {
            Izlazi = new HashSet<Izlazi>();
            NarudzbaStavke = new HashSet<NarudzbaStavke>();
        }

        public int NarudzbaId { get; set; }
        public string BrojNarudzbe { get; set; }
        public int KupacId { get; set; }
        public DateTime Datum { get; set; }
        public bool Status { get; set; }
        public bool? Otkazano { get; set; }

        public virtual Kupci Kupac { get; set; }
        public virtual ICollection<Izlazi> Izlazi { get; set; }
        public virtual ICollection<NarudzbaStavke> NarudzbaStavke { get; set; }
    }
}
