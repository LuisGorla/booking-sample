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
            int loginTry = 0;

            var usuario = new LoginViewModel {
                DNI = Usuariotxt.Text,
                Password = Encriptacion.Encriptacion.EncriptarIrreversible(Passwordtxt.Text)
            };

            if (_LoginService.LoginUser(usuario))
            {
                var patentesUsuario = Security.Security.VerificarPatente();
                if (patentesUsuario != null)
                {
                    var listDetallePatente = new List<int>();

                    foreach (var patente in patentesUsuario)
                    {
                        listDetallePatente.Add(patente.IdPatente);
                    }

                    if (_LoginService.LoginUser(usuario) && listDetallePatente != null)
                    {

                        if (listDetallePatente.Contains(1))
                        {
                            var securityFrom = new MenuForm();
                            securityFrom.Show();
                            this.Close();

                            //var a = new BackupABM();
                            //a.Show();
                            //this.Close();
                        }

                        if (listDetallePatente.Contains(2))
                        {

                        }

                    }
                }
                else if (patentesUsuario == null)
                {
                    MessageBox.Show(Text = "El usuario con el que intenta ingresar no tiene permisos asignados");
                }               
                
            }
            else if(loginTry < 4)
            {
                loginTry++;
                MessageBox.Show(Text = "La contraseña o usuario son incorrectos, vuelva a intentar");
            }
            else
            {
                MessageBox.Show(Text = "Demasiados intentos, vuelva a intentarlo más tarde");
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
