using BLL.Services.Interfaces;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AltaPatenteService : IAltaPatente
    {
        public void Delete(Patente patente)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Patente> GetAll()
        {
            var repository = new GenericRepository<Patente>();
            var result = repository.GetAll();
            return result;
        }

        public IEnumerable<Patente> GetById()
        {
            throw new NotImplementedException();
        }

        public void Insert(Patente patente)
        {
            var repository = new GenericRepository<Patente>();
            repository.Insert(patente);
            repository.Save();
        }

        public void Update(Patente patente)
        {
            throw new NotImplementedException();
        }
    }
}
