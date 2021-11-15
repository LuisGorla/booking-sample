using BE.ViewModels;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Linq;

namespace Security
{
    public static class Security
    {
        public static Usuario LoggedUser { get; set; }      
        public static bool VerificarUsuario (LoginViewModel usuario) {

            var repository = new GenericRepository<Usuario>();

            LoggedUser = repository.GetAll().Where(x => x.Dni == usuario.DNI).FirstOrDefault();

            if (LoggedUser.Dni == usuario.DNI && LoggedUser.ContraseA == usuario.Password)
            {                
                return true;
            }
            else
            {
                LoggedUser = null;
                return false;
            }
        }
    }
}
