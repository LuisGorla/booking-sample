using BLL.Services;
using DAL.Models;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class AltaUsuario : Form
    {
        private AltaUsuarioService _altaUsuarioService;
        public AltaUsuario()
        {
            InitializeComponent();
            _altaUsuarioService = new AltaUsuarioService();
        }

        private void RegistrarBtn_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();            
            usuario.Nombre = nombreTxt.Text;
            usuario.Apellido = apellidoTxt.Text;
            usuario.Dni = Encriptacion.Encriptacion.EncryptString(dniTxt.Text);
            usuario.ContraseA = Encriptacion.Encriptacion.EncriptarIrreversible(contraseñaTxt.Text);
            usuario.Contacto = contactoTxt.Text;
            string dvhConcat = $"{usuario.Nombre}{usuario.Apellido}{usuario.Dni}{usuario.ContraseA}{usuario.Contacto}";
            usuario.Dvh = Security.Security.CrearDVH(dvhConcat);
            _altaUsuarioService.Insert(usuario);            
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            var login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}
