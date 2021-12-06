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
    public class BlockService : IBlockService
    {
        public void Delete(Bloqueo block)
        {
            var repository = new GenericRepository<Bloqueo>();
            repository.Delete(block);
            repository.Save();
        }

        public IEnumerable<Bloqueo> GetAll()
        {
            var repository = new GenericRepository<Bloqueo>();
            var result = repository.GetAll();
            return result;
        }

        public IEnumerable<Bloqueo> GetById()
        {
            throw new NotImplementedException();
        }

        public void Insert(Bloqueo block)
        {
            var repository = new GenericRepository<Bloqueo>();
            repository.Insert(block);
            repository.Save();
        }

        public void Update(Bloqueo block)
        {
            throw new NotImplementedException();
        }
    }
}
