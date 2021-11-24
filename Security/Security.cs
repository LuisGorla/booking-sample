using BE.ViewModels;
using DAL.Models;
using DAL.Repositories;
using Encriptacion;
using System.Collections.Generic;
using System.Linq;

namespace Security
{
    public static class Security
    {
        public static Usuario LoggedUser { get; set; }
        public static bool VerificarUsuario (LoginViewModel usuario) {

            var repository = new GenericRepository<Usuario>();
            var a = repository.GetAll();
            LoggedUser = repository.GetAll().Where(x => Encriptacion.Encriptacion.DecryptString(x.Dni) == usuario.DNI).FirstOrDefault();

            if (LoggedUser == null)
            {
                return false;
            }

            if (LoggedUser.Dni == Encriptacion.Encriptacion.EncryptString(usuario.DNI) && LoggedUser.ContraseA == usuario.Password)
            {                
                return true;
            }
            else
            {
                LoggedUser = null;
                return false;
            }
        }

        public static IEnumerable<Patente> VerificarPatente() {
            var repository2 = new GenericRepository<Patente>();
            var patentes = repository2.GetAll();

            var repository = new GenericRepository<PatenteUsuario>();
            var LoggedUserPatentes = repository.GetAll().Where(x => x.IdUsuario == LoggedUser.IdUsuario);

            patentes.Where(x => LoggedUserPatentes.All(y => y.IdPatente == x.IdPatente));

            if (LoggedUserPatentes != null)
            {
                return patentes;
            }
            else
            {
                return null;
            }            
        }
        public static IEnumerable<FamiliaUsuario> VerificarFamilia() {
            var repository = new GenericRepository<FamiliaUsuario>();
            var LoggedUserFamilia = repository.GetAll().Where(x => x.IdUsuario == LoggedUser.IdUsuario);

            return LoggedUserFamilia;
        }

        public static string CrearDVH(string dvh)
        {
            var encriptarDvh = Encriptacion.Encriptacion.EncriptarIrreversible(dvh);

            return encriptarDvh;
        }
    }
}
