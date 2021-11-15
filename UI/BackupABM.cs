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
            var backup = new Backup
            {
                Directorio = Directoriotxt.Text,
                Fecha = fechadtp.Value,
                Usuario = Usuariotxt.Text
            };

            _backupService.Insert(backup);
        }
    }
}
