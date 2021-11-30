using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface IPatenteFamilia
    {
        public IEnumerable<PatenteFamilium> GetAll();
        public IEnumerable<PatenteFamilium> GetById();
        public void Insert(PatenteFamilium patenteFamilia);
        public void Update(PatenteFamilium patenteFamilia);
        public void Delete(PatenteFamilium patenteFamilia);
    }
}
