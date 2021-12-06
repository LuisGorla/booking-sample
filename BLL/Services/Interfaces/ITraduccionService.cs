using DAL.Models;
using System.Collections.Generic;

namespace BLL.Services.Interfaces
{
    public interface ITraduccionService
    {
        public IEnumerable<Traduccion> GetAll();
        public IEnumerable<Traduccion> GetById();
        public void Insert(Traduccion traduccion);
        public void Update(Traduccion traduccion);
        public void Delete(Traduccion traduccion);
    }
}
