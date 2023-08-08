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
    public class EducationController : Controller
    {
        EducationManager em = new EducationManager(new EfEducationDal());
        
        public ActionResult Index()
        {
            var EducationList = em.GetList();
            return View(EducationList);
        }
        
        [HttpGet]
        public ActionResult EducationAdd() 
        {
             return View();
        }

        [HttpPost]
        public ActionResult EducationAdd(Education education)
        {
            em.EducationAdd(education);
            return RedirectToAction("Index");
        }

        public ActionResult EducationDelete(int id)
        {
            var DeleteID = em.GetById(id);
            em.EducationDelete(DeleteID);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EducationEdit(int id)
        {
            var EditID = em.GetById(id);
            return View(EditID);
        }
        [HttpPost]
        public ActionResult EducationEdit(Education education)
        {
            em.EducationUpdaate(education);
            return RedirectToAction("Index");
        }
    }
}