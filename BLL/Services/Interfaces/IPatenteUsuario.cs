using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface IPatenteUsuario
    {
        public IEnumerable<PatenteUsuario> GetAll();
        public IEnumerable<PatenteUsuario> GetById();
        public void Insert(PatenteUsuario patenteusuario);
        public void Update(PatenteUsuario patenteusuario);
        public void Delete(PatenteUsuario patenteusuario);
    }
}
