using System;
using System.Collections.Generic;
using System.Text;

namespace eKarton.Model
{
    public class Pacijent
    {
        public Pacijent()
        {
        }

        public int PacijentId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Spol { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string MjestoRodjenja { get; set; }
        public decimal Jmbg { get; set; }
        public string Prebivaliste { get; set; }
        public string Telefon { get; set; }
        public string KrvnaGrupa { get; set; }
        public string RhFaktor { get; set; }
        public string HronicneBolesti { get; set; }
        public string Alergican { get; set; }
        public bool? Koagulopatije { get; set; }
        public int? OsiguranjeId { get; set; }

        public virtual Osiguranje Osiguranje { get; set; }
        /*public virtual ICollection<DodjeljenDoktor> DodjeljenDoktors { get; set; }
        public virtual ICollection<Korisnik> Korisniks { get; set; }
        public virtual ICollection<Nalaz> Nalazs { get; set; }
        public virtual ICollection<PacijentOboljenje> PacijentOboljenjes { get; set; }
        public virtual ICollection<Pregled> Pregleds { get; set; }
        public virtual ICollection<PreventivneMjere> PreventivneMjeres { get; set; }
        public virtual ICollection<SistematskiPregled> SistematskiPregleds { get; set; }
        public virtual ICollection<Termin> Termins { get; set; }
        public virtual ICollection<Uputnica> Uputnicas { get; set; }
        public virtual ICollection<Uvjerenje> Uvjerenjes { get; set; }
        public virtual ICollection<Vakcinacija> Vakcinacijas { get; set; }*/
    }
}
