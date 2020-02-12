using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hunerli.App_Classes
{
    using Models;
    public class Basket
    {
        public  List<Products> products = new List<Products>();

        public  List<Products> Products
        {
            get { return products; }
            set { products = value; }
        }

    }
}