namespace MINI_STORE
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.DataGridView dgvReport;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(20, 20);
            this.txtSearch.Size = new System.Drawing.Size(200, 25);
            this.txtSearch.PlaceholderText = "Search product name...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.Location = new System.Drawing.Point(240, 20);
            this.cbFilter.Size = new System.Drawing.Size(150, 25);
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(410, 20);
            this.btnExportExcel.Size = new System.Drawing.Size(120, 25);
            this.btnExportExcel.Text = "Export to Excel";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.Location = new System.Drawing.Point(20, 60);
            this.dgvReport.Size = new System.Drawing.Size(760, 380);
            this.dgvReport.ReadOnly = true;
            // 
            // ReportsForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.dgvReport);
            this.Name = "ReportsForm";
            this.Text = "Reports - Products";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
