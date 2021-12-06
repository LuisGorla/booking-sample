using BLL.Services.Interfaces;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;

namespace BLL.Services
{
    public class TraduccionService : ITraduccionService
    {
        public void Delete(Traduccion traduccion)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Traduccion> GetAll()
        {
            var repository = new GenericRepository<Traduccion>();
            var result = repository.GetAll();
            return result;
        }

        public IEnumerable<Traduccion> GetById()
        {
            throw new NotImplementedException();
        }

        public void Insert(Traduccion traduccion)
        {
            throw new NotImplementedException();
        }

        public void Update(Traduccion traduccion)
        {
            throw new NotImplementedException();
        }
    }
}
