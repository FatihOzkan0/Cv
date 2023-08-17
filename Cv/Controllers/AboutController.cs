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
    [Authorize]
    public class AboutController : Controller
    {
        AboutManager ab = new AboutManager(new EfAboutDal());
        public ActionResult Index()
        {
            var values = ab.GetList();
            return View(values);
        }


        [HttpGet]
        public ActionResult AboutAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AboutAdd(About about)
        {
            ab.AboutAdd(about);
            return RedirectToAction("Index");
        }

        public ActionResult AboutDelete(int id)
        {
            var values = ab.GetByID(id);
            ab.AboutDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AboutEdit(int id)
        {
            var values = ab.GetByID(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult AboutEdit(About about)
        {
            ab.AboutUpdate(about);
            return RedirectToAction("Index");
        }
    }
}