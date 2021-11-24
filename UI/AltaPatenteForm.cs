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
    public partial class AltaPatenteForm : Form
    {
        private AltaPatenteService _altaPatenteService;
        public AltaPatenteForm()
        {
            InitializeComponent();
            _altaPatenteService = new AltaPatenteService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patente patente = new Patente();
            patente.Detalle = Encriptacion.Encriptacion.EncryptString(textBox1.Text);
            var idPatente = textBox2.Text;
            string dvhConcat = $"{patente.Detalle}{idPatente}";
            patente.Dvh = Security.Security.CrearDVH(dvhConcat);
            _altaPatenteService.Insert(patente);
        }
    }
}
