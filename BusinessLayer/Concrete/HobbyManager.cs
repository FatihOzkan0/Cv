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
    public class HobbyManager : IHobbyService
    {

        IHobbyDal _hobbydal;

        public HobbyManager(IHobbyDal hobbyDal)
        {
            _hobbydal = hobbyDal;
        }
        public Hobby GetID(int id)
        {
            return _hobbydal.Get(x=>x.ID==id);
        }

        public List<Hobby> GetList()
        {
            return _hobbydal.List();
        }

        public void HobbyAdd(Hobby hobby)
        {
             _hobbydal.Insert(hobby);
        }

        public void HobbyDelete(Hobby hobby)
        {
            _hobbydal.Delete(hobby);
        }

        public void HobbyUpdate(Hobby hobby)
        {
           _hobbydal.Update(hobby);
        }
    }
}
