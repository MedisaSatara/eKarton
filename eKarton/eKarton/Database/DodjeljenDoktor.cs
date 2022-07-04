using System;
using System.Collections.Generic;

#nullable disable

namespace eKarton.Database
{
    public partial class DodjeljenDoktor
    {
        public int PacijentId { get; set; }
        public int DoktorId { get; set; }

        public virtual Doktor Doktor { get; set; }
        public virtual Pacijent Pacijent { get; set; }
    }
}
