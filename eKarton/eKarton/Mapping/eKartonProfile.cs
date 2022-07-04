using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.Mapping
{
    public class eKartonProfile:Profile
    {
        public eKartonProfile()
        {
            CreateMap<Database.Pacijent, Model.Pacijent>();
            CreateMap<Database.Osiguranje, Model.Osiguranje>();


        }
    }
}
