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
    public class CommunicationManager : IComminicationService
    {
        IComminicationDal _comminicationDal;

        public CommunicationManager(IComminicationDal comminicationDal)
        {
            _comminicationDal = comminicationDal;
        }

        public void CommunucationAdd(Communication comminication)
        {
            _comminicationDal.Insert(comminication);
        }

        public void CommunucationDelete(Communication comminication)
        {
            throw new NotImplementedException();
        }

        public void CommunucationUpdate(Communication comminication)
        {
            throw new NotImplementedException();
        }

        public Communication GetId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Communication> GetList()
        {
            return _comminicationDal.List();
        }
    }
}
