using BE.ViewModels;
using BLL.Services;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class LoginForm : Form
    {
        private LoginService _LoginService;
        private PatenteUsuarioService _patenteUsuarioService;
        private AltaUsuarioService _altaUsuarioService; 
        private BitacoraService _BitacoraService;
        private BlockService _blockService;
        
        public LoginForm()
        {
            InitializeComponent();
            _LoginService = new LoginService();
            _patenteUsuarioService = new PatenteUsuarioService();
            _altaUsuarioService = new AltaUsuarioService();
            _BitacoraService = new BitacoraService();
            _blockService = new BlockService();
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
                var isBlocked = _blockService.GetAll().Where(x => x.IdUsuario == Security.Security.LoggedUser.IdUsuario).FirstOrDefault();

                if (isBlocked != null && isBlocked.Bloqueado == "True")
                {
                    MessageBox.Show(Text = "Usuario bloqueado");
                }
                else
                {
                    var patentesUsuario = Security.Security.VerificarPatente();
                    var familiaUsuario = Security.Security.VerificarFamilia();
                    var listPatentesDeFamilias = new List<int?>();


                    var concatDvh = $"{1}{DateTime.Now}{Security.Security.LoggedUser.IdUsuario}{"Usuario Loggead"}";
                    Bitacora bitacora = new Bitacora()
                    {
                        Criticidad = 1,
                        Fecha = DateTime.Now,
                        IdUsuario = Security.Security.LoggedUser.IdUsuario,
                        Operacion = "Usuario Loggeado",
                        Dvh = Security.Security.CrearDVH(concatDvh)

                    };

                    _BitacoraService.Insert(bitacora);

                    if (familiaUsuario != null)
                    {
                        listPatentesDeFamilias = familiaUsuario.SelectMany(x => x.Value).Distinct().ToList();
                    }


                    if (patentesUsuario != null || familiaUsuario != null)
                    {
                        var listDetallePatente = new List<int>();

                        if (patentesUsuario != null)
                        {
                            foreach (var patente in patentesUsuario)
                            {
                                listDetallePatente.Add(patente.IdPatente);
                            }

                        }

                        if (listDetallePatente != null || listPatentesDeFamilias.Count > 0)
                        {

                            if (listDetallePatente.Exists(x => x.Equals(1)) || listPatentesDeFamilias.Exists(x => x.Equals(1)))
                            {
                                var securityFrom = new MenuForm();
                                securityFrom.Show();
                                this.Close();

                                //var a = new BackupABM();
                                //a.Show();
                                //this.Close();
                            }

                            if (listDetallePatente.Exists(x => x.Equals(2)) || listPatentesDeFamilias.Exists(x => x.Equals(2)))
                            {
                                var clientForm = new AdminReservas();
                                clientForm.Show();
                                this.Close();
                            }

                            if (listDetallePatente.Exists(x => x.Equals(3)) || listPatentesDeFamilias.Exists(x => x.Equals(3)))
                            {
                                var reservasForm = new AltaReservasForm();
                                reservasForm.Show();
                                this.Close();
                            }

                            if (listDetallePatente.Exists(x => x.Equals(4)) || listPatentesDeFamilias.Exists(x => x.Equals(4)))
                            {
                                var ordenCompra = new OrdenCompraForm();
                                ordenCompra.Show();
                                this.Close();
                            }
                        }
                    }
                    else if (patentesUsuario == null || familiaUsuario == null)
                    {
                        MessageBox.Show(Text = "El usuario con el que intenta ingresar no tiene permisos asignados");
                    }
                }               
                
            }
            else if(loginTry < 4)
            {
                loginTry++;
                MessageBox.Show(Text = "La contraseña o usuario son incorrectos, vuelva a intentar");
            }

        }

        private void registrarUsuarioBtn_Click(object sender, EventArgs e)
        {
            var alta = new AltaUsuario(this);
            alta.Show();
            this.Hide();
        }
    }
}
