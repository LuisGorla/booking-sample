using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface IBlockService
    {
        public IEnumerable<Bloqueo> GetAll();
        public IEnumerable<Bloqueo> GetById();
        public void Insert(Bloqueo block);
        public void Update(Bloqueo block);
        public void Delete(Bloqueo block);
    }
}
