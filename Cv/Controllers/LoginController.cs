using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Cv.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            Context context = new Context();
            var adminUserInfo = context.Admins.FirstOrDefault(x=>x.UserName==admin.UserName && x.Password==admin.Password);
           
            if (adminUserInfo != null)
            {
                FormsAuthentication.SetAuthCookie(adminUserInfo.UserName, false);
                Session["UserName"] = adminUserInfo.UserName;
                return RedirectToAction("Index","Experiences");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();       //Oturuma Giriş yapan kullanıcıdan çıkar bilgilerini Siler.
            Session.Abandon();                   //Oturumu Sonlandırır.
            return RedirectToAction("Index", "VitrinPanel");
        }
    }
}