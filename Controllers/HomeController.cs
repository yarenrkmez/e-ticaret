using Hunerli.App_Classes;
using Hunerli.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hunerli.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.OnlineUsers = HttpContext.Application["OnlineUsers"];
            ViewBag.TotalUsers = HttpContext.Application["TotalUsers"];
            return View();
        }
        public ActionResult CookieA()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CookieA(string CookieName,string CookieValue)
        {
            HttpCookie ck = new HttpCookie(CookieName);
            ck.Value = CookieValue;
            ck.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(ck);
            return View();
        }
        public ActionResult CookieR()
        {
           string v =Request.Cookies["Grup Kodu"].Value;
            ViewBag.Cerez = v;
                return View();
        }
        public ActionResult MyBasket()
        {
            List<Products> products = new List<Products>();
            if(Session["OnlineBasket"]!=null)
            {
                Basket b = (Basket)Session["OnlineBasket"];
                products = b.Products;
            }
            return View(products);
        }
    }
}