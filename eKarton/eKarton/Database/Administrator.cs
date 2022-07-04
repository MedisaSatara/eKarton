using System;
using System.Collections.Generic;

#nullable disable

namespace eKarton.Database
{
    public partial class Administrator
    {
        public Administrator()
        {
            TehnickaPodrskas = new HashSet<TehnickaPodrska>();
        }

        public int AdminId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Prebivaliste { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Lozinka { get; set; }

        public virtual ICollection<TehnickaPodrska> TehnickaPodrskas { get; set; }
    }
}
