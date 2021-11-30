
namespace UI
{
    partial class MenuForm
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
            this.asignarPatenteBtn = new System.Windows.Forms.Button();
            this.altaUsuariosBtn = new System.Windows.Forms.Button();
            this.borrarUserSinPatenteBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bajaUsuario7Btn = new System.Windows.Forms.Button();
            this.usuarioDataGrid = new System.Windows.Forms.DataGridView();
            this.patenteDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.verificarIntegridadBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.quitarPatenteBtn = new System.Windows.Forms.Button();
            this.selectUserDataGrid = new System.Windows.Forms.DataGridView();
            this.patenteUsuarioDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.adminFamiliaBtn = new System.Windows.Forms.Button();
            this.irBackupBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patenteDataGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectUserDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patenteUsuarioDataGrid)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // asignarPatenteBtn
            // 
            this.asignarPatenteBtn.Location = new System.Drawing.Point(600, 236);
            this.asignarPatenteBtn.Name = "asignarPatenteBtn";
            this.asignarPatenteBtn.Size = new System.Drawing.Size(114, 23);
            this.asignarPatenteBtn.TabIndex = 0;
            this.asignarPatenteBtn.Text = "Asignar Patente";
            this.asignarPatenteBtn.UseVisualStyleBackColor = true;
            this.asignarPatenteBtn.Click += new System.EventHandler(this.asignarPatenteBtn_Click);
            // 
            // altaUsuariosBtn
            // 
            this.altaUsuariosBtn.Location = new System.Drawing.Point(7, 54);
            this.altaUsuariosBtn.Name = "altaUsuariosBtn";
            this.altaUsuariosBtn.Size = new System.Drawing.Size(178, 23);
            this.altaUsuariosBtn.TabIndex = 1;
            this.altaUsuariosBtn.Text = "Alta Usuarios";
            this.altaUsuariosBtn.UseVisualStyleBackColor = true;
            this.altaUsuariosBtn.Click += new System.EventHandler(this.altaUsuariosBtn_Click);
            // 
            // borrarUserSinPatenteBtn
            // 
            this.borrarUserSinPatenteBtn.Location = new System.Drawing.Point(7, 22);
            this.borrarUserSinPatenteBtn.Name = "borrarUserSinPatenteBtn";
            this.borrarUserSinPatenteBtn.Size = new System.Drawing.Size(178, 23);
            this.borrarUserSinPatenteBtn.TabIndex = 3;
            this.borrarUserSinPatenteBtn.Text = "Borrar Usuarios sin Patentes";
            this.borrarUserSinPatenteBtn.UseVisualStyleBackColor = true;
            this.borrarUserSinPatenteBtn.Click += new System.EventHandler(this.borrarUserSinPatenteBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bajaUsuario7Btn);
            this.groupBox1.Controls.Add(this.borrarUserSinPatenteBtn);
            this.groupBox1.Controls.Add(this.altaUsuariosBtn);
            this.groupBox1.Location = new System.Drawing.Point(941, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 117);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adminitracion de Usuarios";
            // 
            // bajaUsuario7Btn
            // 
            this.bajaUsuario7Btn.Location = new System.Drawing.Point(7, 88);
            this.bajaUsuario7Btn.Name = "bajaUsuario7Btn";
            this.bajaUsuario7Btn.Size = new System.Drawing.Size(178, 23);
            this.bajaUsuario7Btn.TabIndex = 4;
            this.bajaUsuario7Btn.Text = "Baja Usuario 7";
            this.bajaUsuario7Btn.UseVisualStyleBackColor = true;
            this.bajaUsuario7Btn.Click += new System.EventHandler(this.bajaUsuario7Btn_Click);
            // 
            // usuarioDataGrid
            // 
            this.usuarioDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarioDataGrid.Location = new System.Drawing.Point(6, 71);
            this.usuarioDataGrid.Name = "usuarioDataGrid";
            this.usuarioDataGrid.RowHeadersWidth = 51;
            this.usuarioDataGrid.RowTemplate.Height = 25;
            this.usuarioDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usuarioDataGrid.Size = new System.Drawing.Size(651, 150);
            this.usuarioDataGrid.TabIndex = 5;
            // 
            // patenteDataGrid
            // 
            this.patenteDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patenteDataGrid.Location = new System.Drawing.Point(662, 71);
            this.patenteDataGrid.Name = "patenteDataGrid";
            this.patenteDataGrid.RowHeadersWidth = 51;
            this.patenteDataGrid.RowTemplate.Height = 25;
            this.patenteDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patenteDataGrid.Size = new System.Drawing.Size(243, 150);
            this.patenteDataGrid.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(273, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleccione el Usuario + la Patente y luego haga click en Asignar Patente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Usuarios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(662, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Patentes";
            // 
            // verificarIntegridadBtn
            // 
            this.verificarIntegridadBtn.Location = new System.Drawing.Point(6, 30);
            this.verificarIntegridadBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.verificarIntegridadBtn.Name = "verificarIntegridadBtn";
            this.verificarIntegridadBtn.Size = new System.Drawing.Size(178, 23);
            this.verificarIntegridadBtn.TabIndex = 10;
            this.verificarIntegridadBtn.Text = "Verificar Integridad";
            this.verificarIntegridadBtn.UseVisualStyleBackColor = true;
            this.verificarIntegridadBtn.Click += new System.EventHandler(this.verificarIntegridadBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.usuarioDataGrid);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.asignarPatenteBtn);
            this.groupBox2.Controls.Add(this.patenteDataGrid);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(915, 264);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asignacion de Patentes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.quitarPatenteBtn);
            this.groupBox3.Controls.Add(this.selectUserDataGrid);
            this.groupBox3.Controls.Add(this.patenteUsuarioDataGrid);
            this.groupBox3.Location = new System.Drawing.Point(12, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(915, 268);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Baja de Patentes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(273, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(408, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Seleccione el usuario para ver sus patentes y seleccione la patente a remover";
            // 
            // quitarPatenteBtn
            // 
            this.quitarPatenteBtn.Location = new System.Drawing.Point(600, 226);
            this.quitarPatenteBtn.Name = "quitarPatenteBtn";
            this.quitarPatenteBtn.Size = new System.Drawing.Size(114, 23);
            this.quitarPatenteBtn.TabIndex = 2;
            this.quitarPatenteBtn.Text = "Quitar Patente";
            this.quitarPatenteBtn.UseVisualStyleBackColor = true;
            this.quitarPatenteBtn.Click += new System.EventHandler(this.quitarPatenteBtn_Click);
            // 
            // selectUserDataGrid
            // 
            this.selectUserDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectUserDataGrid.Location = new System.Drawing.Point(493, 57);
            this.selectUserDataGrid.Name = "selectUserDataGrid";
            this.selectUserDataGrid.RowTemplate.Height = 25;
            this.selectUserDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.selectUserDataGrid.Size = new System.Drawing.Size(412, 150);
            this.selectUserDataGrid.TabIndex = 1;
            this.selectUserDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectUserDataGrid_CellClick);
            // 
            // patenteUsuarioDataGrid
            // 
            this.patenteUsuarioDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patenteUsuarioDataGrid.Location = new System.Drawing.Point(6, 57);
            this.patenteUsuarioDataGrid.Name = "patenteUsuarioDataGrid";
            this.patenteUsuarioDataGrid.RowTemplate.Height = 25;
            this.patenteUsuarioDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patenteUsuarioDataGrid.Size = new System.Drawing.Size(481, 150);
            this.patenteUsuarioDataGrid.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.irBackupBtn);
            this.groupBox4.Controls.Add(this.verificarIntegridadBtn);
            this.groupBox4.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox4.Location = new System.Drawing.Point(941, 239);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(191, 100);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tests de Integridad";
            // 
            // adminFamiliaBtn
            // 
            this.adminFamiliaBtn.BackColor = System.Drawing.Color.LemonChiffon;
            this.adminFamiliaBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adminFamiliaBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.adminFamiliaBtn.Location = new System.Drawing.Point(902, 576);
            this.adminFamiliaBtn.Name = "adminFamiliaBtn";
            this.adminFamiliaBtn.Size = new System.Drawing.Size(230, 28);
            this.adminFamiliaBtn.TabIndex = 14;
            this.adminFamiliaBtn.Text = "Ir a Administracion de Familias ->";
            this.adminFamiliaBtn.UseVisualStyleBackColor = false;
            this.adminFamiliaBtn.Click += new System.EventHandler(this.adminFamiliaBtn_Click);
            // 
            // irBackupBtn
            // 
            this.irBackupBtn.BackColor = System.Drawing.Color.LemonChiffon;
            this.irBackupBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.irBackupBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.irBackupBtn.Location = new System.Drawing.Point(7, 66);
            this.irBackupBtn.Name = "irBackupBtn";
            this.irBackupBtn.Size = new System.Drawing.Size(177, 28);
            this.irBackupBtn.TabIndex = 11;
            this.irBackupBtn.Text = "Ir a Backups ->";
            this.irBackupBtn.UseVisualStyleBackColor = false;
            this.irBackupBtn.Click += new System.EventHandler(this.irBackupBtn_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 616);
            this.Controls.Add(this.adminFamiliaBtn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuForm";
            this.Text = "AdminSeguridad";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patenteDataGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectUserDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patenteUsuarioDataGrid)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button asignarPatenteBtn;
        private System.Windows.Forms.Button altaUsuariosBtn;
        private System.Windows.Forms.Button borrarUserSinPatenteBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView usuarioDataGrid;
        private System.Windows.Forms.DataGridView patenteDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button verificarIntegridadBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView selectUserDataGrid;
        private System.Windows.Forms.DataGridView patenteUsuarioDataGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button quitarPatenteBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button adminFamiliaBtn;
        private System.Windows.Forms.Button bajaUsuario7Btn;
        private System.Windows.Forms.Button irBackupBtn;
    }
}