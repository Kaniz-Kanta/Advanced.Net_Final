using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TierApplication.Controllers
{
    public class ProductController : ApiController
    {
        [Route("api/product/All")]
        [HttpGet]
        public List<ProductModel> GetAll()
        {
            return ProductService.GetAll();
        }
        [Route("api/product/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return ProductService.GetNames();
        }
    }
}
