using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntityLayer
{
    class CommentOnNewsModel
    {
        public int ID { get; set; }
        public string Comments { get; set; }
        public int NewsId { get; set; }
        public string UserId { get; set; }
    }
}
