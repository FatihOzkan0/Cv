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
    public class EducationManager : IEducationService
    {
        IEducationDal _educationDal;

        public EducationManager(IEducationDal educationDal)
        {
            _educationDal = educationDal;
        }
        public void EducationAdd(Education education)
        {
           _educationDal.Insert(education);
        }

        public void EducationDelete(Education education)
        {
            _educationDal.Delete(education);
        }

        public void EducationUpdaate(Education education)
        {
            _educationDal.Update(education);
        }

        public Education GetById(int id)
        {
          return _educationDal.Get(x=>x.ID==id);
        }

        public List<Education> GetList()
        {
          return  _educationDal.List();
        }
    }
}
