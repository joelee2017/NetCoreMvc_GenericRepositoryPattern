using Microsoft.EntityFrameworkCore;
using Model.Data;
using System.Collections.Generic;
using System.Linq;

namespace Model.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private MvcMovieContext _context = null;
        private DbSet<T> table = null;

        public GenericRepository(MvcMovieContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return table.AsEnumerable();
        }
        public T GetById(object id)
        {
            return table.Find(id);
        }
        public void Insert(T obj)
        {
            table.Add(obj);
        }
        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
