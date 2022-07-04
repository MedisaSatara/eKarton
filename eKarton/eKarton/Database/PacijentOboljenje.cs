using System;
using System.Collections.Generic;

#nullable disable

namespace eKarton.Database
{
    public partial class PacijentOboljenje
    {
        public int OboljenjeId { get; set; }
        public int PacijentId { get; set; }
        public string NesposobanZaRad { get; set; }
        public DateTime? NesposobanZaRadDo { get; set; }

        public virtual Oboljenje Oboljenje { get; set; }
        public virtual Pacijent Pacijent { get; set; }
    }
}
