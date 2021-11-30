using BLL.Services.Interfaces;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;


namespace BLL.Services
{
    public class PatenteFamiliaService : IPatenteFamilia
    {
        public void Delete(PatenteFamilium patenteFamilia)
        {
            var repository = new GenericRepository<PatenteFamilium>();
            repository.Delete(patenteFamilia);
            repository.Save();
        }

        public IEnumerable<PatenteFamilium> GetAll()
        {
            var repository = new GenericRepository<PatenteFamilium>();
            var result = repository.GetAll();
            return result;
        }

        public IEnumerable<PatenteFamilium> GetById()
        {
            throw new NotImplementedException();
        }

        public void Insert(PatenteFamilium patenteFamilia)
        {
            var repository = new GenericRepository<PatenteFamilium>();
            repository.Insert(patenteFamilia);
            repository.Save();
        }

        public void Update(PatenteFamilium patenteFamilia)
        {
            throw new NotImplementedException();
        }
    }
}
