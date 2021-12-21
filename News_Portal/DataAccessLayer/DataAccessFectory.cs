using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataAccessFectory
    {
        static Entities db;
        static DataAccessFectory()
        {
            db = new Entities();
        }
        public static IRepository<News, int, string> NewsDataAccess()
        {
            return new NewsRepo(db);
        }
        public static IRepository<User, int, string> UserDataAccess()
        {
            return new UserRepo(db);
        }
        public static IRepository<ReactOnNew, int, string> ReactOnNewsDataAccess()
        {
            return new ReactOnNewsRepo(db);
        }
        public static IRepository<Category, int, string> CategoryDataAccess()
        {
            return new CategoriesRepo(db);
        }
        public static IRepository<CommentOnNew, int, string> CommentOnNewsDataAccess()
        {
            return new CommentsOnNewsRepo(db);
        }
    }
}
