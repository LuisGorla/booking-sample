using System;
using System.IO;
using System.Windows.Forms;

namespace UI
{
    public partial class DbConnection : Form
    {
        public DbConnection()
        {
            InitializeComponent();
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            ResetFile();
            WriteFile();
            var filePath = "C:\\Repos\\booking-sample\\DAL\\ConnectionStrings.txt";
            if (File.Exists(filePath) && File.ReadAllBytes(filePath).Length > 50)
            {
                var login = new LoginForm();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(Text = "No se pudo establecer conexión a la Base de Datos. Por favor, vuelva a intentar");
            }
        }

        private void ResetFile()
        {
            var filePath = "C:\\Repos\\booking-sample\\DAL\\ConnectionStrings.txt";
            string row = string.Empty;
            using (StreamWriter writer = File.CreateText(filePath))
            {
                writer.WriteLine(row);
            }
        }

        private void WriteFile()
        {
            var filePath = "C:\\Repos\\booking-sample\\DAL\\ConnectionStrings.txt";

            string encryptedConnStr;
            var connStr = conStrTxt.Text;

            if (connStr != null )
            {
                using (StreamWriter writer = File.CreateText(filePath))
                {
                    encryptedConnStr = Encriptacion.Encriptacion.EncryptString(conStrTxt.Text);
                    writer.WriteLine(encryptedConnStr);
                }

            }           
            
        }

        private void TestConnection()
        {

        }
    }
}
