using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eProdaja.Model.Request
{
    public class ProizvodInsertUpdateRequest
    {
        [Required (AllowEmptyStrings =false)]
        public string Naziv { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Sifra { get; set; }
        [Range(0,double.MaxValue)]
        public decimal Cijena { get; set; }
        [Required]
        public int VrstaId { get; set; }
        [Required]
        public int JedinicaMjereId { get; set; }
        [Required]
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }

        public bool? Status { get; set; }
    }
}
