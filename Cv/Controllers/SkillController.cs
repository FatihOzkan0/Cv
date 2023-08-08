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
    public class SkillController : Controller
    {
        SkillManager sm = new SkillManager(new EfSkillsDal());
        public ActionResult Index()
        {
            var SkillValue = sm.GetSkills();
            return View(SkillValue);
        }


        [HttpGet]
        public ActionResult SkillAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SkillAdd(Skills skills)
        {
            sm.SkillsAdd(skills);
            return RedirectToAction("Index");
        }

        public ActionResult SkillDelete(int id)
        {
            var skillValue = sm.GetById(id);
            sm.SkillsDelete(skillValue);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult SkillEdit(int id)
        {
            var skillValue= sm.GetById(id);
            return View(skillValue);
        }

        [HttpPost]

        public ActionResult SkillEdit(Skills skills)
        {
            sm.SkillsUpdate(skills);
            return RedirectToAction("Index");
            
        }
    }
}