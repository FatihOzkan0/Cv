using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IExperiencesService
    {
        List<Experience> GetList();
        void ExperiencesAdd(Experience experience);
        Experience GetByID(int id);
        void ExperiencesDelete(Experience experience);
        void ExperiencesUpdate(Experience experience);

        
    }
}
