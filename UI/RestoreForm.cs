using BLL.Services;
using DAL.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace UI
{
    public partial class RestoreForm : Form
    {
        private BitacoraService _bitacoraService;
        private List<string> _paths;
        public RestoreForm()
        {
            InitializeComponent();
            _paths = new List<string>();
            openFileDialog1.Multiselect = true;
            _bitacoraService = new BitacoraService();
        }

        private void examinarBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string[] rutas = openFileDialog1.FileNames;
            
            for (int i = 0; i < rutas.Length; i++)
            {
                _paths.Add(rutas[i]);
            }
        }

        private void restoreBtn_Click(object sender, EventArgs e)
        {
            RestoreBacup(_paths);

            var concatDvh = $"{4}{DateTime.Now}{Security.Security.LoggedUser.IdUsuario}{"Restore Generado"}";
            Bitacora bitacora = new Bitacora()
            {
                Criticidad = 4,
                Fecha = DateTime.Now,
                IdUsuario = Security.Security.LoggedUser.IdUsuario,
                Operacion = "Generacion de Restore",
                Dvh = Security.Security.CrearDVH(concatDvh)

            };

            _bitacoraService.Insert(bitacora);
        }
        private void RestoreBacup(List<string> paths)
        {
            string storeProcedure = "[dbo].[sp-restore]";
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            var param1 = new SqlParameter("@Cantidad ", paths.Count);
            listaParametros.Add(param1);

            int num = 1;
            foreach (string item in paths)
            {
                listaParametros.Add(new SqlParameter(string.Format("@Ruta{0}", num.ToString()), item));
                num++;
            }

            using (SqlConnection laConn = new SqlConnection("Data Source=SVARLP00564;Initial Catalog=master;Trusted_Connection=True;"))
            {
                SqlCommand elComm = new SqlCommand();
                elComm.Connection = laConn;
                elComm.CommandText = storeProcedure;
                elComm.CommandType = CommandType.StoredProcedure;
                foreach (SqlParameter item in listaParametros)
                {
                    elComm.Parameters.Add(item);
                }

                laConn.Open();
                elComm.ExecuteNonQuery();
            }
        }

        private void volverBackupBtn_Click(object sender, EventArgs e)
        {
            var backups = new BackupABM();
            backups.Show();
            this.Close();
        }
    }
}
