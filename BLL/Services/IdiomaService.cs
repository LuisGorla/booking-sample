using BLL.Services.Interfaces;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;

namespace BLL.Services
{
    public class IdiomaService : IidiomaService
    {
        public void Delete(Idioma idioma)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Idioma> GetAll()
        {
            var repository = new GenericRepository<Idioma>();
            var result = repository.GetAll();
            return result;
        }

        public IEnumerable<Idioma> GetById()
        {
            throw new NotImplementedException();
        }

        public void Insert(Idioma idioma)
        {
            throw new NotImplementedException();
        }

        public void Update(Idioma idioma)
        {
            throw new NotImplementedException();
        }
    }
}
