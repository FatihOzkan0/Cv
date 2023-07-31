using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISkillsService
    {
        void SkillsAdd(Skills skill);
        void SkillsDelete(Skills skill);
        void SkillsUpdate(Skills skill);    
        List<Skills> GetSkills();
        Skills GetById(int id);


    }
}
