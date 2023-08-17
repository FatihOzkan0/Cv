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
    public class SocialMediaController : Controller
    {
        SocialMediaManager sm = new SocialMediaManager(new EfSocialMediaDal());
        
        public ActionResult Index()
        {
            var values = sm.GetList();
            return View(values);
        }
        [HttpGet]
        public ActionResult SocialMediaAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SocialMediaAdd(SocialMedia media)
        {
            sm.Add(media);
            return RedirectToAction("Index");
        }

        public ActionResult SocialMediaDelete(int id)
        {
            var DeleteId = sm.GetID(id);
            sm.SocialDelete(DeleteId);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult SocialMediaEdit(int id)
        {
            var UpdateId = sm.GetID(id);
            return View(UpdateId);
        }

        [HttpPost]
        public ActionResult SocialMediaEdit(SocialMedia media)
        {
            sm.SocialUpdate(media);
            return RedirectToAction("Index");
        }
    }
}