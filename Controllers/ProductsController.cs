using Hunerli.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Hunerli.Controllers
{
    using App_Classes;
    [Authorize]
    public class ProductsController : Controller
      {    
        HUNERLICONTEXT ctx=new HUNERLICONTEXT();
  
        // GET: Products
        public ActionResult Index()
        {
            List<Products> products = ctx.Products.ToList();
            return View(products);
        }

        public ActionResult ProductsAdd()
        {
            ViewBag.Seller = ctx.Seller.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult AddProducts(Products u)
        {
            ctx.Products.Add(u);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }

        //public ActionResult DeleteProducts(int id)
        //{
        //    Products u = ctx.Products.FirstOrDefault(x => x.ProductID == id);
        //    return View(u);
        //}
        //[HttpPost]
        //public ActionResult DeleteProducts(Products u)
        //{
        //    Products urn = ctx.Products.FirstOrDefault(x => x.ProductID == u.ProductID);
        //    ctx.Products.Remove(urn);
        //    ctx.SaveChanges();
        //    return RedirectToAction("Index");

        //}
        [HttpPost]
        public void  ProductsDelete(int id)
        {
            Products u = ctx.Products.FirstOrDefault(x => x.ProductID == id);
            ctx.Products.Remove(u);
            
            ctx.SaveChanges();
        }

        public ActionResult ProductsDetail()
        {
            int id = Convert.ToInt32(Request.QueryString["id"].ToString());
            string name = Request.QueryString["name"].ToString();

            Products p = ctx.Products.FirstOrDefault(x => x.ProductID == id);

            return View(p);

        }

        [HttpPost]
      public void BasketThrow(int id)
        {
            Basket b;
            if(Session["OnlineBasket"]==null)
            {
                b = new Basket();
 }
            else {
                b = (Basket)Session["OnlineBasket"];
            }
            Products p = ctx.Products.FirstOrDefault(x => x.ProductID == id);
            b.Products.Add(p);
            Session["OnlineBasket"] = b;



        }
    }
}