using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MINI_STORE
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // Database connection string (XAMPP - MySQL)
        string connectionString = "server=localhost;user=root;password=;database=mini_store;";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT role FROM users WHERE username = @username AND password = @password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string userRole = result.ToString(); // Get the role (admin or staff)

                        this.Hide(); // Hide LoginForm
                        ProductListForm productForm = new ProductListForm(userRole);
                        productForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void forgotPasswordButton_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm forgotForm = new ForgotPasswordForm();
            forgotForm.ShowDialog();
        }
    }
}
