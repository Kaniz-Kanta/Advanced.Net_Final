using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;

namespace BLL
{
    class OrderService
    {
        public List<OrderModel> GetAllOrder()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Order, OrderModel>());
            var mapper = config.CreateMapper();
            var data = mapper.Map<List<OrderModel>>(DataAccessFactory.OrderDataAccess().Get());
            return data;
        }
    }
}
