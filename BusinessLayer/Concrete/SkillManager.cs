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
    public class SkillManager : ISkillsService
    {
        ISkillsDal _skillsDal { get; set; }
        public SkillManager(ISkillsDal skillsDal)
        {
            _skillsDal = skillsDal;
        }

        
        public Skills GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Skills> GetSkills()
        {
             return _skillsDal.List();
        }

        public void SkillsAdd(Skills skill)
        {
            throw new NotImplementedException();
        }

        public void SkillsDelete(Skills skill)
        {
            throw new NotImplementedException();
        }

        public void SkillsUpdate(Skills skill)
        {
            throw new NotImplementedException();
        }
    }
}
