using System.Drawing;
using System.Windows.Forms;

namespace ev3
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        // Campos agregados para login
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnRegister;
        private Label lblEmail;
        private Label lblPassword;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SuspendLayout();
            // lblEmail
            lblEmail = new Label();
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(30, 30);
            lblEmail.Text = "Correo";
            // txtEmail
            txtEmail = new TextBox();
            txtEmail.Location = new Point(30, 50);
            txtEmail.Size = new Size(240, 23);
            // lblPassword
            lblPassword = new Label();
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(30, 90);
            lblPassword.Text = "Contraseña";
            // txtPassword
            txtPassword = new TextBox();
            txtPassword.Location = new Point(30, 110);
            txtPassword.Size = new Size(240, 23);
            txtPassword.PasswordChar = '*';
            // btnLogin
            btnLogin = new Button();
            btnLogin.Location = new Point(30, 155);
            btnLogin.Size = new Size(110, 30);
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += BtnLogin_Click;
            // btnRegister
            btnRegister = new Button();
            btnRegister.Location = new Point(160, 155);
            btnRegister.Size = new Size(110, 30);
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += BtnRegister_Click;
            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 220);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
