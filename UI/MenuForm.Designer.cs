
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.borrarUserSinPatenteBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.usuarioDataGrid = new System.Windows.Forms.DataGridView();
            this.patenteDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patenteDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // asignarPatenteBtn
            // 
            this.asignarPatenteBtn.Location = new System.Drawing.Point(200, 215);
            this.asignarPatenteBtn.Name = "asignarPatenteBtn";
            this.asignarPatenteBtn.Size = new System.Drawing.Size(114, 23);
            this.asignarPatenteBtn.TabIndex = 0;
            this.asignarPatenteBtn.Text = "Asignar Patente";
            this.asignarPatenteBtn.UseVisualStyleBackColor = true;
            this.asignarPatenteBtn.Click += new System.EventHandler(this.asignarPatenteBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(104, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(104, 376);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
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
            this.groupBox1.Controls.Add(this.borrarUserSinPatenteBtn);
            this.groupBox1.Location = new System.Drawing.Point(597, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 303);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adminitracion de Usuarios";
            // 
            // usuarioDataGrid
            // 
            this.usuarioDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarioDataGrid.Location = new System.Drawing.Point(12, 48);
            this.usuarioDataGrid.Name = "usuarioDataGrid";
            this.usuarioDataGrid.RowTemplate.Height = 25;
            this.usuarioDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usuarioDataGrid.Size = new System.Drawing.Size(227, 150);
            this.usuarioDataGrid.TabIndex = 5;
            this.usuarioDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usuarioDataGrid_CellClick);
            this.usuarioDataGrid.SelectionChanged += new System.EventHandler(this.usuarioDataGrid_SelectionChanged);
            // 
            // patenteDataGrid
            // 
            this.patenteDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patenteDataGrid.Location = new System.Drawing.Point(275, 48);
            this.patenteDataGrid.Name = "patenteDataGrid";
            this.patenteDataGrid.RowTemplate.Height = 25;
            this.patenteDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patenteDataGrid.Size = new System.Drawing.Size(240, 150);
            this.patenteDataGrid.TabIndex = 6;
            this.patenteDataGrid.SelectionChanged += new System.EventHandler(this.patenteDataGrid_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleccione el Usuario + la Patente y luego haga click en Asignar Patente";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patenteDataGrid);
            this.Controls.Add(this.usuarioDataGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.asignarPatenteBtn);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patenteDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button asignarPatenteBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button borrarUserSinPatenteBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView usuarioDataGrid;
        private System.Windows.Forms.DataGridView patenteDataGrid;
        private System.Windows.Forms.Label label1;
    }
}