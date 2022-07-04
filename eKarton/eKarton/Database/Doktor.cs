using System;
using System.Collections.Generic;

#nullable disable

namespace eKarton.Database
{
    public partial class Doktor
    {
        public Doktor()
        {
            DodjeljenDoktors = new HashSet<DodjeljenDoktor>();
            OcjenaDoktors = new HashSet<OcjenaDoktor>();
            Pregleds = new HashSet<Pregled>();
            Termins = new HashSet<Termin>();
            Uputnicas = new HashSet<Uputnica>();
            Uvjerenjes = new HashSet<Uvjerenje>();
        }

        public int DoktorId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Spol { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Grad { get; set; }
        public decimal Jmbg { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public int? OdjelId { get; set; }

        public virtual Odjel Odjel { get; set; }
        public virtual ICollection<DodjeljenDoktor> DodjeljenDoktors { get; set; }
        public virtual ICollection<OcjenaDoktor> OcjenaDoktors { get; set; }
        public virtual ICollection<Pregled> Pregleds { get; set; }
        public virtual ICollection<Termin> Termins { get; set; }
        public virtual ICollection<Uputnica> Uputnicas { get; set; }
        public virtual ICollection<Uvjerenje> Uvjerenjes { get; set; }
    }
}
