namespace BillingSystem
{
    partial class AddCustomerForm
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
            lbtTilte = new Label();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblContact = new Label();
            txtContact = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblBalance = new Label();
            txtBalance = new TextBox();
            btnSave = new Button();
            btnClear = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lbtTilte
            // 
            lbtTilte.AutoSize = true;
            lbtTilte.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbtTilte.Location = new Point(141, 39);
            lbtTilte.Name = "lbtTilte";
            lbtTilte.Size = new Size(157, 21);
            lbtTilte.TabIndex = 0;
            lbtTilte.Text = "Add New Customer";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(45, 93);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(64, 15);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Full Name:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(150, 89);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(225, 23);
            txtFullName.TabIndex = 1;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(45, 122);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(52, 15);
            lblAddress.TabIndex = 0;
            lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(150, 119);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(225, 23);
            txtAddress.TabIndex = 1;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContact.Location = new Point(45, 151);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(99, 15);
            lblContact.TabIndex = 0;
            lblContact.Text = "Contact Number:";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(150, 148);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(225, 23);
            txtContact.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(45, 180);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 176);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(225, 23);
            txtEmail.TabIndex = 1;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(45, 209);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(83, 15);
            lblBalance.TabIndex = 0;
            lblBalance.Text = "Initial Balance:";
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(150, 205);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(100, 23);
            txtBalance.TabIndex = 1;
            txtBalance.Text = "0.00";
            txtBalance.TextChanged += txtBalance_TextChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(89, 273);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(182, 273);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(272, 273);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // AddCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 381);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(txtBalance);
            Controls.Add(lblBalance);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtContact);
            Controls.Add(lblContact);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(lbtTilte);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddCustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing System - Add Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbtTilte;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblContact;
        private TextBox txtContact;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblBalance;
        private TextBox txtBalance;
        private Button btnSave;
        private Button btnClear;
        private Button btnBack;
    }
}