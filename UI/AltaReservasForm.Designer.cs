
namespace UI
{
    partial class AltaReservasForm
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
            this.volverLoginBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // volverLoginBtn
            // 
            this.volverLoginBtn.BackColor = System.Drawing.Color.LemonChiffon;
            this.volverLoginBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.volverLoginBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.volverLoginBtn.Location = new System.Drawing.Point(109, 148);
            this.volverLoginBtn.Name = "volverLoginBtn";
            this.volverLoginBtn.Size = new System.Drawing.Size(179, 28);
            this.volverLoginBtn.TabIndex = 11;
            this.volverLoginBtn.Text = "<- Volver al Login";
            this.volverLoginBtn.UseVisualStyleBackColor = false;
            this.volverLoginBtn.Click += new System.EventHandler(this.volverLoginBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(158, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Work in Progress";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Form de Logica de negocio para genear Alta de Reservas - Trigger Patente Cliente";
            // 
            // AltaReservasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 210);
            this.Controls.Add(this.volverLoginBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaReservasForm";
            this.Text = "AltaReservasForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button volverLoginBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}