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
    public class AltaUsuarioService : IAltaUsuario
    {
        public void Delete(Usuario usuario)
        {
            var repository = new GenericRepository<Usuario>();
            var user = repository.GetById(usuario.IdUsuario);
            repository.Delete(user);
            repository.Save();
        }

        public IEnumerable<Usuario> GetAll()
        {
            var repository = new GenericRepository<Usuario>();
            var result = repository.GetAll();
            return result;
        }

        public Usuario GetById(int id)
        {
            var repository = new GenericRepository<Usuario>();
            var usuario = repository.GetById(id);
            return usuario;
        }

        public void Insert(Usuario usuario)
        {
            var repository = new GenericRepository<Usuario>();
            repository.Insert(usuario);
            repository.Save();
        }

        public void Update(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
