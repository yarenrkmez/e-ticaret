using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hunerli.Models
{
    public class Products
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductCast { get; set; }
        public Boolean exisT { get; set; }
        public int ProductStocks { get; set; }
        public int SellerID { get; set; }
    }
}