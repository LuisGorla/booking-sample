using BLL.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DAL.Models;
using iText;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Pdfa;

namespace UI
{
    public partial class BitacoraForm : Form
    {
        private BitacoraService _bitacoraService;
        private List<DAL.Models.Bitacora> registrosBitacora;
        public BitacoraForm()
        {
            InitializeComponent();
            _bitacoraService = new BitacoraService();
            registrosBitacora = new List<DAL.Models.Bitacora>();
            registrosBitacora = _bitacoraService.GetAll().ToList();
        }

        private void CargarDgv(List<Bitacora> bitacoras)
        {
            bitacoraDgv.Rows.Clear();

            bitacoraDgv.ColumnCount = 5;

            bitacoraDgv.Columns[0].Name = "Bitacora";
            bitacoraDgv.Columns[1].Name = "Criticidad";
            bitacoraDgv.Columns[2].Name = "Fecha";
            bitacoraDgv.Columns[3].Name = "Operación";
            bitacoraDgv.Columns[4].Name = "Usuario";

            
            foreach (var bitacora in bitacoras)
            {
                int n = bitacoraDgv.Rows.Add();

                bitacoraDgv.Rows[n].Cells[0].Value = bitacora.IdBicatora;
                bitacoraDgv.Rows[n].Cells[1].Value = bitacora.Criticidad;
                bitacoraDgv.Rows[n].Cells[2].Value = bitacora.Fecha;
                bitacoraDgv.Rows[n].Cells[3].Value = bitacora.Operacion;
                bitacoraDgv.Rows[n].Cells[4].Value = bitacora.IdUsuario;

            }

            bitacoraDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            bitacoraDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Reset()
        {
            dedeDtp.Value = registrosBitacora.Select(x => x.Fecha.Date).OrderBy(x => x.Date).FirstOrDefault().Date;

            hastaDtp.Value = DateTime.Now.Date;

            criticidadBox.DataSource = registrosBitacora.Select(x => x.Criticidad).Distinct().ToList();
            usuarioBox.DataSource = registrosBitacora.Select(x => x.IdUsuario).Distinct().ToList();
            usuarioBox.SelectedItem = null;
            criticidadBox.SelectedItem = null;

        }

        private void usuarioBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BitacoraForm_Load(object sender, EventArgs e)
        {
            CargarDgv(registrosBitacora);
            Reset();

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(BitacoraForm_KeyDown);
        }

        private void filtrarBtn_Click(object sender, EventArgs e)
        {
            if (dedeDtp.Value <= DateTime.Now && hastaDtp.Value >= dedeDtp.Value && hastaDtp.Value <= DateTime.Now)
            {
                if (usuarioBox.SelectedItem != null && criticidadBox.SelectedItem == null) //1-1-0
                {
                    this.CargarDgv(registrosBitacora.Where(bitacora => bitacora.IdUsuario == (int)usuarioBox.SelectedItem &&
                                                        bitacora.Fecha.Date >= dedeDtp.Value.Date &&
                                                        bitacora.Fecha.Date <= hastaDtp.Value.Date
                                                        ).ToList());


                }
                else if (usuarioBox.SelectedItem == null && criticidadBox.SelectedItem != null) //1-0-1
                {
                    this.CargarDgv(registrosBitacora.Where(bitacora => bitacora.Criticidad == (int)criticidadBox.SelectedItem &&
                                                                    bitacora.Fecha.Date >= dedeDtp.Value.Date &&
                                                                    bitacora.Fecha.Date <= hastaDtp.Value.Date
                                                                    ).ToList());

                }
                else if (usuarioBox.SelectedItem != null && criticidadBox.SelectedItem != null)//1-1-1
                {
                    this.CargarDgv(registrosBitacora.Where(bitacora => bitacora.IdUsuario == (int)usuarioBox.SelectedItem &&
                                                                   bitacora.Criticidad == (int)criticidadBox.SelectedItem &&
                                                                   bitacora.Fecha.Date >= dedeDtp.Value.Date &&
                                                                   bitacora.Fecha.Date <= hastaDtp.Value.Date
                                                                   ).ToList());

                }
                else if (usuarioBox.SelectedItem == null && criticidadBox.SelectedItem == null)//1-0-0
                {
                    this.CargarDgv(registrosBitacora.Where(bitacora => bitacora.Fecha.Date >= dedeDtp.Value.Date &&
                                                                   bitacora.Fecha.Date <= hastaDtp.Value.Date
                                                                   ).ToList());

                }
            }
            else
            {
                MessageBox.Show(Text = "Error");
            }

        }

        private void generarPdfBtn_Click(object sender, EventArgs e)
        {
            //Carga path desde App.config
            string ruta = string.Format(@"C:\reportespdf\Reporte-{0}.pdf", DateTime.Now.ToString("yyyy.MM.dd HH.mm"));
            PdfWriter pw = new PdfWriter(ruta);
            PdfDocument unPdfDocument = new PdfDocument(pw);
            Document unDocument = new Document(unPdfDocument, PageSize.A4);
            unDocument.SetMargins(60, 35, 60, 35); //Seteo los margenes en unidad de pixeles.

            //1.1 Primer Parrafo(texto)
            Paragraph parrafoA = new Paragraph("Booking Sample - Registros de Bitacora");
            parrafoA.SetBold();
            parrafoA.SetUnderline();
            parrafoA.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
            unDocument.Add(parrafoA);

            string usuario = (usuarioBox.SelectedItem == null) ? "Todos los usuarios" : usuarioBox.Text;
            string criticidad = (criticidadBox.SelectedItem == null) ? "Todas las criticidades" : criticidadBox.Text;
            Paragraph parrafoB = new Paragraph(string.Format("Filtros aplicados:\n  Fecha inicio = {0}\n Fecha Finalizacion = {1}\n Usuario = {2}\n Criticidad = {3}\n\n", dedeDtp.Value.ToShortDateString(), hastaDtp.Value.ToShortDateString(), usuario, criticidad));
            parrafoB.SetItalic();
            parrafoA.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.LEFT);
            unDocument.Add(parrafoB);


            //1.2 Segundo Parrafo (creo tabla y la cargo del DataTable)
            Table unaTabla = new Table(bitacoraDgv.Columns.Count);
            unaTabla.SetOpacity(1f);
            unaTabla.SetBackgroundColor(iText.Kernel.Colors.DeviceGray.GRAY);
            foreach (DataGridViewTextBoxColumn nombreColumna in bitacoraDgv.Columns)
            {
                Cell unaCelda = new Cell().Add(new Paragraph(nombreColumna.Name.ToString()));
                unaCelda.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                unaCelda.SetBold();
                unaTabla.AddHeaderCell(unaCelda);
            }

            foreach (DataGridViewRow fila in bitacoraDgv.Rows)
            {
                unaTabla.AddCell(new Cell().Add(new Paragraph(fila.Cells[0].Value.ToString())));
                unaTabla.AddCell(new Cell().Add(new Paragraph(fila.Cells[1].Value.ToString())));
                unaTabla.AddCell(new Cell().Add(new Paragraph(fila.Cells[2].Value.ToString())));
                unaTabla.AddCell(new Cell().Add(new Paragraph(fila.Cells[3].Value.ToString())));
                unaTabla.AddCell(new Cell().Add(new Paragraph(fila.Cells[4].Value.ToString())));
                unaTabla.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
            }

            unaTabla.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
            unDocument.Add(unaTabla);

            
            unDocument.Close();
            MessageBox.Show(Text = "Se generó el PDF");

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            CargarDgv(registrosBitacora);
            usuarioBox.SelectedItem = null;
            criticidadBox.SelectedItem = null;
        }

        private void BitacoraForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1) 
            {
                e.Handled = true;

                Help.ShowHelp(this, @"C:\Repos\booking-sample\UI\Helper\HelpEsp.chm", HelpNavigator.TopicId, "200");
            }
        }
    }
}
