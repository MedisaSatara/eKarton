using System;
using System.Collections.Generic;

#nullable disable

namespace eKarton.Database
{
    public partial class Bolnica
    {
        public Bolnica()
        {
            Odjels = new HashSet<Odjel>();
        }

        public int BolnicaId { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Odjel> Odjels { get; set; }
    }
}
