using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class CategoriesRepo : IRepository<Category, int, string>
    {
        Entities db;
        public CategoriesRepo(Entities db)
        {
            this.db = db;
        }
        public void Add(Category entity)
        {
            db.Categories.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var data = db.Categories.FirstOrDefault(e => e.ID == id);
            db.Categories.Remove(data);
            db.SaveChanges();
        }

        public void Edit(Category entity)
        {
            var pr = db.Categories.FirstOrDefault(e => e.ID == entity.ID);
            db.Entry(pr).CurrentValues.SetValues(entity);
            db.SaveChanges();
        }

        public List<Category> Get()
        {
            return db.Categories.ToList();
        }

        public Category Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
