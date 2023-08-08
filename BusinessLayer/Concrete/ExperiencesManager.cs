using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ExperiencesManager : IExperiencesService
    {
        IExperienceDal _experienceDal;

        public ExperiencesManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public void ExperiencesAdd(Experience experience)
        {
            _experienceDal.Insert(experience);
        }

        public void ExperiencesDelete(Experience experience)
        {
            _experienceDal.Delete(experience);
        }

        public void ExperiencesUpdate(Experience experience)
        {
            _experienceDal.Update(experience);
        }

        public Experience GetByID(int id)        //Bu method ile ID tutuyoruz ve ona göre o İD de işlem gerçekleştiriyoruz.
        {
            return _experienceDal.Get(x => x.ID == id);
        }

        public List<Experience> GetList()
        {
            return _experienceDal.List();
        }
    }
}
