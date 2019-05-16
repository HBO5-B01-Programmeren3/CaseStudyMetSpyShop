using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCourse.Spyshop.Domain.Catalog
{
    public interface IRepository<T, TId> where T : BaseEntity<TId>
    {
        T GetById(TId id);
        IQueryable<T> GetAll();
        T Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
