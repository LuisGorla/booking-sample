
namespace UI
{
    partial class BackupABM
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.Label();
            this.Directoriotxt = new System.Windows.Forms.TextBox();
            this.Usuariotxt = new System.Windows.Forms.TextBox();
            this.Savebtn = new System.Windows.Forms.Button();
            this.fechadtp = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directorio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(12, 145);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(47, 15);
            this.Usuario.TabIndex = 2;
            this.Usuario.Text = "Usuario";
            // 
            // Directoriotxt
            // 
            this.Directoriotxt.Location = new System.Drawing.Point(70, 27);
            this.Directoriotxt.Name = "Directoriotxt";
            this.Directoriotxt.Size = new System.Drawing.Size(100, 23);
            this.Directoriotxt.TabIndex = 5;
            // 
            // Usuariotxt
            // 
            this.Usuariotxt.Location = new System.Drawing.Point(70, 145);
            this.Usuariotxt.Name = "Usuariotxt";
            this.Usuariotxt.Size = new System.Drawing.Size(100, 23);
            this.Usuariotxt.TabIndex = 7;
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(84, 212);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 23);
            this.Savebtn.TabIndex = 8;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // fechadtp
            // 
            this.fechadtp.Location = new System.Drawing.Point(70, 85);
            this.fechadtp.Name = "fechadtp";
            this.fechadtp.Size = new System.Drawing.Size(200, 23);
            this.fechadtp.TabIndex = 9;
            // 
            // BackupABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fechadtp);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Usuariotxt);
            this.Controls.Add(this.Directoriotxt);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BackupABM";
            this.Text = "BackupABM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.TextBox Directoriotxt;
        private System.Windows.Forms.TextBox Usuariotxt;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.DateTimePicker fechadtp;
    }
}