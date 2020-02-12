using Hunerli.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hunerli.Controllers
{
    [Authorize]
    public class SellerController : Controller
    {
        // GET: Seller
        HUNERLICONTEXT ctx = new HUNERLICONTEXT();
        public ActionResult Index()
        {
            List<Seller> seller = ctx.Seller.ToList();
            return View(seller);
        }

        public ActionResult AddSeller()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSeller(Seller s)
        {
            ctx.Seller.Add(s);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}