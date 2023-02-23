﻿namespace WinForms.UserControlls
{
    partial class CashierControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView2 = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            EmployeeID = new DataGridViewTextBoxColumn();
            CustomerID = new DataGridViewTextBoxColumn();
            PaymentMethod = new DataGridViewComboBoxColumn();
            TotalValue = new DataGridViewTextBoxColumn();
            dataGridView3 = new DataGridView();
            TransactionID = new DataGridViewTextBoxColumn();
            ItemID = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            ItemPrice = new DataGridViewTextBoxColumn();
            NetValue = new DataGridViewTextBoxColumn();
            DiscountPercent = new DataGridViewTextBoxColumn();
            DiscountValue = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            surname = new DataGridViewTextBoxColumn();
            cardNumber = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Date, EmployeeID, CustomerID, PaymentMethod, TotalValue });
            dataGridView2.Location = new Point(84, 546);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 72;
            dataGridView2.RowTemplate.Height = 37;
            dataGridView2.Size = new Size(2514, 291);
            dataGridView2.TabIndex = 1;
            // 
            // Date
            // 
            Date.HeaderText = "Date:";
            Date.MinimumWidth = 9;
            Date.Name = "Date";
            Date.Width = 175;
            // 
            // EmployeeID
            // 
            EmployeeID.HeaderText = "Employee ID:";
            EmployeeID.MinimumWidth = 9;
            EmployeeID.Name = "EmployeeID";
            EmployeeID.Width = 175;
            // 
            // CustomerID
            // 
            CustomerID.HeaderText = "Customer ID:";
            CustomerID.MinimumWidth = 9;
            CustomerID.Name = "CustomerID";
            CustomerID.Width = 175;
            // 
            // PaymentMethod
            // 
            PaymentMethod.HeaderText = "Payment Method:";
            PaymentMethod.MinimumWidth = 9;
            PaymentMethod.Name = "PaymentMethod";
            PaymentMethod.Resizable = DataGridViewTriState.True;
            PaymentMethod.SortMode = DataGridViewColumnSortMode.Automatic;
            PaymentMethod.Width = 175;
            // 
            // TotalValue
            // 
            TotalValue.HeaderText = "Total Value:";
            TotalValue.MinimumWidth = 9;
            TotalValue.Name = "TotalValue";
            TotalValue.Width = 175;
            // 
            // dataGridView3
            // 
            dataGridView3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { TransactionID, ItemID, Quantity, ItemPrice, NetValue, DiscountPercent, DiscountValue, dataGridViewTextBoxColumn1 });
            dataGridView3.Location = new Point(84, 991);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RightToLeft = RightToLeft.No;
            dataGridView3.RowHeadersWidth = 72;
            dataGridView3.RowTemplate.Height = 37;
            dataGridView3.ShowCellErrors = false;
            dataGridView3.Size = new Size(2514, 262);
            dataGridView3.TabIndex = 2;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // TransactionID
            // 
            TransactionID.HeaderText = "Transaction ID:";
            TransactionID.MinimumWidth = 9;
            TransactionID.Name = "TransactionID";
            TransactionID.Width = 175;
            // 
            // ItemID
            // 
            ItemID.HeaderText = "Item ID:";
            ItemID.MinimumWidth = 9;
            ItemID.Name = "ItemID";
            ItemID.Width = 175;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 9;
            Quantity.Name = "Quantity";
            Quantity.Width = 175;
            // 
            // ItemPrice
            // 
            ItemPrice.HeaderText = "Item Price:";
            ItemPrice.MinimumWidth = 9;
            ItemPrice.Name = "ItemPrice";
            ItemPrice.Width = 175;
            // 
            // NetValue
            // 
            NetValue.HeaderText = "Net Value:";
            NetValue.MinimumWidth = 9;
            NetValue.Name = "NetValue";
            NetValue.Width = 175;
            // 
            // DiscountPercent
            // 
            DiscountPercent.HeaderText = "Discount Percent:";
            DiscountPercent.MinimumWidth = 9;
            DiscountPercent.Name = "DiscountPercent";
            DiscountPercent.Width = 175;
            // 
            // DiscountValue
            // 
            DiscountValue.HeaderText = "Discount Value:";
            DiscountValue.MinimumWidth = 9;
            DiscountValue.Name = "DiscountValue";
            DiscountValue.Width = 175;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Total Value:";
            dataGridViewTextBoxColumn1.MinimumWidth = 9;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 175;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 97);
            label1.Name = "label1";
            label1.Size = new Size(111, 30);
            label1.TabIndex = 3;
            label1.Text = "Customers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 513);
            label2.Name = "label2";
            label2.Size = new Size(127, 30);
            label2.TabIndex = 4;
            label2.Text = "Transactions";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 958);
            label3.Name = "label3";
            label3.Size = new Size(171, 30);
            label3.TabIndex = 5;
            label3.Text = "Transaction Lines";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 19);
            label4.Name = "label4";
            label4.Size = new Size(119, 30);
            label4.TabIndex = 6;
            label4.Text = "Cashier Tab";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { name, surname, cardNumber });
            dataGridView1.Location = new Point(84, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.Size = new Size(2514, 262);
            dataGridView1.TabIndex = 7;
            // 
            // name
            // 
            name.HeaderText = "Name:";
            name.MinimumWidth = 9;
            name.Name = "name";
            name.Width = 175;
            // 
            // surname
            // 
            surname.HeaderText = "Surname:";
            surname.MinimumWidth = 9;
            surname.Name = "surname";
            surname.Width = 175;
            // 
            // cardNumber
            // 
            cardNumber.HeaderText = "CardNumber:";
            cardNumber.MinimumWidth = 9;
            cardNumber.Name = "cardNumber";
            cardNumber.Width = 175;
            // 
            // CashierControl
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Name = "CashierControl";
            Size = new Size(2708, 1355);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn EmployeeID;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewComboBoxColumn PaymentMethod;
        private DataGridViewTextBoxColumn TotalValue;
        private DataGridViewTextBoxColumn TransactionID;
        private DataGridViewTextBoxColumn ItemID;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn ItemPrice;
        private DataGridViewTextBoxColumn NetValue;
        private DataGridViewTextBoxColumn DiscountPercent;
        private DataGridViewTextBoxColumn DiscountValue;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn surname;
        private DataGridViewTextBoxColumn cardNumber;
    }
}