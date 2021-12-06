using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface IUserIdioma
    {
        public IEnumerable<UserIdioma> GetAll();
        public IEnumerable<UserIdioma> GetById();
        public void Insert(UserIdioma userIdioma);
        public void Update(UserIdioma userIdioma);
        public void Delete(UserIdioma userIdioma);
    }
}
