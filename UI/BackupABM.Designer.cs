
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
            this.Savebtn = new System.Windows.Forms.Button();
            this.volverPatentesBtn = new System.Windows.Forms.Button();
            this.irRestoreBackupBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numeroParticionesTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el Numero de Particiones : ";
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(327, 82);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(110, 23);
            this.Savebtn.TabIndex = 8;
            this.Savebtn.Text = "Generar Backup";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // volverPatentesBtn
            // 
            this.volverPatentesBtn.BackColor = System.Drawing.Color.LemonChiffon;
            this.volverPatentesBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.volverPatentesBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.volverPatentesBtn.Location = new System.Drawing.Point(12, 164);
            this.volverPatentesBtn.Name = "volverPatentesBtn";
            this.volverPatentesBtn.Size = new System.Drawing.Size(267, 29);
            this.volverPatentesBtn.TabIndex = 10;
            this.volverPatentesBtn.Text = "<- Volver a Administracion de Patentes";
            this.volverPatentesBtn.UseVisualStyleBackColor = false;
            this.volverPatentesBtn.Click += new System.EventHandler(this.volverPatentesBtn_Click);
            // 
            // irRestoreBackupBtn
            // 
            this.irRestoreBackupBtn.BackColor = System.Drawing.Color.LemonChiffon;
            this.irRestoreBackupBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.irRestoreBackupBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.irRestoreBackupBtn.Location = new System.Drawing.Point(284, 164);
            this.irRestoreBackupBtn.Name = "irRestoreBackupBtn";
            this.irRestoreBackupBtn.Size = new System.Drawing.Size(165, 29);
            this.irRestoreBackupBtn.TabIndex = 11;
            this.irRestoreBackupBtn.Text = "Ir a Restore Backups ->";
            this.irRestoreBackupBtn.UseVisualStyleBackColor = false;
            this.irRestoreBackupBtn.Click += new System.EventHandler(this.irRestoreBackupBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "(MAX 2)";
            // 
            // numeroParticionesTxt
            // 
            this.numeroParticionesTxt.Location = new System.Drawing.Point(211, 22);
            this.numeroParticionesTxt.Name = "numeroParticionesTxt";
            this.numeroParticionesTxt.Size = new System.Drawing.Size(110, 23);
            this.numeroParticionesTxt.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Savebtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numeroParticionesTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 111);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generar Backup";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Por default, los backups se guardaran en C:\\backups";
            // 
            // BackupABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 202);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.irRestoreBackupBtn);
            this.Controls.Add(this.volverPatentesBtn);
            this.Name = "BackupABM";
            this.Text = "BackupABM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button volverPatentesBtn;
        private System.Windows.Forms.Button irRestoreBackupBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numeroParticionesTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}