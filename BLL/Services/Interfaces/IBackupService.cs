using System.Collections.Generic;
using DAL.Models;
using Microsoft.Data.SqlClient;

namespace BLL.Services.Interfaces
{
    public interface IBackupService
    {
        public IEnumerable<Backup> GetAll();
        public IEnumerable<Backup> GetById();
        public void Insert(Backup backup);
        public void Update(Backup backup); 
        public void Delete(Backup backup);
        public void RunProccedure(string command, SqlParameter[] parameter);
        
    }
}
