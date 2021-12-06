
namespace UI
{
    partial class BitacoraForm
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
            this.bitacoraDgv = new System.Windows.Forms.DataGridView();
            this.dedeDtp = new System.Windows.Forms.DateTimePicker();
            this.hastaDtp = new System.Windows.Forms.DateTimePicker();
            this.usuarioBox = new System.Windows.Forms.ComboBox();
            this.criticidadBox = new System.Windows.Forms.ComboBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.filtrarBtn = new System.Windows.Forms.Button();
            this.generarPdfBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bitacoraDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // bitacoraDgv
            // 
            this.bitacoraDgv.AllowUserToAddRows = false;
            this.bitacoraDgv.AllowUserToDeleteRows = false;
            this.bitacoraDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bitacoraDgv.Location = new System.Drawing.Point(12, 12);
            this.bitacoraDgv.Name = "bitacoraDgv";
            this.bitacoraDgv.ReadOnly = true;
            this.bitacoraDgv.RowTemplate.Height = 25;
            this.bitacoraDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bitacoraDgv.Size = new System.Drawing.Size(536, 290);
            this.bitacoraDgv.TabIndex = 0;
            // 
            // dedeDtp
            // 
            this.dedeDtp.Location = new System.Drawing.Point(575, 190);
            this.dedeDtp.Name = "dedeDtp";
            this.dedeDtp.Size = new System.Drawing.Size(200, 23);
            this.dedeDtp.TabIndex = 1;
            // 
            // hastaDtp
            // 
            this.hastaDtp.Location = new System.Drawing.Point(575, 261);
            this.hastaDtp.Name = "hastaDtp";
            this.hastaDtp.Size = new System.Drawing.Size(200, 23);
            this.hastaDtp.TabIndex = 2;
            // 
            // usuarioBox
            // 
            this.usuarioBox.FormattingEnabled = true;
            this.usuarioBox.Location = new System.Drawing.Point(617, 41);
            this.usuarioBox.Name = "usuarioBox";
            this.usuarioBox.Size = new System.Drawing.Size(121, 23);
            this.usuarioBox.TabIndex = 3;
            this.usuarioBox.SelectedIndexChanged += new System.EventHandler(this.usuarioBox_SelectedIndexChanged);
            // 
            // criticidadBox
            // 
            this.criticidadBox.FormattingEnabled = true;
            this.criticidadBox.Location = new System.Drawing.Point(617, 117);
            this.criticidadBox.Name = "criticidadBox";
            this.criticidadBox.Size = new System.Drawing.Size(121, 23);
            this.criticidadBox.TabIndex = 4;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(12, 339);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 5;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // filtrarBtn
            // 
            this.filtrarBtn.Location = new System.Drawing.Point(245, 339);
            this.filtrarBtn.Name = "filtrarBtn";
            this.filtrarBtn.Size = new System.Drawing.Size(75, 23);
            this.filtrarBtn.TabIndex = 6;
            this.filtrarBtn.Text = "Filtrar";
            this.filtrarBtn.UseVisualStyleBackColor = true;
            this.filtrarBtn.Click += new System.EventHandler(this.filtrarBtn_Click);
            // 
            // generarPdfBtn
            // 
            this.generarPdfBtn.Location = new System.Drawing.Point(441, 339);
            this.generarPdfBtn.Name = "generarPdfBtn";
            this.generarPdfBtn.Size = new System.Drawing.Size(107, 23);
            this.generarPdfBtn.TabIndex = 7;
            this.generarPdfBtn.Text = "Generar PDF";
            this.generarPdfBtn.UseVisualStyleBackColor = true;
            this.generarPdfBtn.Click += new System.EventHandler(this.generarPdfBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(575, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Filtro por Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(575, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Filtro por Criticidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(575, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(575, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hasta";
            // 
            // BitacoraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 397);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generarPdfBtn);
            this.Controls.Add(this.filtrarBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.criticidadBox);
            this.Controls.Add(this.usuarioBox);
            this.Controls.Add(this.hastaDtp);
            this.Controls.Add(this.dedeDtp);
            this.Controls.Add(this.bitacoraDgv);
            this.Name = "BitacoraForm";
            this.Text = "BitacoraForm";
            this.Load += new System.EventHandler(this.BitacoraForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BitacoraForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bitacoraDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bitacoraDgv;
        private System.Windows.Forms.DateTimePicker dedeDtp;
        private System.Windows.Forms.DateTimePicker hastaDtp;
        private System.Windows.Forms.ComboBox usuarioBox;
        private System.Windows.Forms.ComboBox criticidadBox;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button filtrarBtn;
        private System.Windows.Forms.Button generarPdfBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}