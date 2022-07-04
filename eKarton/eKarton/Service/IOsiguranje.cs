using eKarton.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.Service
{
    public interface IOsiguranje
    {
        List<Osiguranje> Get();
        Osiguranje GetById(int id);
    }
}
