using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntityLayer
{
    public class NewsModel
    {
        public int ID { get; set; }
        public string News1 { get; set; }
        public string PostedBy { get; set; }
        public System.DateTime Date { get; set; }
        public int CategoryId { get; set; }
    }
}
