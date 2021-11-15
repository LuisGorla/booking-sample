using BE.ViewModels;
using BLL.Services;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class LoginForm : Form
    {
        private LoginService _LoginService;
        public LoginForm()
        {
            InitializeComponent();
            _LoginService = new LoginService();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            var usuario = new LoginViewModel {
                DNI = Usuariotxt.Text,
                Password = Passwordtxt.Text
            };

            if (_LoginService.LoginUser(usuario))
            {
                //this.Close();
                var a = new Form1();
                a.Show();
            }            
        }
    }
}
