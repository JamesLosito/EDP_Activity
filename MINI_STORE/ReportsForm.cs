using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OfficeOpenXml;
using System.IO;

namespace MINI_STORE
{
    public partial class ReportsForm : Form
    {
        string connectionString = "server=localhost;user=root;password=;database=mini_store;";

        public ReportsForm()
        {
            InitializeComponent();
            LoadCategories();
            LoadReportData();
        }

        private void LoadCategories()
        {
            cbFilter.Items.Clear();
            cbFilter.Items.Add("All");

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT DISTINCT category FROM products";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbFilter.Items.Add(reader.GetString(0));
                }
            }

            cbFilter.SelectedIndex = 0;
        }

        private void LoadReportData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT product_id, product_name, category, price, stock_quantity FROM products WHERE 1=1";

                if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                    query += " AND product_name LIKE @search";

                if (cbFilter.SelectedIndex > 0)
                    query += " AND category = @category";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                    cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");

                if (cbFilter.SelectedIndex > 0)
                    cmd.Parameters.AddWithValue("@category", cbFilter.SelectedItem.ToString());

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvReport.DataSource = table;
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {

                    using (ExcelPackage package = new ExcelPackage())
                    {
                        ExcelWorksheet sheet = package.Workbook.Worksheets.Add("Product Report");

                        for (int i = 0; i < dgvReport.Columns.Count; i++)
                            sheet.Cells[1, i + 1].Value = dgvReport.Columns[i].HeaderText;

                        for (int i = 0; i < dgvReport.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvReport.Columns.Count; j++)
                                sheet.Cells[i + 2, j + 1].Value = dgvReport.Rows[i].Cells[j].Value?.ToString();
                        }

                        File.WriteAllBytes(sfd.FileName, package.GetAsByteArray());
                        MessageBox.Show("Exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadReportData();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReportData();
        }
    }
}
