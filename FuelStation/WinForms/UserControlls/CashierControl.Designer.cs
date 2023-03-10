namespace WinForms.UserControlls
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
            customerSavebtn = new Button();
            cusDelbtn = new Button();
            refreshbtm = new Button();
            traSavebtn = new Button();
            traDeletebtn = new Button();
            traliSavebtn = new Button();
            traLnbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Date, EmployeeID, CustomerID, PaymentMethod, TotalValue });
            dataGridView2.Location = new Point(0, 533);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 72;
            dataGridView2.RowTemplate.Height = 37;
            dataGridView2.Size = new Size(2514, 291);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Date.DataPropertyName = "Date";
            Date.HeaderText = "Date:";
            Date.MinimumWidth = 9;
            Date.Name = "Date";
            // 
            // EmployeeID
            // 
            EmployeeID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EmployeeID.DataPropertyName = "EmployeeID";
            EmployeeID.HeaderText = "Employee ID:";
            EmployeeID.MinimumWidth = 9;
            EmployeeID.Name = "EmployeeID";
            // 
            // CustomerID
            // 
            CustomerID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CustomerID.DataPropertyName = "CustomerID";
            CustomerID.HeaderText = "Customer ID:";
            CustomerID.MinimumWidth = 9;
            CustomerID.Name = "CustomerID";
            // 
            // PaymentMethod
            // 
            PaymentMethod.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PaymentMethod.DataPropertyName = "PaymentMethod";
            PaymentMethod.HeaderText = "Payment Method:";
            PaymentMethod.MinimumWidth = 9;
            PaymentMethod.Name = "PaymentMethod";
            PaymentMethod.Resizable = DataGridViewTriState.True;
            PaymentMethod.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // TotalValue
            // 
            TotalValue.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TotalValue.DataPropertyName = "TotalValue";
            TotalValue.HeaderText = "Total Value:";
            TotalValue.MinimumWidth = 9;
            TotalValue.Name = "TotalValue";
            // 
            // dataGridView3
            // 
            dataGridView3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { TransactionID, ItemID, Quantity, ItemPrice, NetValue, DiscountPercent, DiscountValue, dataGridViewTextBoxColumn1 });
            dataGridView3.Location = new Point(0, 1020);
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
            TransactionID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TransactionID.DataPropertyName = "TransactionID";
            TransactionID.HeaderText = "Transaction ID:";
            TransactionID.MinimumWidth = 9;
            TransactionID.Name = "TransactionID";
            // 
            // ItemID
            // 
            ItemID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ItemID.DataPropertyName = "ItemID";
            ItemID.HeaderText = "Item ID:";
            ItemID.MinimumWidth = 9;
            ItemID.Name = "ItemID";
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 9;
            Quantity.Name = "Quantity";
            // 
            // ItemPrice
            // 
            ItemPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ItemPrice.DataPropertyName = "ItemPrice";
            ItemPrice.HeaderText = "Item Price:";
            ItemPrice.MinimumWidth = 9;
            ItemPrice.Name = "ItemPrice";
            // 
            // NetValue
            // 
            NetValue.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NetValue.DataPropertyName = "NetValue";
            NetValue.HeaderText = "Net Value:";
            NetValue.MinimumWidth = 9;
            NetValue.Name = "NetValue";
            // 
            // DiscountPercent
            // 
            DiscountPercent.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DiscountPercent.DataPropertyName = "DiscountPercent";
            DiscountPercent.HeaderText = "Discount Percent:";
            DiscountPercent.MinimumWidth = 9;
            DiscountPercent.Name = "DiscountPercent";
            // 
            // DiscountValue
            // 
            DiscountValue.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DiscountValue.DataPropertyName = "DiscountValue";
            DiscountValue.HeaderText = "Discount Value:";
            DiscountValue.MinimumWidth = 9;
            DiscountValue.Name = "DiscountValue";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.DataPropertyName = "TotalValue";
            dataGridViewTextBoxColumn1.HeaderText = "Total Value:";
            dataGridViewTextBoxColumn1.MinimumWidth = 9;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(8, 50);
            label1.Name = "label1";
            label1.Size = new Size(111, 30);
            label1.TabIndex = 3;
            label1.Text = "Customers";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(0, 500);
            label2.Name = "label2";
            label2.Size = new Size(127, 30);
            label2.TabIndex = 4;
            label2.Text = "Transactions";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(0, 987);
            label3.Name = "label3";
            label3.Size = new Size(171, 30);
            label3.TabIndex = 5;
            label3.Text = "Transaction Lines";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(119, 30);
            label4.TabIndex = 6;
            label4.Text = "Cashier Tab";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { name, surname, cardNumber });
            dataGridView1.Location = new Point(0, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.Size = new Size(2514, 262);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.DataPropertyName = "Name";
            name.HeaderText = "Name:";
            name.MinimumWidth = 9;
            name.Name = "name";
            // 
            // surname
            // 
            surname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            surname.DataPropertyName = "Surname";
            surname.HeaderText = "Surname:";
            surname.MinimumWidth = 9;
            surname.Name = "surname";
            // 
            // cardNumber
            // 
            cardNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cardNumber.DataPropertyName = "CardNumber";
            cardNumber.HeaderText = "CardNumber:";
            cardNumber.MinimumWidth = 9;
            cardNumber.Name = "cardNumber";
            // 
            // customerSavebtn
            // 
            customerSavebtn.Location = new Point(3, 351);
            customerSavebtn.Name = "customerSavebtn";
            customerSavebtn.Size = new Size(131, 40);
            customerSavebtn.TabIndex = 8;
            customerSavebtn.Text = "Save";
            customerSavebtn.UseVisualStyleBackColor = true;
            customerSavebtn.Click += customerSavebtn_Click;
            // 
            // cusDelbtn
            // 
            cusDelbtn.Location = new Point(140, 351);
            cusDelbtn.Name = "cusDelbtn";
            cusDelbtn.Size = new Size(131, 40);
            cusDelbtn.TabIndex = 9;
            cusDelbtn.Text = "Delete";
            cusDelbtn.UseVisualStyleBackColor = true;
            // 
            // refreshbtm
            // 
            refreshbtm.Location = new Point(172, 21);
            refreshbtm.Name = "refreshbtm";
            refreshbtm.Size = new Size(131, 40);
            refreshbtm.TabIndex = 10;
            refreshbtm.Text = "Refresh";
            refreshbtm.UseVisualStyleBackColor = true;
            refreshbtm.Click += refreshbtm_Click;
            // 
            // traSavebtn
            // 
            traSavebtn.Location = new Point(8, 830);
            traSavebtn.Name = "traSavebtn";
            traSavebtn.Size = new Size(131, 40);
            traSavebtn.TabIndex = 11;
            traSavebtn.Text = "Save";
            traSavebtn.UseVisualStyleBackColor = true;
            // 
            // traDeletebtn
            // 
            traDeletebtn.Location = new Point(145, 830);
            traDeletebtn.Name = "traDeletebtn";
            traDeletebtn.Size = new Size(131, 40);
            traDeletebtn.TabIndex = 12;
            traDeletebtn.Text = "Delete";
            traDeletebtn.UseVisualStyleBackColor = true;
            // 
            // traliSavebtn
            // 
            traliSavebtn.Location = new Point(0, 1288);
            traliSavebtn.Name = "traliSavebtn";
            traliSavebtn.Size = new Size(131, 40);
            traliSavebtn.TabIndex = 13;
            traliSavebtn.Text = "Save";
            traliSavebtn.UseVisualStyleBackColor = true;
            // 
            // traLnbtn
            // 
            traLnbtn.Location = new Point(140, 1288);
            traLnbtn.Name = "traLnbtn";
            traLnbtn.Size = new Size(131, 40);
            traLnbtn.TabIndex = 14;
            traLnbtn.Text = "Delete";
            traLnbtn.UseVisualStyleBackColor = true;
            // 
            // CashierControl
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(traLnbtn);
            Controls.Add(traliSavebtn);
            Controls.Add(traDeletebtn);
            Controls.Add(traSavebtn);
            Controls.Add(refreshbtm);
            Controls.Add(cusDelbtn);
            Controls.Add(customerSavebtn);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Name = "CashierControl";
            Size = new Size(2708, 1355);
            Load += CashierControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
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
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn surname;
        private DataGridViewTextBoxColumn cardNumber;
        private Button customerSavebtn;
        private Button cusDelbtn;
        private Button refreshbtm;
        private Button traSavebtn;
        private Button traDeletebtn;
        private Button traliSavebtn;
        private Button traLnbtn;
    }
}
