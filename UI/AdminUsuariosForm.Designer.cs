
namespace UI
{
    partial class AdminUsuariosForm
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
            this.userDgv = new System.Windows.Forms.DataGridView();
            this.borrarBtn = new System.Windows.Forms.Button();
            this.modificarBtn = new System.Windows.Forms.Button();
            this.bloquearBtn = new System.Windows.Forms.Button();
            this.altaBtn = new System.Windows.Forms.Button();
            this.volverBtn = new System.Windows.Forms.Button();
            this.desbloquearBtn = new System.Windows.Forms.Button();
            this.usuariosBloqueadosDgv = new System.Windows.Forms.DataGridView();
            this.nombreLbl = new System.Windows.Forms.Label();
            this.apellidoLbl = new System.Windows.Forms.Label();
            this.contactoLbl = new System.Windows.Forms.Label();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.apellidoTxt = new System.Windows.Forms.TextBox();
            this.contactoTxt = new System.Windows.Forms.TextBox();
            this.modificaBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.userDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBloqueadosDgv)).BeginInit();
            this.modificaBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // userDgv
            // 
            this.userDgv.AllowUserToAddRows = false;
            this.userDgv.AllowUserToDeleteRows = false;
            this.userDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDgv.Location = new System.Drawing.Point(12, 12);
            this.userDgv.Name = "userDgv";
            this.userDgv.RowTemplate.Height = 25;
            this.userDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userDgv.Size = new System.Drawing.Size(733, 236);
            this.userDgv.TabIndex = 0;
            // 
            // borrarBtn
            // 
            this.borrarBtn.Location = new System.Drawing.Point(12, 280);
            this.borrarBtn.Name = "borrarBtn";
            this.borrarBtn.Size = new System.Drawing.Size(75, 23);
            this.borrarBtn.TabIndex = 1;
            this.borrarBtn.Text = "Borrar";
            this.borrarBtn.UseVisualStyleBackColor = true;
            this.borrarBtn.Click += new System.EventHandler(this.borrarBtn_Click);
            // 
            // modificarBtn
            // 
            this.modificarBtn.Location = new System.Drawing.Point(40, 240);
            this.modificarBtn.Name = "modificarBtn";
            this.modificarBtn.Size = new System.Drawing.Size(79, 23);
            this.modificarBtn.TabIndex = 2;
            this.modificarBtn.Text = "Modificar";
            this.modificarBtn.UseVisualStyleBackColor = true;
            this.modificarBtn.Click += new System.EventHandler(this.modificarBtn_Click);
            // 
            // bloquearBtn
            // 
            this.bloquearBtn.Location = new System.Drawing.Point(131, 280);
            this.bloquearBtn.Name = "bloquearBtn";
            this.bloquearBtn.Size = new System.Drawing.Size(134, 23);
            this.bloquearBtn.TabIndex = 3;
            this.bloquearBtn.Text = "Bloquear Usuario";
            this.bloquearBtn.UseVisualStyleBackColor = true;
            this.bloquearBtn.Click += new System.EventHandler(this.bloquearBtn_Click);
            // 
            // altaBtn
            // 
            this.altaBtn.Location = new System.Drawing.Point(631, 280);
            this.altaBtn.Name = "altaBtn";
            this.altaBtn.Size = new System.Drawing.Size(114, 23);
            this.altaBtn.TabIndex = 4;
            this.altaBtn.Text = "Alta Usuario";
            this.altaBtn.UseVisualStyleBackColor = true;
            this.altaBtn.Click += new System.EventHandler(this.altaBtn_Click);
            // 
            // volverBtn
            // 
            this.volverBtn.BackColor = System.Drawing.Color.LemonChiffon;
            this.volverBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.volverBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.volverBtn.Location = new System.Drawing.Point(631, 631);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(114, 31);
            this.volverBtn.TabIndex = 13;
            this.volverBtn.Text = "<- Volver";
            this.volverBtn.UseVisualStyleBackColor = false;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // desbloquearBtn
            // 
            this.desbloquearBtn.Location = new System.Drawing.Point(611, 514);
            this.desbloquearBtn.Name = "desbloquearBtn";
            this.desbloquearBtn.Size = new System.Drawing.Size(134, 23);
            this.desbloquearBtn.TabIndex = 14;
            this.desbloquearBtn.Text = "Desbloquear Usuario";
            this.desbloquearBtn.UseVisualStyleBackColor = true;
            this.desbloquearBtn.Click += new System.EventHandler(this.desbloquearBtn_Click);
            // 
            // usuariosBloqueadosDgv
            // 
            this.usuariosBloqueadosDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosBloqueadosDgv.Location = new System.Drawing.Point(471, 345);
            this.usuariosBloqueadosDgv.Name = "usuariosBloqueadosDgv";
            this.usuariosBloqueadosDgv.RowTemplate.Height = 25;
            this.usuariosBloqueadosDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usuariosBloqueadosDgv.Size = new System.Drawing.Size(274, 150);
            this.usuariosBloqueadosDgv.TabIndex = 15;
            // 
            // nombreLbl
            // 
            this.nombreLbl.AutoSize = true;
            this.nombreLbl.Location = new System.Drawing.Point(24, 34);
            this.nombreLbl.Name = "nombreLbl";
            this.nombreLbl.Size = new System.Drawing.Size(51, 15);
            this.nombreLbl.TabIndex = 16;
            this.nombreLbl.Text = "Nombre";
            // 
            // apellidoLbl
            // 
            this.apellidoLbl.AutoSize = true;
            this.apellidoLbl.Location = new System.Drawing.Point(24, 101);
            this.apellidoLbl.Name = "apellidoLbl";
            this.apellidoLbl.Size = new System.Drawing.Size(51, 15);
            this.apellidoLbl.TabIndex = 17;
            this.apellidoLbl.Text = "Apellido";
            // 
            // contactoLbl
            // 
            this.contactoLbl.AutoSize = true;
            this.contactoLbl.Location = new System.Drawing.Point(24, 167);
            this.contactoLbl.Name = "contactoLbl";
            this.contactoLbl.Size = new System.Drawing.Size(56, 15);
            this.contactoLbl.TabIndex = 18;
            this.contactoLbl.Text = "Contacto";
            // 
            // nombreTxt
            // 
            this.nombreTxt.Location = new System.Drawing.Point(24, 64);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(122, 23);
            this.nombreTxt.TabIndex = 19;
            // 
            // apellidoTxt
            // 
            this.apellidoTxt.Location = new System.Drawing.Point(24, 129);
            this.apellidoTxt.Name = "apellidoTxt";
            this.apellidoTxt.Size = new System.Drawing.Size(122, 23);
            this.apellidoTxt.TabIndex = 20;
            // 
            // contactoTxt
            // 
            this.contactoTxt.Location = new System.Drawing.Point(24, 195);
            this.contactoTxt.Name = "contactoTxt";
            this.contactoTxt.Size = new System.Drawing.Size(122, 23);
            this.contactoTxt.TabIndex = 21;
            // 
            // modificaBox
            // 
            this.modificaBox.Controls.Add(this.nombreLbl);
            this.modificaBox.Controls.Add(this.contactoTxt);
            this.modificaBox.Controls.Add(this.modificarBtn);
            this.modificaBox.Controls.Add(this.apellidoTxt);
            this.modificaBox.Controls.Add(this.apellidoLbl);
            this.modificaBox.Controls.Add(this.nombreTxt);
            this.modificaBox.Controls.Add(this.contactoLbl);
            this.modificaBox.Location = new System.Drawing.Point(12, 335);
            this.modificaBox.Name = "modificaBox";
            this.modificaBox.Size = new System.Drawing.Size(177, 283);
            this.modificaBox.TabIndex = 22;
            this.modificaBox.TabStop = false;
            this.modificaBox.Text = "Modificar Usuario";
            // 
            // AdminUsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 674);
            this.Controls.Add(this.modificaBox);
            this.Controls.Add(this.usuariosBloqueadosDgv);
            this.Controls.Add(this.desbloquearBtn);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.altaBtn);
            this.Controls.Add(this.bloquearBtn);
            this.Controls.Add(this.borrarBtn);
            this.Controls.Add(this.userDgv);
            this.Name = "AdminUsuariosForm";
            this.Text = "AdminUsuariosForm";
            this.Load += new System.EventHandler(this.AdminUsuariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBloqueadosDgv)).EndInit();
            this.modificaBox.ResumeLayout(false);
            this.modificaBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView userDgv;
        private System.Windows.Forms.Button borrarBtn;
        private System.Windows.Forms.Button modificarBtn;
        private System.Windows.Forms.Button bloquearBtn;
        private System.Windows.Forms.Button altaBtn;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.Button desbloquearBtn;
        private System.Windows.Forms.DataGridView usuariosBloqueadosDgv;
        private System.Windows.Forms.Label nombreLbl;
        private System.Windows.Forms.Label apellidoLbl;
        private System.Windows.Forms.Label contactoLbl;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.TextBox apellidoTxt;
        private System.Windows.Forms.TextBox contactoTxt;
        private System.Windows.Forms.GroupBox modificaBox;
    }
}