using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface IidiomaService
    {
        public IEnumerable<Idioma> GetAll();
        public IEnumerable<Idioma> GetById();
        public void Insert(Idioma idioma);
        public void Update(Idioma idioma);
        public void Delete(Idioma idioma);
    }
}
