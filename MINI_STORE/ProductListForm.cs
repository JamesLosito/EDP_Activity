using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MINI_STORE
{
    public partial class ProductListForm : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=;database=mini_store;");

        private string _userRole;

        public ProductListForm(string userRole)
        {
            InitializeComponent();
            _userRole = userRole;

            // Event hookup (ensure it’s connected)
            dataGridView1.CellClick += dataGridView1_CellClick;

            LoadProducts();

            // Show buttons based on role
            btnUserList.Visible = _userRole.ToLower() == "admin";
            btnLogout.Visible = _userRole.ToLower() == "staff" || _userRole.ToLower() == "admin";
        }

        private void LoadProducts()
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM products", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("CALL add_product(@name, @cat, @price, @stock)", conn);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@cat", txtCategory.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text));
                cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(txtStock.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadProducts();
                MessageBox.Show("Product added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Please select a product to update.");
                return;
            }

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("CALL update_product(@id, @name, @cat, @price, @stock)", conn);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@cat", txtCategory.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text));
                cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(txtStock.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadProducts();
                MessageBox.Show("Product updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.No)
                return;

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("CALL delete_product(@id)", conn);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadProducts();
                MessageBox.Show("Product deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Prefer indexes to avoid column name mismatches
                txtId.Text = row.Cells[0].Value?.ToString();       // product_id
                txtName.Text = row.Cells[1].Value?.ToString();     // product_name
                txtCategory.Text = row.Cells[2].Value?.ToString(); // category
                txtPrice.Text = row.Cells[3].Value?.ToString();    // price
                txtStock.Text = row.Cells[4].Value?.ToString();    // stock_quantity
            }
        }

        private void btnUserList_Click(object sender, EventArgs e)
        {
            SystemUsersForm userForm = new SystemUsersForm();
            userForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm reportForm = new ReportsForm();
            reportForm.ShowDialog();
        }
    }
}
