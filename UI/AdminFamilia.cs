using BLL.Services;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class AdminFamilia : Form
    {
        private AltaUsuarioService _altaUsuarioService;
        private AltaPatenteService _altaPatenteService;
        private FamiliaService _familiaService;
        private FamiliaUsuarioService _familiaUsuarioService;
        private PatenteFamiliaService _patenteFamiliaService;
        private BindingSource familiaBindingSource = new BindingSource();
        private BindingSource familiaDataGridBinding = new BindingSource();
        private BindingSource selectDropFamiliyBinding = new BindingSource();
        private BindingSource asignFamiliyUserBinding = new BindingSource();
        private BindingSource dropFamiliyUserBinding = new BindingSource();
        private BindingSource deleteBajaFamiliaBinding = new BindingSource();

        public AdminFamilia()
        {
            InitializeComponent();
            _altaUsuarioService = new AltaUsuarioService();
            _altaPatenteService = new AltaPatenteService();
            _familiaService = new FamiliaService();
            _familiaUsuarioService = new FamiliaUsuarioService();
            _patenteFamiliaService = new PatenteFamiliaService();

            var patentes = _altaPatenteService.GetAll();

            foreach (var patente in patentes)
            {
                patente.Detalle = Encriptacion.Encriptacion.DecryptString(patente.Detalle);
            }

            patenteDataGrid.DataSource = patentes;
            this.patenteDataGrid.Columns["Dvh"].Visible = false;
            this.patenteDataGrid.Columns["PatenteFamilia"].Visible = false;
            this.patenteDataGrid.Columns["PatenteUsuarios"].Visible = false;

            familiaDataGrid.DataSource = _familiaService.GetAll();
            this.familiaDataGrid.Columns["Dvh"].Visible = false;
            this.familiaDataGrid.Columns["FamiliaUsuarios"].Visible = false;
            this.familiaDataGrid.Columns["PatenteFamilia"].Visible = false;

            familiasAltaDataGrid.DataSource = _familiaService.GetAll();
            this.familiasAltaDataGrid.Columns["Dvh"].Visible = false;
            this.familiasAltaDataGrid.Columns["FamiliaUsuarios"].Visible = false;
            this.familiasAltaDataGrid.Columns["PatenteFamilia"].Visible = false;

            selectDropFamiliyDataGrid.DataSource = _familiaService.GetAll();
            this.selectDropFamiliyDataGrid.Columns["Dvh"].Visible = false;
            this.selectDropFamiliyDataGrid.Columns["FamiliaUsuarios"].Visible = false;
            this.selectDropFamiliyDataGrid.Columns["PatenteFamilia"].Visible = false;

            asignUsersDatagrid.DataSource = _altaUsuarioService.GetAll();
            this.asignUsersDatagrid.Columns["Dvh"].Visible = false;
            this.asignUsersDatagrid.Columns["Backups"].Visible = false;
            this.asignUsersDatagrid.Columns["Bitacoras"].Visible = false;
            this.asignUsersDatagrid.Columns["FamiliaUsuarios"].Visible = false;
            this.asignUsersDatagrid.Columns["PatenteUsuarios"].Visible = false;
            this.asignUsersDatagrid.Columns["Reservas"].Visible = false;

            asignFamiliyUserDatagrid.DataSource = _familiaService.GetAll();
            this.asignFamiliyUserDatagrid.Columns["Dvh"].Visible = false;
            this.asignFamiliyUserDatagrid.Columns["FamiliaUsuarios"].Visible = false;
            this.asignFamiliyUserDatagrid.Columns["PatenteFamilia"].Visible = false;

            selectDropUserFamiliDataGrid.DataSource = _altaUsuarioService.GetAll();
            this.selectDropUserFamiliDataGrid.Columns["Dvh"].Visible = false;
            this.selectDropUserFamiliDataGrid.Columns["Backups"].Visible = false;
            this.selectDropUserFamiliDataGrid.Columns["Bitacoras"].Visible = false;
            this.selectDropUserFamiliDataGrid.Columns["FamiliaUsuarios"].Visible = false;
            this.selectDropUserFamiliDataGrid.Columns["PatenteUsuarios"].Visible = false;
            this.selectDropUserFamiliDataGrid.Columns["Reservas"].Visible = false;

            deleteBajaFamiliaDataGrid.DataSource = _familiaService.GetAll();
            this.deleteBajaFamiliaDataGrid.Columns["Dvh"].Visible = false;
            this.deleteBajaFamiliaDataGrid.Columns["FamiliaUsuarios"].Visible = false;
            this.deleteBajaFamiliaDataGrid.Columns["PatenteFamilia"].Visible = false;
        }

        private void crearFamiliaBtn_Click(object sender, EventArgs e)
        {
            var altaFamilia = new Familia();
            altaFamilia.Detalle = altaFamiliaTxt.Text;
            string dvhConcat = $"{altaFamilia.Detalle}";
            altaFamilia.Dvh = Security.Security.CrearDVH(dvhConcat);
            _familiaService.Insert(altaFamilia);

            familiasAltaDataGrid.DataSource = _familiaService.GetAll();

            familiaDataGridBinding.DataSource = _familiaService.GetAll();
            familiaDataGrid.DataSource = familiaDataGridBinding;

            selectDropFamiliyBinding.DataSource = _familiaService.GetAll();
            selectDropFamiliyDataGrid.DataSource = selectDropFamiliyBinding;

            asignFamiliyUserBinding.DataSource = _familiaService.GetAll();
            asignFamiliyUserDatagrid.DataSource = asignFamiliyUserBinding;

            deleteBajaFamiliaBinding.DataSource = _familiaService.GetAll();
            deleteBajaFamiliaDataGrid.DataSource = deleteBajaFamiliaBinding;

        }

        private void asignPatenteBtn_Click(object sender, EventArgs e)
        {
            string idFamilia = string.Empty;
            string idPatente = string.Empty;
            if (familiaDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = familiaDataGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = familiaDataGrid.Rows[selectedrowindex];
                idFamilia = Convert.ToString(selectedRow.Cells["IdFamilia"].Value);
            }

            if (patenteDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = patenteDataGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = patenteDataGrid.Rows[selectedrowindex];
                idPatente = Convert.ToString(selectedRow.Cells["IdPatente"].Value);
            }

            PatenteFamilium asignacion = new PatenteFamilium();
            asignacion.IdPatente = int.Parse(idPatente);
            asignacion.IdFamilia = int.Parse(idFamilia);
            string dvhConcat = $"{asignacion.IdPatente}{asignacion.IdFamilia}";
            asignacion.Dvh = Security.Security.CrearDVH(dvhConcat);
            _patenteFamiliaService.Insert(asignacion);
        }

        private void quitarPatenteBtn_Click(object sender, EventArgs e)
        {
            string idPatenteFamilia = string.Empty;

            if (selectDropPatenteDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = selectDropPatenteDataGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = selectDropPatenteDataGrid.Rows[selectedrowindex];
                idPatenteFamilia = Convert.ToString(selectedRow.Cells["IdPatenteFamilia"].Value);
            }

            PatenteFamilium baja = new PatenteFamilium();
            baja.IdPatenteFamilia = int.Parse(idPatenteFamilia);
            _patenteFamiliaService.Delete(baja);
        }

        private void selectDropFamiliyDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idFamilia = string.Empty;
            if (selectDropFamiliyDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = selectDropFamiliyDataGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = selectDropFamiliyDataGrid.Rows[selectedrowindex];
                idFamilia = Convert.ToString(selectedRow.Cells["IdFamilia"].Value);
                var patenteFamilia = _patenteFamiliaService.GetAll().Where(x => x.IdFamilia == int.Parse(idFamilia));
                familiaBindingSource.DataSource = patenteFamilia;
                selectDropPatenteDataGrid.DataSource = familiaBindingSource;

                try
                {
                    var hasPatente = patenteFamilia.ToList();
                    if (hasPatente.Count > 0)
                    {
                        this.selectDropPatenteDataGrid.Columns["Dvh"].Visible = false;
                        this.selectDropPatenteDataGrid.Columns["IdFamiliaNavigation"].Visible = false;
                        this.selectDropPatenteDataGrid.Columns["IdPatenteNavigation"].Visible = false;
                        this.selectDropPatenteDataGrid.Columns["IdPatenteFamilia"].Visible = false;
                    }
                    else
                    {
                        MessageBox.Show(Text = "No se encontraron Patentes asignadas a esta Familia");
                    }
                    
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show(Text = "No se encontraron Patentes asignadas a esta Familia");
                }                 
            }
        }

        private void asignarFamiliaUsuarioBtn_Click(object sender, EventArgs e)
        {
            string idUsuario = string.Empty;
            string idFamilia = string.Empty;
            if (asignUsersDatagrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = asignUsersDatagrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = asignUsersDatagrid.Rows[selectedrowindex];
                idUsuario = Convert.ToString(selectedRow.Cells["IdUsuario"].Value);
            }

            if (asignFamiliyUserDatagrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = asignFamiliyUserDatagrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = asignFamiliyUserDatagrid.Rows[selectedrowindex];
                idFamilia = Convert.ToString(selectedRow.Cells["IdFamilia"].Value);
            }

            FamiliaUsuario asignacion = new FamiliaUsuario();
            asignacion.IdFamilia = int.Parse(idFamilia);
            asignacion.IdUsuario = int.Parse(idUsuario);
            string dvhConcat = $"{asignacion.IdFamilia}{asignacion.IdUsuario}";
            asignacion.Dvh = Security.Security.CrearDVH(dvhConcat);
            _familiaUsuarioService.Insert(asignacion);
        }

        private void quitarFamiliaUsuarioBtn_Click(object sender, EventArgs e)
        {
            string idFamiliaUsuario = string.Empty;

            if (selectDropFamilyUserDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = selectDropFamilyUserDataGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = selectDropFamilyUserDataGrid.Rows[selectedrowindex];
                idFamiliaUsuario = Convert.ToString(selectedRow.Cells["IdFamiliaUsuario"].Value);
            }

            FamiliaUsuario baja = new FamiliaUsuario();
            baja.IdFamiliaUsuario = int.Parse(idFamiliaUsuario);
            _familiaUsuarioService.Delete(baja);
        }

        private void selectDropUserFamiliDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idUsuario = string.Empty;
            if (selectDropUserFamiliDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = selectDropUserFamiliDataGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = selectDropUserFamiliDataGrid.Rows[selectedrowindex];
                idUsuario = Convert.ToString(selectedRow.Cells["IdUsuario"].Value);
                var familiaUsuario = _familiaUsuarioService.GetAll().Where(x => x.IdUsuario == int.Parse(idUsuario));
                dropFamiliyUserBinding.DataSource = familiaUsuario;
                selectDropFamilyUserDataGrid.DataSource = dropFamiliyUserBinding;                

                try
                {
                    var hasFamilia = familiaUsuario.ToList();
                    if (hasFamilia.Count > 0)
                    {
                        this.selectDropFamilyUserDataGrid.Columns["Dvh"].Visible = false;
                        this.selectDropFamilyUserDataGrid.Columns["IdFamiliaNavigation"].Visible = false;
                        this.selectDropFamilyUserDataGrid.Columns["IdUsuarioNavigation"].Visible = false;
                        this.selectDropFamilyUserDataGrid.Columns["IdFamiliaUsuario"].Visible = false;
                    }
                    else
                    {
                        MessageBox.Show(Text = "No se encontraron Familias asignadas a esta Usuario");
                    }

                }
                catch (NullReferenceException)
                {
                    MessageBox.Show(Text = "No se encontraron Familias asignadas a esta Usuario");
                }
            }
        }

        private void bajaDeleteFamiliaBtn_Click(object sender, EventArgs e)
        {
            string idFamilia = string.Empty;
            if (deleteBajaFamiliaDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = deleteBajaFamiliaDataGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = deleteBajaFamiliaDataGrid.Rows[selectedrowindex];
                idFamilia = Convert.ToString(selectedRow.Cells["IdFamilia"].Value);
            }

            var patenteFamilia = _patenteFamiliaService.GetAll().Where(x => x.IdFamilia == int.Parse(idFamilia));            

            foreach (var patente in patenteFamilia)
            {
                _patenteFamiliaService.Delete(patente);
            }

            var familiaUsuario = _familiaUsuarioService.GetAll().Where(x => x.IdFamilia == int.Parse(idFamilia));

            foreach (var familia in familiaUsuario)
            {
                _familiaUsuarioService.Delete(familia);
            }

            Familia familiaBaja = new Familia();
            familiaBaja.IdFamilia = int.Parse(idFamilia);

            _familiaService.Delete(familiaBaja);
        }

        private void volverPatentesBtn_Click(object sender, EventArgs e)
        {
            var adminPatentes = new MenuForm();
            adminPatentes.Show();
            this.Close();
        }
    }
}
