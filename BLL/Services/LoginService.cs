using BE.ViewModels;
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
    public class LoginService : ILoginService
    {
        public bool LoginUser(LoginViewModel usuario)
        {            

            if (Security.Security.VerificarUsuario(usuario))
            {               
                return true;
            }

            return false;            
        }
    }
}
