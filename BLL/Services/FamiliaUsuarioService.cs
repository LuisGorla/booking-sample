using BLL.Services.Interfaces;
using DAL.Models;
using DAL.Repositories;
using System.Collections.Generic;

namespace BLL.Services
{
    public class FamiliaUsuarioService : IFamiliaUsuarioService
    {
        public void Delete(FamiliaUsuario familiaUsuario)
        {
            var repository = new GenericRepository<FamiliaUsuario>();
            repository.Delete(familiaUsuario);
            repository.Save();
        }

        public IEnumerable<FamiliaUsuario> GetAll()
        {
            var repository = new GenericRepository<FamiliaUsuario>();
            var result = repository.GetAll();
            return result;
        }

        public IEnumerable<FamiliaUsuario> GetById()
        {
            throw new System.NotImplementedException();
        }

        public void Insert(FamiliaUsuario familiaUsuario)
        {
            var repository = new GenericRepository<FamiliaUsuario>();
            repository.Insert(familiaUsuario);
            repository.Save();
        }

        public void Update(FamiliaUsuario familiaUsuario)
        {
            throw new System.NotImplementedException();
        }
    }
}
