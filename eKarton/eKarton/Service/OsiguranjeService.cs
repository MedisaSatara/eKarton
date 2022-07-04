using AutoMapper;
using eKarton.Database;
using eKarton.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.Service
{
    public class OsiguranjeService : IOsiguranje
    {
        private readonly IMapper _mapper;
        private readonly eKartonContext Context;

        public OsiguranjeService(eKartonContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }
        public List<Model.Osiguranje> Get()
        {
            return Context.Osiguranjes.ToList().Select(x => _mapper.Map<Model.Osiguranje>(x)).ToList();

        }

        public Model.Osiguranje GetById(int id)
        {
            var entity = Context.Osiguranjes.Find(id);

            return _mapper.Map<Model.Osiguranje>(entity);
        }
    }
}
