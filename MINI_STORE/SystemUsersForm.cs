using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MINI_STORE
{
    public partial class SystemUsersForm : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=;database=mini_store;");

        public SystemUsersForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM users", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtRole.Text == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO users (username, password, role) VALUES (@username, @password, @role)", conn);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text); // For production: hash this!
                cmd.Parameters.AddWithValue("@role", txtRole.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadUsers();
                MessageBox.Show("User added successfully!");
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding user: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Please select a user to update.");
                return;
            }

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE users SET username=@username, password=@password, role=@role WHERE iduser=@id", conn);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text); // For production: hash this!
                cmd.Parameters.AddWithValue("@role", txtRole.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadUsers();
                MessageBox.Show("User updated successfully!");
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.No) return;

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM users WHERE iduser=@id", conn);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadUsers();
                MessageBox.Show("User deleted successfully!");
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtId.Text = row.Cells["iduser"].Value?.ToString();
                txtUsername.Text = row.Cells["username"].Value?.ToString();
                txtPassword.Text = row.Cells["password"].Value?.ToString();
                txtRole.Text = row.Cells["role"].Value?.ToString();
            }
        }

        private void ClearFields()
        {
            txtId.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtRole.Clear();
        }
    }
}
