
namespace UI
{
    partial class OrdenCompraForm
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
            this.volverPatentesBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // volverPatentesBtn
            // 
            this.volverPatentesBtn.BackColor = System.Drawing.Color.LemonChiffon;
            this.volverPatentesBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.volverPatentesBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.volverPatentesBtn.Location = new System.Drawing.Point(150, 176);
            this.volverPatentesBtn.Name = "volverPatentesBtn";
            this.volverPatentesBtn.Size = new System.Drawing.Size(179, 28);
            this.volverPatentesBtn.TabIndex = 11;
            this.volverPatentesBtn.Text = "<- Volver al Login";
            this.volverPatentesBtn.UseVisualStyleBackColor = false;
            this.volverPatentesBtn.Click += new System.EventHandler(this.volverPatentesBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(199, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Work in Progress";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Form de Logica de negocio para administrar Ordenes de Compra por Reservas - Trigg" +
    "er Patente Supervisor";
            // 
            // OrdenCompraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 258);
            this.Controls.Add(this.volverPatentesBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrdenCompraForm";
            this.Text = "OrdenCompraForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button volverPatentesBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}