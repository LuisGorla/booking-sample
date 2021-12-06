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
    public class DvvService : IDvv
    {
        public void Delete(Dvv dvv)
        {
            var repository = new GenericRepository<Dvv>();
            repository.Delete(dvv);
            repository.Save();
        }

        public IEnumerable<Dvv> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Dvv> GetById()
        {
            throw new NotImplementedException();
        }

        public void Insert(Dvv dvv)
        {
            throw new NotImplementedException();
        }

        public void Update(Dvv dvv)
        {
            var repo = new GenericRepository<Dvv>();

            var repoPatente = new GenericRepository<Patente>();
            var patentes = repoPatente.GetAll().Select(x => x.Dvh);

            var repoFamilia = new GenericRepository<Familia>();
            var familias = repoFamilia.GetAll().Select(x => x.Dvh);

            var repoFamiliaUsuario = new GenericRepository<FamiliaUsuario>();
            var familiaUsuarios = repoFamiliaUsuario.GetAll().Select(x => x.Dvh);

            var repoPatenteFamilia = new GenericRepository<PatenteFamilium>();
            var patenteFamilias = repoPatenteFamilia.GetAll().Select(x => x.Dvh);

            var repoPatenteUsuario = new GenericRepository<PatenteUsuario>();
            var patenteUsuarios = repoPatenteUsuario.GetAll().Select(x => x.Dvh);

            var repoUsuarios = new GenericRepository<Usuario>();
            var usuarios = repoUsuarios.GetAll().Select(x => x.Dvh);

            var dv1 = repo.GetAll().Where(x => x.Tabla == "Patentes").FirstOrDefault();
            repo.Delete(dv1);
            var concatPatentes = string.Join("", patentes);
            dv1.Dvv1 = Security.Security.CrearDVH(concatPatentes);
            repo.Update(dv1);
            repo.Save();

            var dv2 = repo.GetAll().Where(x => x.Tabla == "Familias").FirstOrDefault();
            repo.Delete(dv2);
            var concatfamilias = string.Join("", familias);
            dv2.Dvv1 = Security.Security.CrearDVH(concatfamilias);
            repo.Update(dv2);
            repo.Save();

            var dv3 = repo.GetAll().Where(x => x.Tabla == "FamiliaUsuario").FirstOrDefault();
            repo.Delete(dv3);
            var concatfamiliaUsuarios = string.Join("", familiaUsuarios);
            dv3.Dvv1 = Security.Security.CrearDVH(concatfamiliaUsuarios);
            repo.Update(dv3);
            repo.Save();

            var dv4 = repo.GetAll().Where(x => x.Tabla == "PatenteFamilia").FirstOrDefault();
            repo.Delete(dv4);
            var concatpatenteFamilias = string.Join("", patenteFamilias);
            dv4.Dvv1 = Security.Security.CrearDVH(concatpatenteFamilias);
            repo.Update(dv4);
            repo.Save();

            var dv5 = repo.GetAll().Where(x => x.Tabla == "PatenteUsuario").FirstOrDefault();
            repo.Delete(dv5);
            var concatpatenteUsuarios = string.Join("", patenteUsuarios);
            dv5.Dvv1 = Security.Security.CrearDVH(concatpatenteUsuarios);
            repo.Update(dv5);
            repo.Save();

            var dv6 = repo.GetAll().Where(x => x.Tabla == "Usuarios").FirstOrDefault();
            repo.Delete(dv6);
            var concatusuarios = string.Join("", usuarios);
            dv6.Dvv1 = Security.Security.CrearDVH(concatusuarios);
            repo.Update(dv6);
            repo.Save();
        }

    }
}
