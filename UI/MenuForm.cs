using BLL.Services;
using DAL.Models;
using System;
using System.Collections.Generic;
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
        private DvvService _dvvService;
        private BindingSource userBindingSource = new BindingSource();
        private FamiliaUsuarioService _familiaUsuarioService;
        private BitacoraService _bitacoraService;
        private BindingSource quitarPatenteBindingSource = new BindingSource();
        private BindingSource asignarPatenteBindingSource = new BindingSource();
        private BindingSource asignarPatenteBindingSource2 = new BindingSource();
        private int recalcularDvvCounter { get; set; }
        public MenuForm()
        {
            InitializeComponent();
            _altaPatenteService = new AltaPatenteService();
            _altaUsuarioService = new AltaUsuarioService();
            _patenteUsuarioService = new PatenteUsuarioService();
            _familiaUsuarioService = new FamiliaUsuarioService();
            _dvvService = new DvvService();
            _bitacoraService = new BitacoraService();
            recalcularDvvCounter = 0;
            var patentes = _altaPatenteService.GetAll();

            foreach (var patente in patentes)
            {
                patente.Detalle = Encriptacion.Encriptacion.DecryptString(patente.Detalle);
            }
            patenteDataGrid.DataSource = patentes;

            var usuarios = _altaUsuarioService.GetAll();

            foreach (var usuario in usuarios)
            {
                usuario.Dni = Encriptacion.Encriptacion.DecryptString(usuario.Dni);
            }
            usuarioDataGrid.DataSource = usuarios;
            selectUserDataGrid.DataSource = usuarios;
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
            //var patenteUsuario = _patenteUsuarioService.GetAll();
            //var usuariosSinPatente = _altaUsuarioService.GetAll().Where(x => patenteUsuario.All(y => y.IdUsuario != x.IdUsuario));

            //var familiausuario = _familiaUsuarioService.GetAll();
            //var familiasSinPatente = familiausuario.Where(x => x.)

            //foreach (var usuario in usuariosSinPatente)
            //{
            //    var familiaUsuario = new FamiliaUsuario();
            //    familiaUsuario.IdUsuario = usuario.IdUsuario;
            //    _familiaUsuarioService.Delete(familiaUsuario);
            //    _altaUsuarioService.Delete(usuario);
            //}
            
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
            var patentesUsuario = _patenteUsuarioService.GetAll().Where(x => x.IdUsuario == int.Parse(idUsuario)).ToList();

            if (patenteDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = patenteDataGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = patenteDataGrid.Rows[selectedrowindex];
                idPatente = Convert.ToString(selectedRow.Cells["IdPatente"].Value);
            }

            var esPatenteRepetida = patentesUsuario.Where(x => x.IdPatente == int.Parse(idPatente)).Count() == 1 ? true : false;

            if (!esPatenteRepetida)
            {
                PatenteUsuario asignacion = new PatenteUsuario();
                asignacion.IdPatente = int.Parse(idPatente);
                asignacion.IdUsuario = int.Parse(idUsuario);
                string dvhConcat = $"{asignacion.IdPatente}{asignacion.IdUsuario}";
                asignacion.Dvh = Security.Security.CrearDVH(dvhConcat);
                _patenteUsuarioService.Insert(asignacion);

                var concatDvh = $"{2}{DateTime.Now}{Security.Security.LoggedUser.IdUsuario}{"Patente Asignada"}";
                Bitacora bitacora = new Bitacora()
                {
                    Criticidad = 2,
                    Fecha = DateTime.Now,
                    IdUsuario = Security.Security.LoggedUser.IdUsuario,
                    Operacion = "Asignacion de Patente",
                    Dvh = Security.Security.CrearDVH(concatDvh)

                };

                _bitacoraService.Insert(bitacora);
            }
            else
            {
                MessageBox.Show(Text = "El Usuario ya posee la Patente que intenta asignar");
            }

            var dvv = new Dvv();
            _dvvService.Update(dvv);



            //var usuarios = _altaUsuarioService.GetAll();

            //foreach (var usuario in usuarios)
            //{
            //    usuario.Dni = Encriptacion.Encriptacion.DecryptString(usuario.Dni);
            //}

            //asignarPatenteBindingSource.DataSource = usuarios;
            //usuarioDataGrid.DataSource = asignarPatenteBindingSource;
        }

        private void altaUsuariosBtn_Click(object sender, EventArgs e)
        {
            var alta = new AltaUsuario(this);
            alta.Show();
            this.Hide();
        }

        private void verificarIntegridadBtn_Click(object sender, EventArgs e)
        {

            if (Security.Security.VerificarIntegridad() && Security.Security.VerificarIntegridadDvv() || recalcularDvvCounter > 0)
            {
                MessageBox.Show(Text = "No se encontraron inconsistencias de integridad");
            }
            else
            {
                
                var concatDvh = $"{2}{DateTime.Now}{Security.Security.LoggedUser.IdUsuario}{"Integridad Vulnerada"}";
                Bitacora bitacora = new Bitacora()
                {
                    Criticidad = 5,
                    Fecha = DateTime.Now,
                    IdUsuario = Security.Security.LoggedUser.IdUsuario,
                    Operacion = "Integridad Vulnerada",
                    Dvh = Security.Security.CrearDVH(concatDvh)

                };

                _bitacoraService.Insert(bitacora);

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
            string idUsuario = string.Empty;
            if (selectUserDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = selectUserDataGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = selectUserDataGrid.Rows[selectedrowindex];
                idUsuario = Convert.ToString(selectedRow.Cells["IdUsuario"].Value);
            }
          
            //var patentesUsuario = _patenteUsuarioService.GetAll().Where(x => x.IdUsuario == int.Parse(idUsuario)).Distinct();
            var ocurrenciaPatentes = _patenteUsuarioService.GetAll().GroupBy(x => x.IdPatente).ToDictionary(x => x.Key , x => x.Count());
            //var familiasUsuario = _familiaUsuarioService.GetAll().Where(x => x.IdUsuario == int.Parse(idUsuario));

            //var countPatenteUsuario = _patenteUsuarioService.GetAll().Where(x => patentesUsuario.Any(y => y.IdPatente == x.IdPatente)).Count();
            //var countFamiliaUsuario = _familiaUsuarioService.GetAll().Where(x => familiasUsuario.All(y => y.IdFamilia == x.IdFamilia)).Count();

            string idPatenteUsuario = string.Empty;
            string idPatente = string.Empty;
            if (patenteUsuarioDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = patenteUsuarioDataGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = patenteUsuarioDataGrid.Rows[selectedrowindex];
                idPatenteUsuario = Convert.ToString(selectedRow.Cells["IdPatenteUsuario"].Value);
                idPatente = Convert.ToString(selectedRow.Cells["IdPatente"].Value);
            }

            //countFamiliaUsuario > 1 || 
            if (ocurrenciaPatentes.ContainsKey(int.Parse(idPatente)) && ocurrenciaPatentes[int.Parse(idPatente)] > 1)
            {
                

                var currentPatenteUsuario = _patenteUsuarioService.GetAll().Where(x => x.IdPatenteUsuario == int.Parse(idPatenteUsuario)).FirstOrDefault();
                //PatenteUsuario baja = new PatenteUsuario();
                //baja.IdPatenteUsuario = int.Parse(idPatenteUsuario);
                _patenteUsuarioService.Delete(currentPatenteUsuario);
            }
            else if (ocurrenciaPatentes[int.Parse(idPatente)] == 1)
            {
                MessageBox.Show(Text = "Si Quita esta Patente, quedará huerfana");
            }

            var patentesUsuarios = _patenteUsuarioService.GetAll().Where(x => x.IdUsuario == int.Parse(idUsuario));
            quitarPatenteBindingSource.DataSource = patentesUsuarios;
            patenteUsuarioDataGrid.DataSource = quitarPatenteBindingSource;

            var dvv = new Dvv();
            _dvvService.Update(dvv);
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

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            var login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var bitacora = new BitacoraForm(this);
            bitacora.Show();
            this.Hide();
        }

        private void MenuForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                e.Handled = true;

                Help.ShowHelp(this, @"C:\Repos\booking-sample\UI\Helper\HelpEsp.chm", HelpNavigator.TopicId, "100");
            }
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(MenuForm_KeyDown);
        }

        private void irAdminUsuarioBtn_Click(object sender, EventArgs e)
        {
            var adminUsuario = new AdminUsuariosForm(this);
            adminUsuario.Show();
            this.Hide();
        }

        private void recalculardvvBtn_Click(object sender, EventArgs e)
        {
            recalcularDvvCounter++;
            var dvv = new Dvv();
            _dvvService.Update(dvv);
        }
    }
}
