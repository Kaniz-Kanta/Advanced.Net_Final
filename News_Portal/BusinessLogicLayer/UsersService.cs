using DataAccessLayer;
using BusinessEntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace BusinessLogicLayer
{
    public class UsersService
    {
        public static List<NewsModel> GetAll()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<News, NewsModel>());
            var mapper = config.CreateMapper();
            var data = mapper.Map<List<NewsModel>>(DataAccessFectory.NewsDataAccess().Get());
            return data;
        }

        public static List<CommentOnNewsModel> GetAllComments(int newsId)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<CommentOnNew, CommentOnNewsModel>());
            var mapper = config.CreateMapper();
            var data = mapper.Map<List<CommentOnNewsModel>>(DataAccessFectory.CommentOnNewsDataAccess.Get(newsId));
            return data;
        }

        public static List<ReactOnNewsModel> GetAllRects(int newsId)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ReactOnNew, ReactOnNewsModel>());
            var mapper = config.CreateMapper();
            var data = mapper.Map<List<ReactOnNewsModel>>(DataAccessFectory.ReactOnNewsDataAccess().Get(newsId));
            return data;
        }
    }
}
