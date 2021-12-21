using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class OrderRepo : IRepository<Order, int>
    {
        Entities db;
        public OrderRepo(Entities db)
        {
            this.db = db;
        }
        public void Add(Order entity)
        {
            db.Orders.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var data = db.Orders.FirstOrDefault(e => e.Id == id);
            db.Orders.Remove(data);
            db.SaveChanges();
        }

        public void Edit(Order entity)
        {
            var data = db.Orders.FirstOrDefault(e => e.Id == entity.Id);
            db.Entry(data).CurrentValues.SetValues(entity);
            db.SaveChanges();
        }

        public List<Order> Get()
        {
            return db.Orders.ToList();
        }

        public Order Get(int id)
        {
            return db.Orders.FirstOrDefault(e => e.Id == id);
        }
    }
}
