using BusinessEntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class AdminService
    {
        public static void InsertNews(NewsModel n)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<News, NewsModel>());
            var mapper = config.CreateMapper();
            var data = mapper.Map<NewsModel>(n);
            DataAccessFectory.NewsDataAccess().Add(data);
        }

        public static void DeleteNews(int id)
        {
            DataAccessFectory.NewsDataAccess().Delete(id);
        }

        public static void UpdateNews(NewsModel n)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<News, NewsModel>());
            var mapper = config.CreateMapper();
            var data = mapper.Map<NewsModel>(n);
            DataAccessFectory.NewsDataAccess().Edit(data);
        }

        public static NewsModel GetNews(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<News, NewsModel>());
            var mapper = config.CreateMapper();
            var data = mapper.Map<NewsModel>(DataAccessFectory.NewsDataAccess().Get(id));
            return data;
        }

        public static List<NewsModel> GetAllNews()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<News, NewsModel>());
            var mapper = config.CreateMapper();
            var data = mapper.Map<List<NewsModel>>(DataAccessFectory.NewsDataAccess().Get());
            return data;
        }

        public static void InsertCategory(CategoryModel nc)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Category, CategoryModel>());
            var mapper = config.CreateMapper();
            var data = mapper.Map<CategoryModel>(nc);
            DataAccessFectory.CategoryDataAccess().Add(data);
        }

        public static void DeleteCategory(int id)
        {
            DataAccessFectory.CategoryDataAccess().Delete(id);
        }

        public static void UpdateCategory(CategoryModel nc)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Category, CategoryModel>());
            var mapper = config.CreateMapper();
            var data = mapper.Map<CategoryModel>(nc);
            DataAccessFectory.CategoryDataAccess().Edit(data);
        }

        public static CategoryModel GetCategory(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Category, CategoryModel>());
            var mapper = config.CreateMapper();
            var data = mapper.Map<CategoryModel>(DataAccessFectory.CategoryDataAccess().Get(id));
            return data;
        }

        public static List<CategoryModel> GetAllCategory()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Category, CategoryModel>());
            var mapper = config.CreateMapper();
            var data = mapper.Map<List<CategoryModel>>(DataAccessFectory.CategoryDataAccess().Get());
            return data;
        }

        public static List<NewsModel> GetNewsByCategory(string category)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<News, NewsModel>());
            var mapper = config.CreateMapper();
            var data = mapper.Map<List<NewsModel>>(DataAccessFectory.NewsDataAccess().GetByCategory(category));
            return data;
        }

        public static List<NewsModel> GetNewsByDate(string date)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<News, NewsModel>());
            var mapper = config.CreateMapper();
            var data = mapper.Map<List<NewsModel>>(DataAccessFectory.NewsDataAccess().GetNewsByDate(date));
            return data;
        }
       
    }
}
