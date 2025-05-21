namespace MINI_STORE
{
    partial class SystemUsersForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;

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
            dataGridView1 = new DataGridView();
            txtId = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtRole = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(116, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(500, 200);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtId
            // 
            txtId.Location = new Point(741, 42);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "ID";
            txtId.ReadOnly = true;
            txtId.Size = new Size(250, 27);
            txtId.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(741, 72);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(250, 27);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(741, 102);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(250, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(741, 132);
            txtRole.Name = "txtRole";
            txtRole.PlaceholderText = "Role";
            txtRole.Size = new Size(250, 27);
            txtRole.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(741, 165);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(121, 25);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(884, 165);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(107, 25);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(741, 196);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(250, 25);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // SystemUsersForm
            // 
            ClientSize = new Size(1067, 284);
            Controls.Add(dataGridView1);
            Controls.Add(txtId);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtRole);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Name = "SystemUsersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage System Users";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
