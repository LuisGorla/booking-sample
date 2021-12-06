using BE.ViewModels;
using BLL.Services.Interfaces;

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
