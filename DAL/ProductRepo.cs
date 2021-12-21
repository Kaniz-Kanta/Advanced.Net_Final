using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductRepo: IRepository<Product, int>
    {
       Entities db;
        public  ProductRepo(Entities db)
        {
            this.db = db;
        }
        /*public static List<Product> GetAll()
        {
            return db.Products.ToList();
        }
        public static Product Get(int id)
        {
            return db.Products.FirstOrDefault(e => e.Id == id);
        }
        public static void Edit(Product p)
        {
           var pr=  db.Products.FirstOrDefault(e => e.Id == p.Id);
            db.Entry(pr).CurrentValues.SetValues(p);
            db.SaveChanges();
        }
        public static void Delete(int id)
        {
            var pr = db.Products.FirstOrDefault(e => e.Id == id);
            db.Products.Remove(pr);
            db.SaveChanges();
        }
       */
        public void Add(Product entity)
        {
            db.Products.Add(entity);
            db.SaveChanges();
        }

        public List<Product> Get()
        {
            return db.Products.ToList();
        }

        public Product Get(int id)
        {
            return db.Products.FirstOrDefault(e => e.Id == id);
        }

        public void Edit(Product entity)
        {
            var pr = db.Products.FirstOrDefault(e => e.Id == entity.Id);
            db.Entry(pr).CurrentValues.SetValues(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var data = db.Products.FirstOrDefault(e => e.Id == id);
            db.Products.Remove(data);
            db.SaveChanges();
        }
    }
}
