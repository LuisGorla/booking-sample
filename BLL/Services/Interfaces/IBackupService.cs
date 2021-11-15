using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace BLL.Services.Interfaces
{
    public interface IBackupService
    {
        public IEnumerable<Backup> GetAll();
        public IEnumerable<Backup> GetById();
        public void Insert(Backup backup);
        public void Update(Backup backup); 
        public void Delete(Backup backup);
    }
}
