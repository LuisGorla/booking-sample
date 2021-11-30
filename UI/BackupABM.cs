using BLL.Services;
using DAL.Models;
using Microsoft.Data.SqlClient;
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
    public partial class BackupABM : Form
    {
        private BackupService _backupService;
        public BackupABM()
        {
            InitializeComponent();
            _backupService = new BackupService();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {          
            GenerarBackup();

 
            //RestoreBacup();

            //"dbo.SomeSproc @Id = {0}, @Name = {1}", 45, "Ada"
            //a = $"dbo.sp-backup @numeroParticiones = {1}, @ruta = {b}";

            //_backupService.RunProccedure("[dbo].[sp-backup]", parameter: new[] { param1, param2 });


        }

        private void GenerarBackup()
        {
            string storeProcedure = "[dbo].[sp-backup]";

            if (int.Parse(numeroParticionesTxt.Text) > 2)
            {
                MessageBox.Show(Text = "Usted ingreso un numero de particiones mayor a dos, vuelva a intentarlo");
                numeroParticionesTxt.Clear();
            }
            else
            {
                int cantidadParticiones = int.Parse(numeroParticionesTxt.Text);
                List<SqlParameter> listaParametros = new List<SqlParameter>();
                var param1 = new SqlParameter("@numeroParticiones", cantidadParticiones);
                var b = string.Format(@"C:\backups\");
                var param2 = new SqlParameter("@ruta", b);

                listaParametros.Add(param1);
                listaParametros.Add(param2);

                using (SqlConnection laConn = new SqlConnection("Data Source=SVARLP00564;Initial Catalog=booking;Trusted_Connection=True;"))
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
            
        }

        private void volverPatentesBtn_Click(object sender, EventArgs e)
        {
            var adminPatentes = new MenuForm();
            adminPatentes.Show();
            this.Close();
        }

        private void irRestoreBackupBtn_Click(object sender, EventArgs e)
        {
            var restoreBackup = new RestoreForm();
            restoreBackup.Show();
            this.Close();
        }
    }
}
