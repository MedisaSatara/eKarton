using eKarton.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.Service
{
    public interface IPacijent
    {
        List<Pacijent> Get();
        Pacijent GetById(int id);

    }
}
