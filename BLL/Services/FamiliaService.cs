using BLL.Services.Interfaces;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;

namespace BLL.Services
{
    public class FamiliaService : IFamiliaService
    {
        public void Delete(Familia patente)
        {
            var repository = new GenericRepository<Familia>();
            repository.Delete(patente);
            repository.Save();
        }

        public IEnumerable<Familia> GetAll()
        {
            var repository = new GenericRepository<Familia>();
            var result = repository.GetAll();
            return result;
        }

        public IEnumerable<Familia> GetById()
        {
            throw new NotImplementedException();
        }

        public void Insert(Familia familia)
        {
            var repository = new GenericRepository<Familia>();
            repository.Insert(familia);
            repository.Save();
        }

        public void Update(Familia patente)
        {
            throw new NotImplementedException();
        }
    }
}
