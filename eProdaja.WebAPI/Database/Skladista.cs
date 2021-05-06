using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eProdaja.WebAPI.Database
{
    public partial class Skladista
    {
        public Skladista()
        {
            Izlazi = new HashSet<Izlazi>();
            Ulazi = new HashSet<Ulazi>();
        }

        public int SkladisteId { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Opis { get; set; }

        public virtual ICollection<Izlazi> Izlazi { get; set; }
        public virtual ICollection<Ulazi> Ulazi { get; set; }
    }
}
