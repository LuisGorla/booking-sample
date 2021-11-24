using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface IAltaUsuario
    {
        public IEnumerable<Usuario> GetAll();
        public Usuario GetById(int id);
        public void Insert(Usuario usuario);
        public void Update(Usuario usuario);
        public void Delete(Usuario usuario);
    }
}
