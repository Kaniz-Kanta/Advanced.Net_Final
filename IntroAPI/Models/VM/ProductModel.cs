﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntroAPI.Models.VM
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
    }
}