using System;
using System.Collections.Generic;

#nullable disable

namespace eKarton.Database
{
    public partial class Vakcinacija
    {
        public int VakcinacijeId { get; set; }
        public int Doza { get; set; }
        public string Tip { get; set; }
        public int SerijskiBroj { get; set; }
        public DateTime Datum { get; set; }
        public string Lokacija { get; set; }
        public int? PacijentId { get; set; }

        public virtual Pacijent Pacijent { get; set; }
    }
}
