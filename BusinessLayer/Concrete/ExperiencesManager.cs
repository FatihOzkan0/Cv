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

        public void AboutAdd(Experience experience)
        {
            throw new NotImplementedException();
        }

        public void AboutDelete(Experience experience)
        {
            throw new NotImplementedException();
        }

        public void AboutUpdate(Experience experience)
        {
            throw new NotImplementedException();
        }

        public Experience GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Experience> GetList()
        {
            return _experienceDal.List();
        }
    }
}
