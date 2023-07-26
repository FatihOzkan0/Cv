
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Certifica> Certificaciones { get; set; }
        public DbSet<Communication> Communications { get; set; }
        public DbSet<Education> Educationes { get; set;}
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Hobby> Hobbys { get; set;}
        public DbSet<Skills> Skills { get; set; }


    }
}
