using BLL.Services;
using DAL.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class MenuForm : Form
    {
        private AltaUsuarioService _altaUsuarioService;
        private AltaPatenteService _altaPatenteService;
        private PatenteUsuarioService _patenteUsuarioService;
        private BindingSource userBindingSource = new BindingSource();
        public MenuForm()
        {
            InitializeComponent();
            _altaPatenteService = new AltaPatenteService();
            _altaUsuarioService = new AltaUsuarioService();
            _patenteUsuarioService = new PatenteUsuarioService();

            var patentes = _altaPatenteService.GetAll();

            foreach (var patente in patentes)
            {
                patente.Detalle = Encriptacion.Encriptacion.DecryptString(patente.Detalle);
            }
            patenteDataGrid.DataSource = patentes;
            usuarioDataGrid.DataSource = _altaUsuarioService.GetAll();
            selectUserDataGrid.DataSource = _altaUsuarioService.GetAll();
            //patenteUsuarioDataGrid.DataSource = _patenteUsuarioService.GetAll();            


            this.usuarioDataGrid.Columns["Dvh"].Visible = false;
            this.usuarioDataGrid.Columns["Backups"].Visible = false;
            this.usuarioDataGrid.Columns["Bitacoras"].Visible = false;
            this.usuarioDataGrid.Columns["FamiliaUsuarios"].Visible = false;
            this.usuarioDataGrid.Columns["PatenteUsuarios"].Visible = false;
            this.usuarioDataGrid.Columns["Reservas"].Visible = false;

            this.selectUserDataGrid.Columns["Dvh"].Visible = false;
            this.selectUserDataGrid.Columns["Backups"].Visible = false;
            this.selectUserDataGrid.Columns["Bitacoras"].Visible = false;
            this.selectUserDataGrid.Columns["FamiliaUsuarios"].Visible = false;
            this.selectUserDataGrid.Columns["PatenteUsuarios"].Visible = false;
            this.selectUserDataGrid.Columns["Reservas"].Visible = false;
            this.selectUserDataGrid.Columns["ContraseA"].Visible = false;
            this.selectUserDataGrid.Columns["Dni"].Visible = false;
            this.selectUserDataGrid.Columns["Contacto"].Visible = false;

            this.patenteDataGrid.Columns["Dvh"].Visible = false;
            this.patenteDataGrid.Columns["PatenteFamilia"].Visible = false;
            this.patenteDataGrid.Columns["PatenteUsuarios"].Visible = false;

            
        }
        
        private void borrarUserSinPatenteBtn_Click(object sender, EventArgs e)
        {
            var patenteUsuario = _patenteUsuarioService.GetAll();
            var usuariosSinPatente = _altaUsuarioService.GetAll().Where(x => patenteUsuario.All(y => y.IdUsuario != x.IdUsuario));

            foreach (var usuario in usuariosSinPatente)
            {
                _altaUsuarioService.Delete(usuario);
            }
            
        }

        private void asignarPatenteBtn_Click(object sender, EventArgs e)
        {
            string idUsuario = string.Empty;
            string idPatente = string.Empty;
            if (usuarioDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = usuarioDataGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = usuarioDataGrid.Rows[selectedrowindex];
                idUsuario = Convert.ToString(selectedRow.Cells["IdUsuario"].Value);
            }

            if (patenteDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = patenteDataGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = patenteDataGrid.Rows[selectedrowindex];
                idPatente = Convert.ToString(selectedRow.Cells["IdPatente"].Value);
            }

            PatenteUsuario asignacion = new PatenteUsuario();
            asignacion.IdPatente = int.Parse(idPatente);
            asignacion.IdUsuario = int.Parse(idUsuario);
            string dvhConcat = $"{asignacion.IdPatente}{asignacion.IdUsuario}";
            asignacion.Dvh = Security.Security.CrearDVH(dvhConcat);
            _patenteUsuarioService.Insert(asignacion);

        }

        private void altaUsuariosBtn_Click(object sender, EventArgs e)
        {
            var alta = new AltaUsuario();
            alta.Show();
            this.Close();
        }

        private void verificarIntegridadBtn_Click(object sender, EventArgs e)
        {
            if (Security.Security.VerificarIntegridad())
            {
                MessageBox.Show(Text = "No se encontraron inconsistencias de integridad");
            }
            else
            {
                MessageBox.Show(Text = "La integridad de la Base de Datos se encuentra comprometida");
            }
        }

        private void selectUserDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idUsuario = string.Empty;
            if (usuarioDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = selectUserDataGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = selectUserDataGrid.Rows[selectedrowindex];
                idUsuario = Convert.ToString(selectedRow.Cells["IdUsuario"].Value);
                var patentesUsuarios = _patenteUsuarioService.GetAll().Where(x => x.IdUsuario == int.Parse(idUsuario));
                userBindingSource.DataSource = patentesUsuarios;
                patenteUsuarioDataGrid.DataSource = userBindingSource;
                patenteDataGrid.Refresh();

                try
                {
                    var hasPatente = patentesUsuarios.ToList();
                    if (hasPatente.Count > 0)
                    {
                        this.patenteUsuarioDataGrid.Columns["Dvh"].Visible = false;
                        this.patenteUsuarioDataGrid.Columns["IdPatenteNavigation"].Visible = false;
                        this.patenteUsuarioDataGrid.Columns["IdUsuarioNavigation"].Visible = false;
                    }
                    else
                    {
                        MessageBox.Show(Text = "No se encontraron Patentes asignadas a este Usuario");
                    }

                }
                catch (NullReferenceException)
                {
                    MessageBox.Show(Text = "No se encontraron Patentes asignadas a este Usuario");
                }

                

            }

        }

        private void quitarPatenteBtn_Click(object sender, EventArgs e)
        {           
            string idPatenteUsuario = string.Empty;               

            if (patenteUsuarioDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = patenteUsuarioDataGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = patenteUsuarioDataGrid.Rows[selectedrowindex];
                idPatenteUsuario = Convert.ToString(selectedRow.Cells["IdPatenteUsuario"].Value);
            }

            PatenteUsuario baja = new PatenteUsuario();
            baja.IdPatenteUsuario = int.Parse(idPatenteUsuario);
            _patenteUsuarioService.Delete(baja);
            
        }

        private void bajaUsuario7Btn_Click(object sender, EventArgs e)
        {
            var patenteusuario = _patenteUsuarioService.GetAll().Where(x => x.IdUsuario == 7);

            foreach (var patente in patenteusuario)
            {
                _patenteUsuarioService.Delete(patente);
            }

            Usuario usuario = new Usuario();
            usuario.IdUsuario = 7;

            _altaUsuarioService.Delete(usuario);
        }

        private void adminFamiliaBtn_Click(object sender, EventArgs e)
        {
            var adminFamilia = new AdminFamilia();
            adminFamilia.Show();
            this.Close();
        }

        private void irBackupBtn_Click(object sender, EventArgs e)
        {
            var backupForm = new BackupABM();
            backupForm.Show();
            this.Close();
        }
    }
}
