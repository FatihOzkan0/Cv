using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cv.Controllers
{
    public class ComminicationController : Controller
    {
        CommunicationManager cm = new CommunicationManager(new EfComminicationDal());
        public ActionResult Index()
        {
            var ContactList = cm.GetList();
            return View(ContactList);
        }
    }
}