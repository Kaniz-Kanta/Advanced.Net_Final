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
    public class AdminController : ApiController
    {
        [Route("api/Admin/News/Add/")]
        [HttpPost]
        public void Add(NewsModel n)
        {
            AdminService.InsertNews(n);
        }

        [Route("api/Admin/News/Edit/")]
        [HttpPost]
        public void Edit(NewsModel n)
        {
            AdminService.UpdateNews(n);
        }

        [Route("api/Admin/News/Delete/{id}")]
        [HttpPost]
        public void Delete(int id)
        {
            AdminService.DeleteNews(id);
        }

        [Route("api/Admin/News/{id}")]
        [HttpGet]
        public NewsModel News(int id)
        {
            return AdminService.GetNews(id);
        }

        [Route("api/Admin/News/Category/Add/")]
        [HttpPost]
        public void AddCategory(CategoryModel n)
        {
            AdminService.InsertCategory(n);
        }

        [Route("api/Admin/News/Category/Edit/")]
        [HttpPost]
        public void EditCategory(CategoryModel n)
        {
            AdminService.UpdateCategory(n);
        }

        [Route("api/Admin/News/Category/Delete/{id}")]
        [HttpPost]
        public void DeleteCategory(int id)
        {
            AdminService.DeleteCategory(id);
        }

        [Route("api/Admin/News/Category/{id}")]
        [HttpGet]
        public CategoryModel GetCategory(int id)
        {
            return AdminService.GetCategory(id);
        }

        [Route("api/Admin/News/ByCategory/{cat}")]
        [HttpGet]
        public List<NewsModel> GetNewsByCategory(string cat)
        {
           return  AdminService.GetNewsByCategory(cat);
        }

        [Route("api/Admin/News/ByCategory/{date}")]
        [HttpGet]
        public List<NewsModel> GetNewsByDate(string date)
        {
            return AdminService.GetNewsByDate(date);
        }
    }
}
