using BLL.Services;
using DAL.Models;
using System;
using System.Collections;
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
    public partial class MenuForm : Form
    {
        private AltaUsuarioService _altaUsuarioService;
        private AltaPatenteService _altaPatenteService;
        private PatenteUsuarioService _patenteUsuarioService;
        public MenuForm()
        {
            InitializeComponent();
            _altaPatenteService = new AltaPatenteService();
            _altaUsuarioService = new AltaUsuarioService();
            _patenteUsuarioService = new PatenteUsuarioService();

            patenteDataGrid.DataSource = _altaPatenteService.GetAll();
            usuarioDataGrid.DataSource = _altaUsuarioService.GetAll();
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

        private void usuarioDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void usuarioDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            
            
        }

        private void patenteDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
