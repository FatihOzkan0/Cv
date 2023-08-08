using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cv.Controllers
{
    public class ExperiencesController : Controller
    {
        ExperiencesManager ep = new ExperiencesManager(new EfExperiencesDal());
       
        public ActionResult Index()
        {
            var deneyimValues = ep.GetList();
            return View(deneyimValues);
        }
        [HttpGet]
        public ActionResult ExperiencesAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ExperiencesAdd(Experience experience) 
        {
            ep.ExperiencesAdd(experience);
           
            return RedirectToAction("Index");
        }

        public ActionResult ExperiencesDelete(int id)
        {
            var experiencesValue= ep.GetByID(id);
            ep.ExperiencesDelete(experiencesValue);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult ExperienceEdit(int id)
        {
            var experiencesValue = ep.GetByID(id);
            return View(experiencesValue);
        }
        [HttpPost]
        public ActionResult ExperienceEdit(Experience experience)
        {
            ep.ExperiencesUpdate(experience);
            return RedirectToAction("Index");

        }

    }
}