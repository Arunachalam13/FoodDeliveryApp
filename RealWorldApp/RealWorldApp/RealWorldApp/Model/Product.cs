﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RealWorldApp.Model
{
    public class Product
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string detail { get; set; }
        public string imageUrl { get; set; }
        public double price { get; set; }
        public bool isPopularProduct { get; set; }
        public int categoryId { get; set; }
        public object imageArray { get; set; }
    }
}
