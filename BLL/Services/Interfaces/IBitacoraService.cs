using DAL.Models;
using System.Collections.Generic;

namespace BLL.Services.Interfaces
{
    public interface IBitacoraService
    {
        public IEnumerable<Bitacora> GetAll();
        public IEnumerable<Bitacora> GetById();
        public void Insert(Bitacora bitacora);
        public void Update(Bitacora bitacora);
        public void Delete(Bitacora bitacora);
    }
}
