using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context contex = new Context();
        DbSet<T> _object;         //Burada veri tabanımızda ki tabloya erişiyoruz _object değişkeni ile.

        public GenericRepository()
        {
            _object = contex.Set<T>();    //Set methodu ile _object değişkenini dolduruyoruz.Artık _object veri tabanı tablosunu temsil eder.
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Delete(T p)
        {
            var deletedEntity = contex.Entry(p);
            deletedEntity.State = EntityState.Deleted;
            contex.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public void Insert(T p)
        {
            var addedEntity = contex.Entry(p);
            addedEntity.State = EntityState.Added;
            contex.SaveChanges();
        }

        public void Update(T p)
        {
            var updatedEntity = contex.Entry(p);
            updatedEntity.State = EntityState.Modified;
            contex.SaveChanges();
        }
    }
}
