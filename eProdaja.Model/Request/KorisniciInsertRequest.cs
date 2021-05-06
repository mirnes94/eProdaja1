using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eProdaja.Model.Request
{
    public class KorisniciInsertRequest
    {
        [Required]
        [MinLength(4)]
        public string Ime { get; set; }
        [Required]
        [MinLength(4)]
        public string Prezime { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Telefon { get; set; }
        [Required]
        [MinLength(4)]
        public string KorisnickoIme { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }

        public List<int> Uloge { get; set; } = new List<int>();

    }
}
