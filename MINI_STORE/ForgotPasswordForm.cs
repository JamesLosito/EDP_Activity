using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MINI_STORE
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        string connectionString = "server=localhost;user=root;password=;database=mini_store;";

        private void btnRecover_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Enter your username first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT password FROM users WHERE username = @username";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string password = result.ToString();
                        MessageBox.Show($"Your password is: {password}", "Password Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Username not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }

        private void linkReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Show reset UI
            lblNewPassword.Visible = true;
            txtNewPassword.Visible = true;
            btnResetPassword.Visible = true;

            // Hide recovery button
            btnRecover.Visible = false;
            linkReset.Visible = false;
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();

            if (username == "" || newPassword == "")
            {
                MessageBox.Show("Please enter both username and new password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE users SET password = @newPassword WHERE username = @username";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@newPassword", newPassword);

                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Password reset successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }
    }
}
