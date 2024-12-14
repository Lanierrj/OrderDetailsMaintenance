﻿
namespace OrderDetailsMaintenance
{
    partial class frmCustomerMaintenance
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnFind = new Button();
            btnExit = new Button();
            txtCustomerId = new TextBox();
            txtContact = new TextBox();
            txtAddress = new TextBox();
            txtCity = new TextBox();
            btnSave = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCountry = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 52);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 0;
            label1.Text = "Search by Customer ID:";
            // 
            // btnFind
            // 
            btnFind.Location = new Point(582, 47);
            btnFind.Margin = new Padding(3, 4, 3, 4);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(86, 31);
            btnFind.TabIndex = 5;
            btnFind.Text = "&Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(463, 451);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(86, 31);
            btnExit.TabIndex = 6;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtCustomerId
            // 
            txtCustomerId.Location = new Point(267, 47);
            txtCustomerId.Margin = new Padding(3, 4, 3, 4);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(283, 27);
            txtCustomerId.TabIndex = 7;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(267, 167);
            txtContact.Margin = new Padding(3, 4, 3, 4);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(283, 27);
            txtContact.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(267, 241);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(283, 27);
            txtAddress.TabIndex = 10;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(267, 304);
            txtCity.Margin = new Padding(3, 4, 3, 4);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(283, 27);
            txtCity.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(313, 451);
            btnSave.Margin = new Padding(2, 1, 2, 1);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(93, 29);
            btnSave.TabIndex = 12;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 171);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 14;
            label3.Text = "Contact:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 245);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 15;
            label4.Text = "Ship Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 308);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 16;
            label5.Text = "Ship City:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(94, 379);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 17;
            label6.Text = "Ship Country:";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(267, 372);
            txtCountry.Margin = new Padding(3, 4, 3, 4);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(283, 27);
            txtCountry.TabIndex = 18;
            // 
            // frmCustomerMaintenance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(txtCountry);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnSave);
            Controls.Add(txtCity);
            Controls.Add(txtAddress);
            Controls.Add(txtContact);
            Controls.Add(txtCustomerId);
            Controls.Add(btnExit);
            Controls.Add(btnFind);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCustomerMaintenance";
            Text = "Madelyn Lanier's Customer Maintenance";
            Load += frmCustomerMaintenance_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label1;
        private Button btnFind;
        private Button btnExit;
        private TextBox txtCustomerId;
        private TextBox txtContact;
        private TextBox txtAddress;
        private TextBox txtCity;
        private Button btnSave;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtCountry;
    }
}