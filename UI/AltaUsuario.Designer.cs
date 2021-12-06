
namespace UI
{
    partial class AltaUsuario
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
            this.RegistrarBtn = new System.Windows.Forms.Button();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.apellidoTxt = new System.Windows.Forms.TextBox();
            this.contraseñaTxt = new System.Windows.Forms.TextBox();
            this.dniTxt = new System.Windows.Forms.TextBox();
            this.contactoTxt = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.apellidoLbl = new System.Windows.Forms.Label();
            this.contraseñaLbl = new System.Windows.Forms.Label();
            this.dniLbl = new System.Windows.Forms.Label();
            this.contanctoLbl = new System.Windows.Forms.Label();
            this.volverBtn = new System.Windows.Forms.Button();
            this.idiomaCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegistrarBtn
            // 
            this.RegistrarBtn.Location = new System.Drawing.Point(142, 248);
            this.RegistrarBtn.Name = "RegistrarBtn";
            this.RegistrarBtn.Size = new System.Drawing.Size(171, 23);
            this.RegistrarBtn.TabIndex = 0;
            this.RegistrarBtn.Text = "Registrar";
            this.RegistrarBtn.UseVisualStyleBackColor = true;
            this.RegistrarBtn.Click += new System.EventHandler(this.RegistrarBtn_Click);
            // 
            // nombreTxt
            // 
            this.nombreTxt.Location = new System.Drawing.Point(26, 36);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(171, 23);
            this.nombreTxt.TabIndex = 1;
            // 
            // apellidoTxt
            // 
            this.apellidoTxt.Location = new System.Drawing.Point(26, 110);
            this.apellidoTxt.Name = "apellidoTxt";
            this.apellidoTxt.Size = new System.Drawing.Size(171, 23);
            this.apellidoTxt.TabIndex = 2;
            // 
            // contraseñaTxt
            // 
            this.contraseñaTxt.Location = new System.Drawing.Point(26, 178);
            this.contraseñaTxt.Name = "contraseñaTxt";
            this.contraseñaTxt.Size = new System.Drawing.Size(171, 23);
            this.contraseñaTxt.TabIndex = 3;
            // 
            // dniTxt
            // 
            this.dniTxt.Location = new System.Drawing.Point(267, 36);
            this.dniTxt.Name = "dniTxt";
            this.dniTxt.Size = new System.Drawing.Size(171, 23);
            this.dniTxt.TabIndex = 4;
            // 
            // contactoTxt
            // 
            this.contactoTxt.Location = new System.Drawing.Point(267, 110);
            this.contactoTxt.Name = "contactoTxt";
            this.contactoTxt.Size = new System.Drawing.Size(171, 23);
            this.contactoTxt.TabIndex = 5;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(26, 18);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(51, 15);
            this.Nombre.TabIndex = 7;
            this.Nombre.Text = "Nombre";
            // 
            // apellidoLbl
            // 
            this.apellidoLbl.AutoSize = true;
            this.apellidoLbl.Location = new System.Drawing.Point(26, 92);
            this.apellidoLbl.Name = "apellidoLbl";
            this.apellidoLbl.Size = new System.Drawing.Size(51, 15);
            this.apellidoLbl.TabIndex = 8;
            this.apellidoLbl.Text = "Apellido";
            // 
            // contraseñaLbl
            // 
            this.contraseñaLbl.AutoSize = true;
            this.contraseñaLbl.Location = new System.Drawing.Point(26, 160);
            this.contraseñaLbl.Name = "contraseñaLbl";
            this.contraseñaLbl.Size = new System.Drawing.Size(67, 15);
            this.contraseñaLbl.TabIndex = 9;
            this.contraseñaLbl.Text = "Contraseña";
            // 
            // dniLbl
            // 
            this.dniLbl.AutoSize = true;
            this.dniLbl.Location = new System.Drawing.Point(267, 18);
            this.dniLbl.Name = "dniLbl";
            this.dniLbl.Size = new System.Drawing.Size(27, 15);
            this.dniLbl.TabIndex = 10;
            this.dniLbl.Text = "DNI";
            // 
            // contanctoLbl
            // 
            this.contanctoLbl.AutoSize = true;
            this.contanctoLbl.Location = new System.Drawing.Point(267, 92);
            this.contanctoLbl.Name = "contanctoLbl";
            this.contanctoLbl.Size = new System.Drawing.Size(56, 15);
            this.contanctoLbl.TabIndex = 11;
            this.contanctoLbl.Text = "Contacto";
            // 
            // volverBtn
            // 
            this.volverBtn.BackColor = System.Drawing.Color.LemonChiffon;
            this.volverBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.volverBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.volverBtn.Location = new System.Drawing.Point(186, 287);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(78, 31);
            this.volverBtn.TabIndex = 12;
            this.volverBtn.Text = "<- Volver";
            this.volverBtn.UseVisualStyleBackColor = false;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // idiomaCombo
            // 
            this.idiomaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idiomaCombo.FormattingEnabled = true;
            this.idiomaCombo.Location = new System.Drawing.Point(267, 178);
            this.idiomaCombo.Name = "idiomaCombo";
            this.idiomaCombo.Size = new System.Drawing.Size(171, 23);
            this.idiomaCombo.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Seleccionar Idioma";
            // 
            // AltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 328);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idiomaCombo);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.contanctoLbl);
            this.Controls.Add(this.dniLbl);
            this.Controls.Add(this.contraseñaLbl);
            this.Controls.Add(this.apellidoLbl);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.contactoTxt);
            this.Controls.Add(this.dniTxt);
            this.Controls.Add(this.contraseñaTxt);
            this.Controls.Add(this.apellidoTxt);
            this.Controls.Add(this.nombreTxt);
            this.Controls.Add(this.RegistrarBtn);
            this.Name = "AltaUsuario";
            this.Text = "AltaUsuario";
            this.Load += new System.EventHandler(this.AltaUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegistrarBtn;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.TextBox apellidoTxt;
        private System.Windows.Forms.TextBox contraseñaTxt;
        private System.Windows.Forms.TextBox dniTxt;
        private System.Windows.Forms.TextBox contactoTxt;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label apellidoLbl;
        private System.Windows.Forms.Label contraseñaLbl;
        private System.Windows.Forms.Label dniLbl;
        private System.Windows.Forms.Label contanctoLbl;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.ComboBox idiomaCombo;
        private System.Windows.Forms.Label label1;
    }
}