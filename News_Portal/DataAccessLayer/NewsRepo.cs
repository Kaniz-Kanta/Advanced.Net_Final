using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class NewsRepo : IRepository<News, int, string>
    {

        Entities db;
        public NewsRepo(Entities db)
        {
            this.db = db;
        }
        public void Add(News entity)
        {
            db.News.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var data = db.News.FirstOrDefault(e => e.ID == id);
            db.News.Remove(data);
            db.SaveChanges();
        }

        public void Edit(News entity)
        {
            var pr = db.News.FirstOrDefault(e => e.ID == entity.ID);
            db.Entry(pr).CurrentValues.SetValues(entity);
            db.SaveChanges();
        }

        public List<News> Get()
        {
            return db.News.ToList();
        }

        public News Get(int id)
        {
            return db.News.FirstOrDefault(e => e.ID == id);
        }
        public List<News> GetNewsByCategory(string category)
        {
            return db.News.ToList();
        }

        public List<News> GetNewsByDate(string date)
        {
            return db.News.Where(c => c.Date.Contains(date)).ToList();
        }
    }
}
