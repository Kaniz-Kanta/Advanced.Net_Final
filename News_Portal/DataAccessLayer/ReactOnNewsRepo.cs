using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class ReactOnNewsRepo : IRepository<ReactOnNew, int,string>
    {
        Entities db;
        public ReactOnNewsRepo(Entities db)
        {
            this.db = db;
        }
        public void Add(ReactOnNew entity)
        {
            db.ReactOnNews.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var data = db.ReactOnNews.FirstOrDefault(e => e.ID == id);
            db.ReactOnNews.Remove(data);
            db.SaveChanges();
        }

        public void Edit(ReactOnNew entity)
        {
            var pr = db.ReactOnNews.FirstOrDefault(e => e.ID == entity.ID);
            db.Entry(pr).CurrentValues.SetValues(entity);
            db.SaveChanges();
        }

        public List<ReactOnNew> Get()
        {
            return db.ReactOnNews.ToList();
        }

        public ReactOnNew Get(int id)
        {
            return db.ReactOnNews.FirstOrDefault(e => e.NewsId == id);
        }
    }
}
