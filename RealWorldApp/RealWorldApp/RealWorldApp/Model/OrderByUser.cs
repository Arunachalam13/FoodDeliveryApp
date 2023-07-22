using System;
using System.Collections.Generic;
using System.Text;

namespace RealWorldApp.Model
{
    public class OrderByUser
    {
        public int id { get; set; }
        public string fullname { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string orderTotal { get; set; }
        public DateTime orderPlaced { get; set; }
        public bool isOrderCompleted { get; set; }
        public int userId { get; set; }
        public object orderDetails { get; set; }
    }
}
