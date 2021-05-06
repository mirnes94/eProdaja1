using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eProdaja.WebAPI.Database
{
    public partial class VrsteProizvoda
    {
        public VrsteProizvoda()
        {
            Proizvodi = new HashSet<Proizvodi>();
        }

        public int VrstaId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Proizvodi> Proizvodi { get; set; }
    }
}
