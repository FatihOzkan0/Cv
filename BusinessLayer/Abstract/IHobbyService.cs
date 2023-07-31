using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHobbyService
    {
        void HobbyAdd(Hobby hobby);
        void HobbyDelete(Hobby hobby);
        void HobbyUpdate(Hobby hobby);
        List<Hobby> GetList();

        Hobby GetID(int id);
    }
}
