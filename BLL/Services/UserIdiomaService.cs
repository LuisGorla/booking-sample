using BLL.Services.Interfaces;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserIdiomaService : IUserIdioma
    {
        public void Delete(UserIdioma userIdioma)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserIdioma> GetAll()
        {
            var repository = new GenericRepository<UserIdioma>();
            var result = repository.GetAll();
            return result;
        }

        public IEnumerable<UserIdioma> GetById()
        {
            throw new NotImplementedException();
        }

        public void Insert(UserIdioma userIdioma)
        {
            var repository = new GenericRepository<UserIdioma>();
            repository.Insert(userIdioma);
            repository.Save();
        }

        public void Update(UserIdioma userIdioma)
        {
            throw new NotImplementedException();
        }
    }
}
