using BLL.Services;
using DAL.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class AltaUsuario : Form
    {
        private AltaUsuarioService _altaUsuarioService;
        private Form _form;
        private IdiomaService _idiomaService;
        private UserIdiomaService _userIdioma;
        private DvvService _dvvService;
        public AltaUsuario(Form form)
        {
            InitializeComponent();
            _form = form;
            _altaUsuarioService = new AltaUsuarioService();
            _idiomaService = new IdiomaService();
            _userIdioma = new UserIdiomaService();
            _dvvService = new DvvService();
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

            var currentUser = _altaUsuarioService.GetAll().Where(x => x.Dni == usuario.Dni).FirstOrDefault();
            var useridioma = new UserIdioma();
            useridioma.IdUser = currentUser.IdUsuario;
            useridioma.IdIdioma = ((Idioma)idiomaCombo.SelectedItem).IdIdioma;
            _userIdioma.Insert(useridioma);

            var dvv = new Dvv();
            _dvvService.Update(dvv);
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            //var login = new LoginForm();
            _form.Show();
            this.Close();
        }

        private void cargarCombo()
        {
            var idiomas = _idiomaService.GetAll();

            foreach (var idioma in idiomas)
            {
                idiomaCombo.Items.Add(idioma);
                idiomaCombo.DisplayMember = "Detalle";
            }
        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            cargarCombo();
        }
    }
}
