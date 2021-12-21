using BusinessEntityLayer;
using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace News_Portal.Controllers
{
    public class UserController : ApiController
    {
        [Route("api/User/News/All")]
        [HttpGet]
        public List<NewsModel> GetAll()
        {
            return UsersService.GetAll();
        }
    }
}
