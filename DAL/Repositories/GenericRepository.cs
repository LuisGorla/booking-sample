using DAL.Data;
using DAL.Repositories.Intefaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private BookingContext _dbcontext = null;
        private DbSet<T> _table = null;

        public GenericRepository()
        {
            _dbcontext = new BookingContext();
            _table = _dbcontext.Set<T>();
        }
        public void Delete(T id)
        {
            //T existing = _table.Find(id);
            _table.Remove(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _table.ToList();        
        }

        public T GetById(object id)
        {
            return _table.Find(id);
        }

        public void Insert(T obj)
        {
            _table.Add(obj);
        }

        public void Save()
        {
            _dbcontext.SaveChanges();
        }

        public void Update(T obj)
        {
            _table.Attach(obj);
            _dbcontext.Entry(obj).State = EntityState.Modified;
        }
    }
}
