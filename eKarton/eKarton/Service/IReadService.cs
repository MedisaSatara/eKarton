using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.Service
{
    public interface IReadService<T> where T: class
    {
        public IEnumerable<T> Get();
        public T GetById(int id);
    }
}
