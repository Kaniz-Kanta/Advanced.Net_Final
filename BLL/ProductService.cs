using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace BLL
{
    public class ProductService
    {
        public static List<ProductModel> GetAll()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductModel>());
            var mapper = config.CreateMapper();
            var data = mapper.Map<List<ProductModel>>(DataAccessFactory.ProductDataAccess().Get());
            return data;
        }
        public static List<string> GetNames()
        {
            var data = (from e in DataAccessFactory.ProductDataAccess().Get()
                        select e.ProductName).ToList();
            //data = ProductRepo.GetAll().Select(e => e.ProductName).ToList();
            return data;
        }
        public static void Edit()
        {

        }
        public static void Delete()
        {

        }
    }
}
