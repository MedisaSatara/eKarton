using System;
using System.Collections.Generic;

#nullable disable

namespace eKarton.Database
{
    public partial class Uvjerenje
    {
        public int UvjerenjeId { get; set; }
        public DateTime Datum { get; set; }
        public string RadnaSposobnost { get; set; }
        public string Invaliditet { get; set; }
        public int? PacijentId { get; set; }
        public int? DoktorId { get; set; }

        public virtual Doktor Doktor { get; set; }
        public virtual Pacijent Pacijent { get; set; }
    }
}
