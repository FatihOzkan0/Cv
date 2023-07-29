using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IEducationService
    {
        void EducationAdd(Education education);
        void EducationDelete(Education education);
        void EducationUpdaate (Education education);
        List<Education> GetList();
        Education GetById(int id);

    }
}
