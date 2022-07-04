using System;
using System.Collections.Generic;

#nullable disable

namespace eKarton.Database
{
    public partial class Korisnik
    {
        public Korisnik()
        {
            TehnickaPodrskas = new HashSet<TehnickaPodrska>();
        }

        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public decimal BrojKartona { get; set; }
        public int? PacijentId { get; set; }

        public virtual Pacijent Pacijent { get; set; }
        public virtual ICollection<TehnickaPodrska> TehnickaPodrskas { get; set; }
    }
}
