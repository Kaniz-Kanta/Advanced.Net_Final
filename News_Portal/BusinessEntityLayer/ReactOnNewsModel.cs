using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntityLayer
{
    class ReactOnNewsModel
    {
        public int ID { get; set; }
        public string React { get; set; }
        public int NewsId { get; set; }
        public string UserId { get; set; }
    }
}
