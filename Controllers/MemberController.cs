using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hunerli.Controllers
{
    using App_Classes;
    using System.Web.Security;
    [Authorize]
    public class MemberController : Controller
    {
        // GET: Member
        [AllowAnonymous]
   public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(Users u,string RememberMe)
        {
        bool result=    Membership.ValidateUser(u.UsersName, u.UsersPsw);
            if (result)
            {
                if(RememberMe == "on")
                FormsAuthentication.RedirectFromLoginPage(u.UsersName,true);
                else
                    FormsAuthentication.RedirectFromLoginPage(u.UsersName,false);
               return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Mesaj = "Kullanıcı Adı Veya Parola Hatalı!";
                return View();
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
        [AllowAnonymous]
        public ActionResult ForgotPsw()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult ForgotPsw(Users u)
        {
            MembershipUser ms = Membership.GetUser(u.UsersName);

             if(ms.PasswordQuestion==u.PrivateQuestion)
            {
                string pwd = ms.ResetPassword(u.PrivateAnswer);
                ms.ChangePassword(pwd, u.UsersPsw);
                return RedirectToAction("Login");
            }
             else
            {
                ViewBag.Mesaj = "Girilen Bilgiler Yanlıştır";
                return View();
            }
        }
        }
    }

