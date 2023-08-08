using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IComminicationService
    {
        void CommunucationAdd(Communication comminication);
        void CommunucationDelete(Communication comminication);
        void CommunucationUpdate(Communication comminication);
        List<Communication> GetList();
        Communication GetId(int id);

    }
}
