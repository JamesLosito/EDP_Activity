namespace MINI_STORE
{
    partial class ForgotPasswordForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnRecover;
        private System.Windows.Forms.LinkLabel linkReset;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnResetPassword;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblUsername = new Label();
            txtUsername = new TextBox();
            btnRecover = new Button();
            linkReset = new LinkLabel();
            lblNewPassword = new Label();
            txtNewPassword = new TextBox();
            btnResetPassword = new Button();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(40, 30);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 20);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(150, 30);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(180, 27);
            txtUsername.TabIndex = 1;
            // 
            // btnRecover
            // 
            btnRecover.Location = new Point(150, 70);
            btnRecover.Name = "btnRecover";
            btnRecover.Size = new Size(120, 30);
            btnRecover.TabIndex = 2;
            btnRecover.Text = "Recover Password";
            btnRecover.Click += btnRecover_Click;
            // 
            // linkReset
            // 
            linkReset.Location = new Point(150, 110);
            linkReset.Name = "linkReset";
            linkReset.Size = new Size(200, 20);
            linkReset.TabIndex = 3;
            linkReset.TabStop = true;
            linkReset.Text = "Reset password instead?";
            linkReset.LinkClicked += linkReset_LinkClicked;
            // 
            // lblNewPassword
            // 
            lblNewPassword.Location = new Point(40, 150);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(100, 20);
            lblNewPassword.TabIndex = 4;
            lblNewPassword.Text = "New Password:";
            lblNewPassword.Visible = false;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(150, 150);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(180, 27);
            txtNewPassword.TabIndex = 5;
            txtNewPassword.Visible = false;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Location = new Point(150, 190);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(120, 30);
            btnResetPassword.TabIndex = 6;
            btnResetPassword.Text = "Reset Password";
            btnResetPassword.Visible = false;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // ForgotPasswordForm
            // 
            ClientSize = new Size(400, 250);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(btnRecover);
            Controls.Add(linkReset);
            Controls.Add(lblNewPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(btnResetPassword);
            Name = "ForgotPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forgot Password";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
