using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Model.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        IQueryable<T> Query(Expression<Func<T, bool>> predicate);

        T GetById(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
    }
}
