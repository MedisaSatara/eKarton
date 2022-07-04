using System;
using System.Collections.Generic;

#nullable disable

namespace eKarton.Database
{
    public partial class Nalaz
    {
        public int NalazId { get; set; }
        public string LicnaAnamneza { get; set; }
        public string PorodicnaAnamneza { get; set; }
        public string RadnaAnamenaza { get; set; }
        public DateTime Datum { get; set; }
        public int? PacijentId { get; set; }

        public virtual Pacijent Pacijent { get; set; }
    }
}
