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
        void AboutAdd(Experience experience);
        Experience GetByID(int id);
        void AboutDelete(Experience experience);
        void AboutUpdate(Experience experience);
    }
}
