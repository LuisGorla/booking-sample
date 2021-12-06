
namespace UI
{
    partial class AdminFamilia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.crearFamiliaBtn = new System.Windows.Forms.Button();
            this.familiasAltaDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.altaFamiliaTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.patenteDataGrid = new System.Windows.Forms.DataGridView();
            this.familiaDataGrid = new System.Windows.Forms.DataGridView();
            this.asignPatenteBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.asignFamiliyUserDatagrid = new System.Windows.Forms.DataGridView();
            this.asignUsersDatagrid = new System.Windows.Forms.DataGridView();
            this.asignarFamiliaUsuarioBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.quitarPatenteBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.selectDropFamiliyDataGrid = new System.Windows.Forms.DataGridView();
            this.selectDropPatenteDataGrid = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.selectDropUserFamiliDataGrid = new System.Windows.Forms.DataGridView();
            this.selectDropFamilyUserDataGrid = new System.Windows.Forms.DataGridView();
            this.quitarFamiliaUsuarioBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.bajaDeleteFamiliaBtn = new System.Windows.Forms.Button();
            this.deleteBajaFamiliaDataGrid = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.volverPatentesBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.familiasAltaDataGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patenteDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiaDataGrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asignFamiliyUserDatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignUsersDatagrid)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectDropFamiliyDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDropPatenteDataGrid)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectDropUserFamiliDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDropFamilyUserDataGrid)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteBajaFamiliaDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.crearFamiliaBtn);
            this.groupBox1.Controls.Add(this.familiasAltaDataGrid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.altaFamiliaTxt);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta de Familias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cree un nombre y presione el boton Crear Familia";
            // 
            // crearFamiliaBtn
            // 
            this.crearFamiliaBtn.Location = new System.Drawing.Point(213, 71);
            this.crearFamiliaBtn.Name = "crearFamiliaBtn";
            this.crearFamiliaBtn.Size = new System.Drawing.Size(97, 23);
            this.crearFamiliaBtn.TabIndex = 5;
            this.crearFamiliaBtn.Text = "Crear Familia";
            this.crearFamiliaBtn.UseVisualStyleBackColor = true;
            this.crearFamiliaBtn.Click += new System.EventHandler(this.crearFamiliaBtn_Click);
            // 
            // familiasAltaDataGrid
            // 
            this.familiasAltaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.familiasAltaDataGrid.Location = new System.Drawing.Point(6, 112);
            this.familiasAltaDataGrid.Name = "familiasAltaDataGrid";
            this.familiasAltaDataGrid.RowTemplate.Height = 25;
            this.familiasAltaDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.familiasAltaDataGrid.Size = new System.Drawing.Size(269, 93);
            this.familiasAltaDataGrid.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre de la Familia";
            // 
            // altaFamiliaTxt
            // 
            this.altaFamiliaTxt.Location = new System.Drawing.Point(6, 72);
            this.altaFamiliaTxt.Name = "altaFamiliaTxt";
            this.altaFamiliaTxt.Size = new System.Drawing.Size(190, 23);
            this.altaFamiliaTxt.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.patenteDataGrid);
            this.groupBox2.Controls.Add(this.familiaDataGrid);
            this.groupBox2.Controls.Add(this.asignPatenteBtn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 211);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asignacion de Patentes a Familias";
            // 
            // patenteDataGrid
            // 
            this.patenteDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patenteDataGrid.Location = new System.Drawing.Point(258, 72);
            this.patenteDataGrid.Name = "patenteDataGrid";
            this.patenteDataGrid.RowTemplate.Height = 25;
            this.patenteDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patenteDataGrid.Size = new System.Drawing.Size(246, 133);
            this.patenteDataGrid.TabIndex = 13;
            // 
            // familiaDataGrid
            // 
            this.familiaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.familiaDataGrid.Location = new System.Drawing.Point(6, 72);
            this.familiaDataGrid.Name = "familiaDataGrid";
            this.familiaDataGrid.RowTemplate.Height = 25;
            this.familiaDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.familiaDataGrid.Size = new System.Drawing.Size(246, 133);
            this.familiaDataGrid.TabIndex = 12;
            // 
            // asignPatenteBtn
            // 
            this.asignPatenteBtn.Location = new System.Drawing.Point(510, 72);
            this.asignPatenteBtn.Name = "asignPatenteBtn";
            this.asignPatenteBtn.Size = new System.Drawing.Size(104, 23);
            this.asignPatenteBtn.TabIndex = 10;
            this.asignPatenteBtn.Text = "Asignar Patente";
            this.asignPatenteBtn.UseVisualStyleBackColor = true;
            this.asignPatenteBtn.Click += new System.EventHandler(this.asignPatenteBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Patente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Familia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Seleccione la Familia y luego Asigne las Patentes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.asignFamiliyUserDatagrid);
            this.groupBox3.Controls.Add(this.asignUsersDatagrid);
            this.groupBox3.Controls.Add(this.asignarFamiliaUsuarioBtn);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(647, 246);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(680, 211);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Asignacion de Familias a Usuarios";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(6, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(246, 15);
            this.label16.TabIndex = 19;
            this.label16.Text = "Seleccione un Usuario y luego asigne familias";
            // 
            // asignFamiliyUserDatagrid
            // 
            this.asignFamiliyUserDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.asignFamiliyUserDatagrid.Location = new System.Drawing.Point(316, 72);
            this.asignFamiliyUserDatagrid.Name = "asignFamiliyUserDatagrid";
            this.asignFamiliyUserDatagrid.RowTemplate.Height = 25;
            this.asignFamiliyUserDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.asignFamiliyUserDatagrid.Size = new System.Drawing.Size(246, 133);
            this.asignFamiliyUserDatagrid.TabIndex = 18;
            // 
            // asignUsersDatagrid
            // 
            this.asignUsersDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.asignUsersDatagrid.Location = new System.Drawing.Point(6, 72);
            this.asignUsersDatagrid.Name = "asignUsersDatagrid";
            this.asignUsersDatagrid.RowTemplate.Height = 25;
            this.asignUsersDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.asignUsersDatagrid.Size = new System.Drawing.Size(304, 133);
            this.asignUsersDatagrid.TabIndex = 17;
            // 
            // asignarFamiliaUsuarioBtn
            // 
            this.asignarFamiliaUsuarioBtn.Location = new System.Drawing.Point(568, 72);
            this.asignarFamiliaUsuarioBtn.Name = "asignarFamiliaUsuarioBtn";
            this.asignarFamiliaUsuarioBtn.Size = new System.Drawing.Size(104, 23);
            this.asignarFamiliaUsuarioBtn.TabIndex = 16;
            this.asignarFamiliaUsuarioBtn.Text = "Asignar Familia";
            this.asignarFamiliaUsuarioBtn.UseVisualStyleBackColor = true;
            this.asignarFamiliaUsuarioBtn.Click += new System.EventHandler(this.asignarFamiliaUsuarioBtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(316, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 15);
            this.label12.TabIndex = 15;
            this.label12.Text = "Familia";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 15);
            this.label13.TabIndex = 14;
            this.label13.Text = "Usuario";
            // 
            // quitarPatenteBtn
            // 
            this.quitarPatenteBtn.Location = new System.Drawing.Point(510, 72);
            this.quitarPatenteBtn.Name = "quitarPatenteBtn";
            this.quitarPatenteBtn.Size = new System.Drawing.Size(104, 23);
            this.quitarPatenteBtn.TabIndex = 11;
            this.quitarPatenteBtn.Text = "Quitar Patente";
            this.quitarPatenteBtn.UseVisualStyleBackColor = true;
            this.quitarPatenteBtn.Click += new System.EventHandler(this.quitarPatenteBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.selectDropFamiliyDataGrid);
            this.groupBox4.Controls.Add(this.selectDropPatenteDataGrid);
            this.groupBox4.Controls.Add(this.quitarPatenteBtn);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(12, 479);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(624, 211);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Baja de Patentes a Familias";
            // 
            // selectDropFamiliyDataGrid
            // 
            this.selectDropFamiliyDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectDropFamiliyDataGrid.Location = new System.Drawing.Point(258, 72);
            this.selectDropFamiliyDataGrid.Name = "selectDropFamiliyDataGrid";
            this.selectDropFamiliyDataGrid.RowTemplate.Height = 25;
            this.selectDropFamiliyDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.selectDropFamiliyDataGrid.Size = new System.Drawing.Size(246, 133);
            this.selectDropFamiliyDataGrid.TabIndex = 13;
            this.selectDropFamiliyDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectDropFamiliyDataGrid_CellClick);
            // 
            // selectDropPatenteDataGrid
            // 
            this.selectDropPatenteDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectDropPatenteDataGrid.Location = new System.Drawing.Point(6, 72);
            this.selectDropPatenteDataGrid.Name = "selectDropPatenteDataGrid";
            this.selectDropPatenteDataGrid.RowTemplate.Height = 25;
            this.selectDropPatenteDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.selectDropPatenteDataGrid.Size = new System.Drawing.Size(246, 133);
            this.selectDropPatenteDataGrid.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Patente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Familia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(6, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(487, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Seleccione una Familia para ver las Patentes asignadas. Luego seleccione la Paten" +
    "te a quitar";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.selectDropUserFamiliDataGrid);
            this.groupBox5.Controls.Add(this.selectDropFamilyUserDataGrid);
            this.groupBox5.Controls.Add(this.quitarFamiliaUsuarioBtn);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(647, 479);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(680, 211);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Baja de Familias a Usuarios";
            // 
            // selectDropUserFamiliDataGrid
            // 
            this.selectDropUserFamiliDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectDropUserFamiliDataGrid.Location = new System.Drawing.Point(261, 72);
            this.selectDropUserFamiliDataGrid.Name = "selectDropUserFamiliDataGrid";
            this.selectDropUserFamiliDataGrid.RowTemplate.Height = 25;
            this.selectDropUserFamiliDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.selectDropUserFamiliDataGrid.Size = new System.Drawing.Size(304, 133);
            this.selectDropUserFamiliDataGrid.TabIndex = 13;
            this.selectDropUserFamiliDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectDropUserFamiliDataGrid_CellClick);
            // 
            // selectDropFamilyUserDataGrid
            // 
            this.selectDropFamilyUserDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectDropFamilyUserDataGrid.Location = new System.Drawing.Point(6, 72);
            this.selectDropFamilyUserDataGrid.Name = "selectDropFamilyUserDataGrid";
            this.selectDropFamilyUserDataGrid.RowTemplate.Height = 25;
            this.selectDropFamilyUserDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.selectDropFamilyUserDataGrid.Size = new System.Drawing.Size(249, 133);
            this.selectDropFamilyUserDataGrid.TabIndex = 12;
            // 
            // quitarFamiliaUsuarioBtn
            // 
            this.quitarFamiliaUsuarioBtn.Location = new System.Drawing.Point(568, 72);
            this.quitarFamiliaUsuarioBtn.Name = "quitarFamiliaUsuarioBtn";
            this.quitarFamiliaUsuarioBtn.Size = new System.Drawing.Size(104, 23);
            this.quitarFamiliaUsuarioBtn.TabIndex = 11;
            this.quitarFamiliaUsuarioBtn.Text = "Quitar Familia";
            this.quitarFamiliaUsuarioBtn.UseVisualStyleBackColor = true;
            this.quitarFamiliaUsuarioBtn.Click += new System.EventHandler(this.quitarFamiliaUsuarioBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(261, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Usuarios";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Familia";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(6, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(479, 15);
            this.label11.TabIndex = 7;
            this.label11.Text = "Seleccione un Usuario para ver las Familias asignadas. Luego seleccione la Famili" +
    "a a quitar";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.bajaDeleteFamiliaBtn);
            this.groupBox6.Controls.Add(this.deleteBajaFamiliaDataGrid);
            this.groupBox6.Location = new System.Drawing.Point(1001, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(326, 211);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Baja de Familias";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(6, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(186, 15);
            this.label14.TabIndex = 6;
            this.label14.Text = "Seleccione la Familia a dar de Baja";
            // 
            // bajaDeleteFamiliaBtn
            // 
            this.bajaDeleteFamiliaBtn.Location = new System.Drawing.Point(216, 182);
            this.bajaDeleteFamiliaBtn.Name = "bajaDeleteFamiliaBtn";
            this.bajaDeleteFamiliaBtn.Size = new System.Drawing.Size(104, 23);
            this.bajaDeleteFamiliaBtn.TabIndex = 5;
            this.bajaDeleteFamiliaBtn.Text = "Baja Familia";
            this.bajaDeleteFamiliaBtn.UseVisualStyleBackColor = true;
            this.bajaDeleteFamiliaBtn.Click += new System.EventHandler(this.bajaDeleteFamiliaBtn_Click);
            // 
            // deleteBajaFamiliaDataGrid
            // 
            this.deleteBajaFamiliaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deleteBajaFamiliaDataGrid.Location = new System.Drawing.Point(6, 54);
            this.deleteBajaFamiliaDataGrid.Name = "deleteBajaFamiliaDataGrid";
            this.deleteBajaFamiliaDataGrid.RowTemplate.Height = 25;
            this.deleteBajaFamiliaDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deleteBajaFamiliaDataGrid.Size = new System.Drawing.Size(269, 93);
            this.deleteBajaFamiliaDataGrid.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.booking_icon;
            this.pictureBox1.Location = new System.Drawing.Point(596, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 141);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // volverPatentesBtn
            // 
            this.volverPatentesBtn.BackColor = System.Drawing.Color.LemonChiffon;
            this.volverPatentesBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.volverPatentesBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.volverPatentesBtn.Location = new System.Drawing.Point(522, 178);
            this.volverPatentesBtn.Name = "volverPatentesBtn";
            this.volverPatentesBtn.Size = new System.Drawing.Size(287, 28);
            this.volverPatentesBtn.TabIndex = 7;
            this.volverPatentesBtn.Text = "<- Volver a Administracion de Patentes";
            this.volverPatentesBtn.UseVisualStyleBackColor = false;
            this.volverPatentesBtn.Click += new System.EventHandler(this.volverPatentesBtn_Click);
            // 
            // AdminFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 708);
            this.Controls.Add(this.volverPatentesBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminFamilia";
            this.Text = "AdminSeguridad";
            this.Load += new System.EventHandler(this.AdminFamilia_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AdminFamilia_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.familiasAltaDataGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patenteDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiaDataGrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asignFamiliyUserDatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignUsersDatagrid)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectDropFamiliyDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDropPatenteDataGrid)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectDropUserFamiliDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDropFamilyUserDataGrid)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteBajaFamiliaDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button crearFamiliaBtn;
        private System.Windows.Forms.DataGridView familiasAltaDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox altaFamiliaTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView patenteDataGrid;
        private System.Windows.Forms.DataGridView familiaDataGrid;
        private System.Windows.Forms.Button quitarPatenteBtn;
        private System.Windows.Forms.Button asignPatenteBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView selectDropFamiliyDataGrid;
        private System.Windows.Forms.DataGridView selectDropPatenteDataGrid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView asignFamiliyUserDatagrid;
        private System.Windows.Forms.DataGridView asignUsersDatagrid;
        private System.Windows.Forms.Button asignarFamiliaUsuarioBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView selectDropUserFamiliDataGrid;
        private System.Windows.Forms.DataGridView selectDropFamilyUserDataGrid;
        private System.Windows.Forms.Button quitarFamiliaUsuarioBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button bajaDeleteFamiliaBtn;
        private System.Windows.Forms.DataGridView deleteBajaFamiliaDataGrid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button volverPatentesBtn;
    }
}