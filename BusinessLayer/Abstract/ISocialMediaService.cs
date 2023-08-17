using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISocialMediaService
    {
        void Add(SocialMedia socialMedia);
        void SocialDelete(SocialMedia socialMedia);
        void SocialUpdate(SocialMedia socialMedia);
        List<SocialMedia> GetList();
        SocialMedia GetID(int id);
    }
}
