using IntroAPI.Models.VM;
using IntroAPI.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;

namespace IntroAPI.Controllers
{
    public class ProductController : ApiController
    {
        [Route("api/product/names")]
        [HttpGet]
        public List<string> PNames()
        {
            ECOMMERCEEntities db = new ECOMMERCEEntities();
            var data = (from e in db.Products
                        select e.ProductName).ToList();
            return data;
        }
        [Route("api/product/names/{id}")]
        [HttpGet]
        public string PNames(int id)
        {
            ECOMMERCEEntities db = new ECOMMERCEEntities();
            var data = (from e in db.Products
                        where e.Id == id
                        select e.ProductName).FirstOrDefault();
            return data;
        }
        public List<ProductModel> Get()
        {
            ECOMMERCEEntities db = new ECOMMERCEEntities();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductModel>());
            var mapper = config.CreateMapper();
            var data = mapper.Map<List<ProductModel>>(db.Products.ToList());
            return data;
            /*foreach(var e in db.Products)
            {
                /*var p = new ProductModel() {
                    Id = e.Id,
                };
                data.Add(p);
                data.Add(new ProductModel() { Id = e.Id, ProductName = e.ProductName, Price = e.Price, Quantity= e.Quantity, Description= e.Description });
            }
            return data;*/
        }
        public void Post(ProductModel p)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ProductModel, Product>());
            var mapper = config.CreateMapper();
            var data = mapper.Map<Product>(p);
            ECOMMERCEEntities db = new ECOMMERCEEntities();
            db.Products.Add(data);
            db.SaveChanges();

        }
    }
}
