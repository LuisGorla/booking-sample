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
    public class PatenteUsuarioService : IPatenteUsuario
    {
        public void Delete(PatenteUsuario patenteusuario)
        {
            var repository = new GenericRepository<PatenteUsuario>();
            repository.Delete(patenteusuario);
            repository.Save();
        }

        public IEnumerable<PatenteUsuario> GetAll()
        {
            var repository = new GenericRepository<PatenteUsuario>();
            var result = repository.GetAll();
            return result;
        }

        public IEnumerable<PatenteUsuario> GetById()
        {
            throw new NotImplementedException();
        }

        public void Insert(PatenteUsuario patenteusuario)
        {
            var repository = new GenericRepository<PatenteUsuario>();
            repository.Insert(patenteusuario);
            repository.Save();
        }

        public void Update(PatenteUsuario patenteusuario)
        {
            throw new NotImplementedException();
        }
    }
}
