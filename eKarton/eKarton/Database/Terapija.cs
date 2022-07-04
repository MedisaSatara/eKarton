using System;
using System.Collections.Generic;

#nullable disable

namespace eKarton.Database
{
    public partial class Terapija
    {
        public Terapija()
        {
            Pregleds = new HashSet<Pregled>();
        }

        public int TerapijaId { get; set; }
        public string Dijagnoza { get; set; }
        public string NazivLijeka { get; set; }
        public string Uputa { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumKraja { get; set; }
        public string Podjetnik { get; set; }
        public TimeSpan? Vrijeme { get; set; }

        public virtual ICollection<Pregled> Pregleds { get; set; }
    }
}
