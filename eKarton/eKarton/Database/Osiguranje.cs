using System;
using System.Collections.Generic;

#nullable disable

namespace eKarton.Database
{
    public partial class Osiguranje
    {
        public Osiguranje()
        {
            Pacijents = new HashSet<Pacijent>();
        }

        public int OsiguranjeId { get; set; }
        public string Osiguranik { get; set; }
        public DateTime Datum { get; set; }
        public bool? Vazece { get; set; }

        public virtual ICollection<Pacijent> Pacijents { get; set; }
    }
}
