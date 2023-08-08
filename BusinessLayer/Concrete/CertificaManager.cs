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
    public class CertificaManager : ICertificaService
    {

        ICertificaDal _certificaDal;

       public CertificaManager(ICertificaDal certificaDal)
        {
            _certificaDal = certificaDal;
        }
        public void Add(Certifica certifica)
        {
            _certificaDal.Insert(certifica);
        }

        public void CertificaDelete(Certifica certifica)
        {
           _certificaDal.Delete(certifica);
        }

        public void CertificaUpdate(Certifica certifica)
        {
            _certificaDal.Update(certifica);
        }

        public Certifica GetID(int id)
        {
            return _certificaDal.Get(x=>x.ID == id);
        }

        public List<Certifica> GetList()
        {
            return _certificaDal.List();
        }
    }
}
