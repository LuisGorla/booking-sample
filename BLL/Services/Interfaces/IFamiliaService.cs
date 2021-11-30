using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface IFamiliaService
    {
        public IEnumerable<Familia> GetAll();
        public IEnumerable<Familia> GetById();
        public void Insert(Familia familia);
        public void Update(Familia familia);
        public void Delete(Familia familia);
    }
}
