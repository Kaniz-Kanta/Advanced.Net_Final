using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class CommentsOnNewsRepo : IRepository<CommentOnNew, int,string>
    {
        Entities db;
        public CommentsOnNewsRepo(Entities db)
        {
            this.db = db;
        }
        public void Add(CommentOnNew entity)
        {
            db.CommentOnNews.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var data = db.CommentOnNews.FirstOrDefault(e => e.ID == id);
            db.CommentOnNews.Remove(data);
            db.SaveChanges();
        }

        public void Edit(CommentOnNew entity)
        {
            var pr = db.CommentOnNews.FirstOrDefault(e => e.ID == entity.ID);
            db.Entry(pr).CurrentValues.SetValues(entity);
            db.SaveChanges();
        }

        public List<CommentOnNew> Get()
        {
            return db.CommentOnNews.ToList();
        }

        public CommentOnNew Get(int id)
        {
            return db.CommentOnNews.FirstOrDefault(e => e.NewsId == id);
        }
    }
}
