using BLL.Services;
using DAL.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class AdminUsuariosForm : Form
    {
        private TraduccionService _traduccionService;
        private UserIdiomaService _userIdiomaService;
        private AltaUsuarioService _altaUsuarioService;
        private FamiliaUsuarioService _familiaUsuarioService;
        private PatenteUsuarioService _patenteUsuarioService;
        private PatenteFamiliaService _patenteFamiliaService;
        private BlockService _bloqueoService;
        private Form _form;
        private BindingSource userBindingSource = new BindingSource();
        private BindingSource blockedBindingSource = new BindingSource();
        
        public AdminUsuariosForm(Form form)
        {
            InitializeComponent();
            _traduccionService = new TraduccionService();
            _userIdiomaService = new UserIdiomaService();
            _altaUsuarioService = new AltaUsuarioService();
            _familiaUsuarioService = new FamiliaUsuarioService();
            _patenteUsuarioService = new PatenteUsuarioService();
            _patenteFamiliaService = new PatenteFamiliaService();
            _bloqueoService = new BlockService();
            _form = form;
        }

        private void AdminUsuariosForm_Load(object sender, EventArgs e)
        {
            Traducir();
            CargarDgv();
        }

        private void CargarDgv()
        {
            var usuarios = _altaUsuarioService.GetAll();
            foreach (var usuario in usuarios)
            {
                usuario.Dni = Encriptacion.Encriptacion.DecryptString(usuario.Dni);
            }
            userDgv.DataSource = usuarios;

            this.userDgv.Columns["Dvh"].Visible = false;
            this.userDgv.Columns["Backups"].Visible = false;
            this.userDgv.Columns["Bitacoras"].Visible = false;
            this.userDgv.Columns["FamiliaUsuarios"].Visible = false;
            this.userDgv.Columns["PatenteUsuarios"].Visible = false;
            this.userDgv.Columns["Reservas"].Visible = false;

            var bloqueos = _bloqueoService.GetAll();
            usuariosBloqueadosDgv.DataSource = bloqueos;
            this.usuariosBloqueadosDgv.Columns["IdBloqueo"].Visible = false;

        }
        private void borrarBtn_Click(object sender, EventArgs e)
        {
            string idUsuario = string.Empty;            
            if (userDgv.SelectedCells.Count > 0)
            {
                int selectedrowindex = userDgv.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = userDgv.Rows[selectedrowindex];
                idUsuario = Convert.ToString(selectedRow.Cells["IdUsuario"].Value);
            }

            var patentesUsuario = _patenteUsuarioService.GetAll().Where(x => x.IdUsuario == int.Parse(idUsuario));
            var familiasUsuario = _familiaUsuarioService.GetAll().Where(x => x.IdUsuario == int.Parse(idUsuario));

            var countPatenteUsuario = _patenteUsuarioService.GetAll().Where(x => patentesUsuario.All(y => y.IdPatente == x.IdPatente)).Count();
            var countFamiliaUsuario = _familiaUsuarioService.GetAll().Where(x => familiasUsuario.All(y => y.IdFamilia == x.IdFamilia)).Count();


            if (countFamiliaUsuario > 1 || countPatenteUsuario > 1)
            {
                foreach (var usuario in patentesUsuario)
                {
                    _patenteUsuarioService.Delete(usuario);
                }


                foreach (var usuario in familiasUsuario)
                {
                    _familiaUsuarioService.Delete(usuario);
                }

                var user = new Usuario();
                user.IdUsuario = int.Parse(idUsuario);
                _altaUsuarioService.Delete(user);
            }
            else if (countFamiliaUsuario == 1)
            {
                MessageBox.Show(Text = "Si Borra este Usuario, quedara la Familia huerfana");
            }
            else
            {
                MessageBox.Show(Text = "Si Borra este Usuario, quedara la Pattente huerfana");
            }

            var usuarios = _altaUsuarioService.GetAll();
            userBindingSource.DataSource = usuarios;
            userDgv.DataSource = userBindingSource;
        }

        private void Traducir()
        {
            var currentUser = Security.Security.LoggedUser;

            var isEngilsh = _userIdiomaService.GetAll().Where(x => x.IdUser == currentUser.IdUsuario).FirstOrDefault().IdIdioma == 2 ? true : false;

            var traducciones = _traduccionService.GetAll();

            if (isEngilsh)
            {
                foreach (var item in traducciones.Where(x => x.Formulario == this.Name))
                {
                    if (altaBtn.Text == item.txtEspanio)
                    {
                        altaBtn.Text = item.txtIngles;
                    }
                    else if (bloquearBtn.Text == item.txtEspanio)
                    {
                        bloquearBtn.Text = item.txtIngles;
                    }
                    else if (borrarBtn.Text == item.txtEspanio)
                    {
                        borrarBtn.Text = item.txtIngles;
                    }
                    else if (modificarBtn.Text == item.txtEspanio)
                    {
                        modificarBtn.Text = item.txtIngles;
                    }
                    else if (desbloquearBtn.Text == item.txtEspanio)
                    {
                        desbloquearBtn.Text = item.txtIngles;
                    }
                    else if (volverBtn.Text == item.txtEspanio)
                    {
                        volverBtn.Text = item.txtIngles;
                    }
                    else if (modificaBox.Text == item.txtEspanio)
                    {
                        modificaBox.Text = item.txtIngles;
                    }
                    else if (nombreLbl.Text == item.txtEspanio)
                    {
                        nombreLbl.Text = item.txtIngles;
                    }
                    else if (apellidoLbl.Text == item.txtEspanio)
                    {
                        apellidoLbl.Text = item.txtIngles;
                    }
                    else if (contactoLbl.Text == item.txtEspanio)
                    {
                        contactoLbl.Text = item.txtIngles;
                    }

                }
            }

        }

        private void altaBtn_Click(object sender, EventArgs e)
        {
            var alta = new AltaUsuario(this);
            alta.Show();
            this.Hide();
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            string idUsuario = string.Empty;
            if (userDgv.SelectedCells.Count > 0)
            {
                int selectedrowindex = userDgv.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = userDgv.Rows[selectedrowindex];
                idUsuario = Convert.ToString(selectedRow.Cells["IdUsuario"].Value);
            }

            var usuario = _altaUsuarioService.GetAll().Where(x => x.IdUsuario == int.Parse(idUsuario)).FirstOrDefault();

            if ((nombreTxt.Text == string.Empty && apellidoTxt.Text == string.Empty) && contactoTxt.Text == string.Empty)
            {
                MessageBox.Show(Text = "Error");
            }

            if (nombreTxt.Text != string.Empty)
            {
                usuario.Nombre = nombreTxt.Text;
            }
            else if (apellidoTxt.Text != string.Empty)
            {
                usuario.Apellido = apellidoTxt.Text;
            }
            else if (contactoTxt.Text != string.Empty)
            {
                usuario.Contacto = contactoTxt.Text;
            }

            _altaUsuarioService.Update(usuario);

            var usuarios = _altaUsuarioService.GetAll();
            userBindingSource.DataSource = usuarios;
            userDgv.DataSource = userBindingSource;

        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            _form.Show();
            this.Close();
        }

        private void desbloquearBtn_Click(object sender, EventArgs e)
        {
            string idBloqueo = string.Empty;
            if (usuariosBloqueadosDgv.SelectedCells.Count > 0)
            {
                int selectedrowindex = usuariosBloqueadosDgv.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = usuariosBloqueadosDgv.Rows[selectedrowindex];
                idBloqueo = Convert.ToString(selectedRow.Cells["IdBloqueo"].Value);
            }

            var bloquear = new Bloqueo();
            bloquear.IdBloqueo = int.Parse(idBloqueo);
            _bloqueoService.Delete(bloquear);

            var bloqueos = _bloqueoService.GetAll();
            blockedBindingSource.DataSource = bloqueos;
            usuariosBloqueadosDgv.DataSource = blockedBindingSource;
        }

        private void bloquearBtn_Click(object sender, EventArgs e)
        {
            string idUsuario = string.Empty;
            if (userDgv.SelectedCells.Count > 0)
            {
                int selectedrowindex = userDgv.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = userDgv.Rows[selectedrowindex];
                idUsuario = Convert.ToString(selectedRow.Cells["IdUsuario"].Value);
            }

            var bloquear = new Bloqueo();
            bloquear.Bloqueado = "True";
            bloquear.IdUsuario = int.Parse(idUsuario);
            _bloqueoService.Insert(bloquear);

            var bloqueos = _bloqueoService.GetAll();
            blockedBindingSource.DataSource = bloqueos;
            usuariosBloqueadosDgv.DataSource = blockedBindingSource;
        }
    }
}
