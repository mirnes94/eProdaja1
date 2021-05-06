using System;
using System.Collections.Generic;

namespace eProdaja.Model
{
    public class KorisniciModel
    {
        
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public bool? Status { get; set; }

        public ICollection<KorisniciUloge> KorisniciUloge { get; set; }

    }
}

