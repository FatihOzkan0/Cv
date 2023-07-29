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
            throw new NotImplementedException();
        }

        public void EducationDelete(Education education)
        {
            throw new NotImplementedException();
        }

        public void EducationUpdaate(Education education)
        {
            throw new NotImplementedException();
        }

        public Education GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Education> GetList()
        {
          return  _educationDal.List();
        }
    }
}
