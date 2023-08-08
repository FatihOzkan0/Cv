using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICertificaService
    {
        void Add(Certifica certifica);
        void CertificaDelete (Certifica certifica);
        void CertificaUpdate (Certifica certifica);
        List<Certifica> GetList ();
        Certifica GetID (int id);
    }
}
