namespace BillingSystem
{
    partial class CustomerListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            dgvCustomers = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnLogout = new Button();
            textBox1 = new TextBox();
            btnSearch = new Button();
            CustomerID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            ContactNumber = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Balance = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(65, 90);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(133, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Customer List";
            // 
            // dgvCustomers
            // 
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { CustomerID, FullName, Address, ContactNumber, Email, Balance });
            dgvCustomers.Location = new Point(65, 130);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.Size = new Size(643, 150);
            dgvCustomers.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(194, 343);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(124, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Customer";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(381, 343);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(515, 343);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(306, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 23);
            textBox1.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(611, 92);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // CustomerID
            // 
            CustomerID.HeaderText = "ID";
            CustomerID.Name = "CustomerID";
            // 
            // FullName
            // 
            FullName.HeaderText = "Full Name";
            FullName.Name = "FullName";
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.Name = "Address";
            // 
            // ContactNumber
            // 
            ContactNumber.HeaderText = "Contact No.";
            ContactNumber.Name = "ContactNumber";
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // Balance
            // 
            Balance.HeaderText = "Balance";
            Balance.Name = "Balance";
            // 
            // CustomerListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(textBox1);
            Controls.Add(btnSearch);
            Controls.Add(btnLogout);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvCustomers);
            Controls.Add(lblTitle);
            Name = "CustomerListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing System - Customer List";
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private DataGridView dgvCustomers;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnLogout;
        private TextBox textBox1;
        private Button btnSearch;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn ContactNumber;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Balance;
    }
}