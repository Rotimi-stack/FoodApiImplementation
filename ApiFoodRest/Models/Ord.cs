using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiFoodRest.Models
{
    public class Ord
    {
        public string email { get; set; }
        public string phone { get; set; }
    }


    public class OrderGet
    { 
        public string phoneNo { get; set; }
        public string email { get; set; }
    }
}