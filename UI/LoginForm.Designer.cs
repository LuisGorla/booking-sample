
namespace UI
{
    partial class LoginForm
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
            this.Usuariotxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.registrarUsuarioBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Usuariotxt
            // 
            this.Usuariotxt.Location = new System.Drawing.Point(56, 219);
            this.Usuariotxt.Name = "Usuariotxt";
            this.Usuariotxt.Size = new System.Drawing.Size(153, 23);
            this.Usuariotxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // Loginbtn
            // 
            this.Loginbtn.Location = new System.Drawing.Point(97, 313);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(75, 23);
            this.Loginbtn.TabIndex = 2;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Location = new System.Drawing.Point(56, 275);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(153, 23);
            this.Passwordtxt.TabIndex = 4;
            this.Passwordtxt.UseSystemPasswordChar = true;
            // 
            // registrarUsuarioBtn
            // 
            this.registrarUsuarioBtn.Location = new System.Drawing.Point(56, 382);
            this.registrarUsuarioBtn.Name = "registrarUsuarioBtn";
            this.registrarUsuarioBtn.Size = new System.Drawing.Size(153, 23);
            this.registrarUsuarioBtn.TabIndex = 5;
            this.registrarUsuarioBtn.Text = "Registrar Usuario";
            this.registrarUsuarioBtn.UseVisualStyleBackColor = true;
            this.registrarUsuarioBtn.Click += new System.EventHandler(this.registrarUsuarioBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.booking_icon;
            this.pictureBox1.Location = new System.Drawing.Point(63, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 141);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 417);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.registrarUsuarioBtn);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Usuariotxt);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Usuariotxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.Button registrarUsuarioBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}