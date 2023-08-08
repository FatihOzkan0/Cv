using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cv.Controllers
{
    public class VitrinPanelController : Controller
    {
        AboutManager AboutManager = new AboutManager(new EfAboutDal() );

        ExperiencesManager ExperienceManager = new ExperiencesManager(new EfExperiencesDal() );

        EducationManager educationManager = new EducationManager(new EfEducationDal() );

        SkillManager skillManager = new SkillManager(new EfSkillsDal() );

        HobbyManager hobbyManager = new HobbyManager(new EfHobbyDal() );

        CertificaManager certificaManager = new CertificaManager(new EfCertificaDal() );

        CommunicationManager communicationManager = new CommunicationManager(new EfComminicationDal() );


        public ActionResult Index()      //About
        {
            var values = AboutManager.GetList();
            return View(values);
        }

        public PartialViewResult Experiences()    //Projelerimi listeler.
        {
            var values = ExperienceManager.GetList();
            return PartialView(values);
        }

        public PartialViewResult Educations()
        {
            var educationValues = educationManager.GetList();
            return PartialView(educationValues);
        }

        public PartialViewResult Skills()
        {
            var skillsValues = skillManager.GetSkills();
            return PartialView(skillsValues);
        }

        public PartialViewResult Hobby()
        {
            var hobbyValues = hobbyManager.GetList();
            return PartialView(hobbyValues);
        }

        public PartialViewResult Certifica()
        {
            var certificaValues = certificaManager.GetList();
            return PartialView(certificaValues);
        }

        [HttpGet]
        public PartialViewResult Contact()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult Contact(Communication c)
        {
            c.Date = DateTime.Now;
            communicationManager.CommunucationAdd(c);
            return PartialView();
        }


    }
}