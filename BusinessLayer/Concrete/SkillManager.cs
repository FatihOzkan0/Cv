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
           return _skillsDal.Get(x=>x.ID==id);
        }

        public List<Skills> GetSkills()
        {
             return _skillsDal.List();
        }

        public void SkillsAdd(Skills skill)
        {
            _skillsDal.Insert(skill);
        }

        public void SkillsDelete(Skills skill)
        {
            _skillsDal.Delete(skill);
        }

        public void SkillsUpdate(Skills skill)
        {
            _skillsDal.Update(skill);
        }
    }
}
