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
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMeadiaDal _social;

        public SocialMediaManager(ISocialMeadiaDal social)
        {
            _social = social;
        }

        public void Add(SocialMedia socialMedia)
        {
            _social.Insert(socialMedia);
        }

        public SocialMedia GetID(int id)
        {
            return _social.Get(x=>x.Id==id);
        }

        public List<SocialMedia> GetList()
        {
            return _social.List();
        }

        public void SocialDelete(SocialMedia socialMedia)
        {
            _social.Delete(socialMedia);
        }

        public void SocialUpdate(SocialMedia socialMedia)
        {
            _social.Update(socialMedia);
        }
    }
}
