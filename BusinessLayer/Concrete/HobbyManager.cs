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
            throw new NotImplementedException();
        }

        public List<Hobby> GetList()
        {
            return _hobbydal.List();
        }

        public void HobbyAdd(Hobby hobby)
        {
            throw new NotImplementedException();
        }

        public void HobbyDelete(Hobby hobby)
        {
            throw new NotImplementedException();
        }

        public void HobbyUpdate(Hobby hobby)
        {
            throw new NotImplementedException();
        }
    }
}
