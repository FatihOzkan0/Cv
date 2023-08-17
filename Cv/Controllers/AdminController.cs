using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cv.Controllers
{
    public class AdminController : Controller
    {
        AdminManager am = new AdminManager(new EfAdminDal());
        public ActionResult Index()
        {
            var values = am.GetList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AdminAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminAdd(Admin admin)
        {
            am.AdminAdd(admin);
            return RedirectToAction("Index");
        }

        public ActionResult AdminDelete(int id)
        {
            var DeleteId = am.GetById(id);
            am.AdminDelete(DeleteId);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AdminEdit(int id)
        {
            var UpdateId = am.GetById(id);
            return View(UpdateId);
        }

        [HttpPost]
        public ActionResult AdminEdit(Admin admin)
        {
            am.AdminUpdate(admin);
            return RedirectToAction("Index");
        }

      
    }
}