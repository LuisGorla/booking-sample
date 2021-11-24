using BE.ViewModels;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class LoginForm : Form
    {
        private LoginService _LoginService;
        private PatenteUsuarioService _patenteUsuarioService;
        private AltaUsuarioService _altaUsuarioService;
        public LoginForm()
        {
            InitializeComponent();
            _LoginService = new LoginService();
            _patenteUsuarioService = new PatenteUsuarioService();
            _altaUsuarioService = new AltaUsuarioService();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {

            var usuario = new LoginViewModel {
                DNI = Usuariotxt.Text,
                Password = Encriptacion.Encriptacion.EncriptarIrreversible(Passwordtxt.Text)
            };
           
            if (_LoginService.LoginUser(usuario))
            {
                var a = new MenuForm();
                a.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(Text = "Usuario incorrecto, vuelva a intentar");
            }

            var patentesUsuario = Security.Security.VerificarPatente();

            var listDetallePatente = new List<string>();

            foreach (var patente in patentesUsuario)
            {
                listDetallePatente.Add(Encriptacion.Encriptacion.DecryptString(patente.Detalle));
            }

            if (listDetallePatente != null)
            {
                if (listDetallePatente.Contains(""))
                {

                }
                   
            }
            else
            {
                MessageBox.Show(Text = "El usuario con el que intenta ingresar no tiene permisos asignados");
            }
            
                  
        }

        private void registrarUsuarioBtn_Click(object sender, EventArgs e)
        {
            var alta = new AltaUsuario();
            alta.Show();
            this.Close();
        }
    }
}
