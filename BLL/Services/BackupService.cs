using BLL.Services.Interfaces;
using DAL.Models;
using DAL.Repositories;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace BLL.Services
{
    public class BackupService : IBackupService
    {
        public void Delete(Backup backup)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Backup> GetAll()
        {
            var repository = new GenericRepository<Backup>();

            var result = repository.GetAll();

            return result;
        }

        public IEnumerable<Backup> GetById()
        {
            throw new NotImplementedException();
        }

        public void Insert(Backup backup)
        {
            var repository = new GenericRepository<Backup>();
            repository.Insert(backup);
            repository.Save();
        }

        public void Update(Backup backup)
        {
            throw new NotImplementedException();
        }
        public void RunProccedure(string command, SqlParameter[] parameter)
        {
            var repository = new GenericRepository<Backup>();
            repository.RunProccedure(command, parameter);
        }
    }
}
