using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface IFamiliaUsuarioService
    {
        public IEnumerable<FamiliaUsuario> GetAll();
        public IEnumerable<FamiliaUsuario> GetById();
        public void Insert(FamiliaUsuario familiaUsuario);
        public void Update(FamiliaUsuario familiaUsuario);
        public void Delete(FamiliaUsuario familiaUsuario);
    }
}
