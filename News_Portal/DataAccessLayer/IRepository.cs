using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IRepository<T,Id,S>
    {
        void Add(T entity);
        List<T> Get();
        T Get(Id id);
        void Edit(T entity);
        void Delete(Id id);
    }
}
