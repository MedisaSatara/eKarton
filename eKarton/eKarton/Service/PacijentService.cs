using AutoMapper;
using eKarton.Database;
using eKarton.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.Service
{
    public class PacijentService : IPacijent
    {
        private readonly IMapper _mapper;
        private readonly eKartonContext Context;

        public PacijentService(eKartonContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }
        public List<Model.Pacijent> Get()
        {
            return Context.Pacijents.ToList().Select(x=>_mapper.Map<Model.Pacijent>(x)).ToList();

        }

        public Model.Pacijent GetById(int id)
        {
            var entity = Context.Pacijents.Find(id);

            return _mapper.Map<Model.Pacijent>(entity);
        }
    }
}
