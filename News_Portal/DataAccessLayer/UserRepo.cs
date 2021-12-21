using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class UserRepo:IRepository<User,int,string>
    {
        Entities db;
        public UserRepo(Entities db)
        {
            this.db = db;
        }

        public void Add(User entity)
        {
            db.Users.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var data = db.Users.FirstOrDefault(e => e.ID == id);
            db.Users.Remove(data);
            db.SaveChanges();
        }

        public void Edit(User entity)
        {
            var pr = db.Users.FirstOrDefault(e => e.ID == entity.ID);
            db.Entry(pr).CurrentValues.SetValues(entity);
            db.SaveChanges();
        }

        public List<User> Get()
        {
            return db.Users.ToList();
        }

        public User Get(int id)
        {
            return db.Users.FirstOrDefault(e => e.ID == id);
        }
    }
}
