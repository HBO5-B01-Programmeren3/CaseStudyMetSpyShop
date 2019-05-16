using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreCourse.Spyshop.Domain.Catalog;

namespace CoreCourse.Spyshop.Web.Data
{
    public class EfRepository<T, TId> : IRepository<T, TId> where T : BaseEntity<TId>
    {
        protected readonly SpyShopContext _dbContext;

        public EfRepository(SpyShopContext dbContext)
        {
            _dbContext = dbContext;
        }

        public T Add(T entity)
        {
            entity.CreatedByUsername = "Jorge";
            entity.DateTimeCreated = DateTime.Now;
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            return _dbContext.Set<T>();
        }

        public T GetById(TId id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
