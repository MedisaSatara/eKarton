using System;
using System.Collections.Generic;

#nullable disable

namespace eKarton.Database
{
    public partial class TehnickaPodrska
    {
        public int PodrskaId { get; set; }
        public string Vrsta { get; set; }
        public string NazivProblema { get; set; }
        public string OpisProblema { get; set; }
        public bool? Izvrseno { get; set; }
        public string Telefon { get; set; }
        public int? KorisnikId { get; set; }
        public int? AdminId { get; set; }

        public virtual Administrator Admin { get; set; }
        public virtual Korisnik Korisnik { get; set; }
    }
}
