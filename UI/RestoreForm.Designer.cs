
namespace UI
{
    partial class RestoreForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.examinarBtn = new System.Windows.Forms.Button();
            this.restoreBtn = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.volverBackupBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // examinarBtn
            // 
            this.examinarBtn.Location = new System.Drawing.Point(340, 48);
            this.examinarBtn.Name = "examinarBtn";
            this.examinarBtn.Size = new System.Drawing.Size(109, 23);
            this.examinarBtn.TabIndex = 0;
            this.examinarBtn.Text = "Examinar";
            this.examinarBtn.UseVisualStyleBackColor = true;
            this.examinarBtn.Click += new System.EventHandler(this.examinarBtn_Click);
            // 
            // restoreBtn
            // 
            this.restoreBtn.Location = new System.Drawing.Point(340, 138);
            this.restoreBtn.Name = "restoreBtn";
            this.restoreBtn.Size = new System.Drawing.Size(109, 23);
            this.restoreBtn.TabIndex = 1;
            this.restoreBtn.Text = "Restore";
            this.restoreBtn.UseVisualStyleBackColor = true;
            this.restoreBtn.Click += new System.EventHandler(this.restoreBtn_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dirijase a la carpeta C:\\backups y seleccione los archivos a restaurar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(468, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Una vez seleccionados, presione Restore para cargarlos en la Base de Datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "1)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(3, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "2)";
            // 
            // volverBackupBtn
            // 
            this.volverBackupBtn.BackColor = System.Drawing.Color.LemonChiffon;
            this.volverBackupBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.volverBackupBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.volverBackupBtn.Location = new System.Drawing.Point(30, 193);
            this.volverBackupBtn.Name = "volverBackupBtn";
            this.volverBackupBtn.Size = new System.Drawing.Size(267, 29);
            this.volverBackupBtn.TabIndex = 11;
            this.volverBackupBtn.Text = "<- Volver a Administracion de Backups";
            this.volverBackupBtn.UseVisualStyleBackColor = false;
            this.volverBackupBtn.Click += new System.EventHandler(this.volverBackupBtn_Click);
            // 
            // RestoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 234);
            this.Controls.Add(this.volverBackupBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.restoreBtn);
            this.Controls.Add(this.examinarBtn);
            this.Name = "RestoreForm";
            this.Text = "RestoreForm";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button examinarBtn;
        private System.Windows.Forms.Button restoreBtn;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button volverBackupBtn;
    }
}