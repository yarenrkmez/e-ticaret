using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Hunerli.Controllers
{
    [Authorize]
    public class RoleController : Controller
    {
        // GET: Role
        public ActionResult Index()
        {
            List<string>role =Roles.GetAllRoles().ToList();
            return View(role);
        }
        public ActionResult RoleAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RoleAdd(string RoleName)
        {
            Roles.CreateRole(RoleName);
            return RedirectToAction("Index");
        }
    }
}