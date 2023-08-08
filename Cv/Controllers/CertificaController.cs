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
    public class CertificaController : Controller
    {
        CertificaManager cm = new CertificaManager(new EfCertificaDal());
        public ActionResult Index()
        {
           var CertificaList= cm.GetList();
            return View(CertificaList);
        }

        [HttpGet]
        public ActionResult CertificaAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CertificaAdd(Certifica certifica)
        {
            cm.Add(certifica);
            return RedirectToAction("Index");
        }
        
        public ActionResult CertificaDelete(int id)
        {
            var DeleteID = cm.GetID(id);
            cm.CertificaDelete(DeleteID);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CertificaEdit(int id)
        {
            var UpdateId = cm.GetID(id);
            return View(UpdateId);
        }

        [HttpPost]
        public ActionResult CertificaEdit(Certifica certifica)
        {
            cm.CertificaUpdate(certifica);
            return RedirectToAction("Index");
        }
    }
}