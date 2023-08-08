using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Management;
using System.Web.Mvc;

namespace Cv.Controllers
{
    public class HobbyController : Controller
    {
        HobbyManager hm = new HobbyManager(new EfHobbyDal());
        public ActionResult Index()
        {
            var hobbyValues = hm.GetList();
            return View(hobbyValues);
        }

        [HttpGet]
        public ActionResult HobbyAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult HobbyAdd(Hobby hobby)
        {
            hm.HobbyAdd(hobby);
            return RedirectToAction("Index");
        }

        public ActionResult HobbyDelete(int id)
        {
            var DeleteId = hm.GetID(id);
            hm.HobbyDelete(DeleteId);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult HobbyEdit(int id)
        {
            var UpdateId = hm.GetID(id);
            return View(UpdateId);
           
        }

        [HttpPost]
        public ActionResult HobbyEdit(Hobby hobby)
        {
            hm.HobbyUpdate(hobby);
            return RedirectToAction("Index");
        }
    }
}