using Hunerli.App_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Hunerli.Controllers
{
    [Authorize]

    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            MembershipUserCollection users=
            Membership.GetAllUsers();
            return View(users);
        }

        [AllowAnonymous]
        public ActionResult UsersAdd()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult UsersAdd(Users usr)
        {
            MembershipCreateStatus statu;
            Membership.CreateUser(usr.UsersName, usr.UsersPsw, usr.UsersEmail,usr.PrivateAnswer, usr.PrivateQuestion, true, out statu);
            string mess = "";
            switch (statu)
            {
                case MembershipCreateStatus.Success:
                    break;
                case MembershipCreateStatus.InvalidUserName:
                    mess += "Geçersiz Kullanıcı Adı";
                    break;
                case MembershipCreateStatus.InvalidPassword:
                    mess += "Hatalı parola";
                    break;
                case MembershipCreateStatus.InvalidQuestion:
                    mess += "yanlış soru";
                    break;
                case MembershipCreateStatus.InvalidAnswer:
                    mess += "Yanlış cevap";
                    break;
                case MembershipCreateStatus.InvalidEmail:
                    mess += "Email hata";
                    break;
                case MembershipCreateStatus.DuplicateUserName:
                    mess += "Kullanılmış  kullanıcı adı";
                    break;
                case MembershipCreateStatus.DuplicateEmail: mess += "Kullanılmış email girildi";
                    break;
                case MembershipCreateStatus.UserRejected:
                    mess += "Kullanıcı Engel hatası";
                    break;
                case MembershipCreateStatus.InvalidProviderUserKey:
                    break;
                case MembershipCreateStatus.DuplicateProviderUserKey:
                    mess += "Key hata";
                    break;
                case MembershipCreateStatus.ProviderError:
                    mess += "üye yönetimi sağlayıcısı hatası";
                    break;
                default:
                    break;
            }
            ViewBag.Mesaj = mess;
            if (statu == MembershipCreateStatus.Success)
                return RedirectToAction("Index");
            else
            {
                return View();
            }
       
        }
        [Authorize(Roles = "Admin")]
        public ActionResult AssignRole()
        {
            ViewBag.Role = Roles.GetAllRoles().ToList();
            ViewBag.Users = Membership.GetAllUsers();
            return View();
        }
        [Authorize(Roles = "Admin")]


        [HttpPost]
        public ActionResult AssignRole(string UsersName,string RoleName)
        {
            Roles.AddUserToRole(UsersName, RoleName);
            return RedirectToAction("Index"); 
        }
    }
}