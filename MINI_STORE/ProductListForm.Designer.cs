namespace MINI_STORE
{
    partial class ProductListForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUserList;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReports;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUserList = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(106, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(717, 292);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(898, 60);
            this.txtId.Name = "txtId";
            this.txtId.PlaceholderText = "Product ID";
            this.txtId.Size = new System.Drawing.Size(239, 27);
            this.txtId.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(898, 90);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Product Name";
            this.txtName.Size = new System.Drawing.Size(239, 27);
            this.txtName.TabIndex = 3;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(898, 120);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.PlaceholderText = "Category";
            this.txtCategory.Size = new System.Drawing.Size(239, 27);
            this.txtCategory.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(898, 150);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PlaceholderText = "Price";
            this.txtPrice.Size = new System.Drawing.Size(239, 27);
            this.txtPrice.TabIndex = 5;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(898, 180);
            this.txtStock.Name = "txtStock";
            this.txtStock.PlaceholderText = "Stock Quantity";
            this.txtStock.Size = new System.Drawing.Size(239, 27);
            this.txtStock.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(898, 210);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 44);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1027, 210);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 44);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(898, 260);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(239, 44);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1063, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 30);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUserList
            // 
            this.btnUserList.Location = new System.Drawing.Point(851, 12);
            this.btnUserList.Name = "btnUserList";
            this.btnUserList.Size = new System.Drawing.Size(100, 30);
            this.btnUserList.TabIndex = 11;
            this.btnUserList.Text = "User List";
            this.btnUserList.UseVisualStyleBackColor = true;
            this.btnUserList.Click += new System.EventHandler(this.btnUserList_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(957, 12);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(100, 30);
            this.btnReports.TabIndex = 12;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // ProductListForm
            // 
            this.ClientSize = new System.Drawing.Size(1183, 323);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnUserList);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProductListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product List";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
