using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepository<T, Id>
    {
        void Add(T entity);
        List<T> Get();
        T Get(Id id);
        void Edit(T entity);
        void Delete(Id id);
    }
}
