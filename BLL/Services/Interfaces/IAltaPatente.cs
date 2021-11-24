using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface IAltaPatente
    {
        public IEnumerable<Patente> GetAll();
        public IEnumerable<Patente> GetById();
        public void Insert(Patente patente);
        public void Update(Patente patente);
        public void Delete(Patente patente);
    }
}
