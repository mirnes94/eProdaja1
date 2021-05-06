﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eProdaja.WebAPI.Database
{
    public partial class Ulazi
    {
        public Ulazi()
        {
            UlazStavke = new HashSet<UlazStavke>();
        }

        public int UlazId { get; set; }
        public string BrojFakture { get; set; }
        public DateTime Datum { get; set; }
        public decimal IznosRacuna { get; set; }
        public decimal Pdv { get; set; }
        public string Napomena { get; set; }
        public int SkladisteId { get; set; }
        public int KorisnikId { get; set; }
        public int DobavljacId { get; set; }

        public virtual Dobavljaci Dobavljac { get; set; }
        public virtual Korisnici Korisnik { get; set; }
        public virtual Skladista Skladiste { get; set; }
        public virtual ICollection<UlazStavke> UlazStavke { get; set; }
    }
}
