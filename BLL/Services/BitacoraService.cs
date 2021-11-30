using BLL.Services.Interfaces;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;

namespace BLL.Services
{
    public class BitacoraService : IBitacoraService
    {
        public void Delete(Bitacora bitacora)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Bitacora> GetAll()
        {
            var repository = new GenericRepository<Bitacora>();

            var result = repository.GetAll();

            return result;
        }

        public IEnumerable<Bitacora> GetById()
        {
            throw new NotImplementedException();
        }

        public void Insert(Bitacora bitacora)
        {
            var repository = new GenericRepository<Bitacora>();
            repository.Insert(bitacora);
            repository.Save();
        }

        public void Update(Bitacora bitacora)
        {
            throw new NotImplementedException();
        }
    }
}
