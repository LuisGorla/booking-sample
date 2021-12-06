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
    public partial class OrdenCompraForm : Form
    {
        public OrdenCompraForm()
        {
            InitializeComponent();
        }

        private void volverPatentesBtn_Click(object sender, EventArgs e)
        {
            var ordenCompraForm = new OrdenCompraForm();
            ordenCompraForm.Show();
            this.Close();
        }
    }
}
