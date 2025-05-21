namespace MINI_STORE
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button forgotPasswordButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            forgotPasswordButton = new Button();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(163, 100);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 23);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(163, 140);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 23);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(263, 100);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(210, 27);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(263, 140);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(210, 27);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(263, 180);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(80, 30);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // forgotPasswordButton
            // 
            forgotPasswordButton.Location = new Point(353, 180);
            forgotPasswordButton.Name = "forgotPasswordButton";
            forgotPasswordButton.Size = new Size(120, 30);
            forgotPasswordButton.TabIndex = 5;
            forgotPasswordButton.Text = "Forgot Password";
            forgotPasswordButton.Click += forgotPasswordButton_Click;
            // 
            // LoginForm
            // 
            ClientSize = new Size(664, 347);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(forgotPasswordButton);
            Cursor = Cursors.IBeam;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - Mini Store";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
