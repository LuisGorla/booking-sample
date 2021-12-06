using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface IDvv
    {
        public IEnumerable<Dvv> GetAll();
        public IEnumerable<Dvv> GetById();
        public void Insert(Dvv dvv);
        public void Update(Dvv dvv);
        public void Delete(Dvv dvv);
    }
}
