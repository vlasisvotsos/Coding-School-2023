namespace WinForms.UserControlls
{
    partial class ManagerControl
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            surname = new DataGridViewTextBoxColumn();
            cardNumber = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            code = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            itemType = new DataGridViewComboBoxColumn();
            price = new DataGridViewTextBoxColumn();
            cost = new DataGridViewTextBoxColumn();
            dataGridView3 = new DataGridView();
            date = new DataGridViewTextBoxColumn();
            employeeID = new DataGridViewTextBoxColumn();
            customerID = new DataGridViewTextBoxColumn();
            paymentMethod = new DataGridViewComboBoxColumn();
            totalValue = new DataGridViewTextBoxColumn();
            dataGridView4 = new DataGridView();
            transactionID = new DataGridViewTextBoxColumn();
            itemID = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            itemPrice = new DataGridViewTextBoxColumn();
            netValue = new DataGridViewTextBoxColumn();
            discountPercent = new DataGridViewTextBoxColumn();
            discountValue = new DataGridViewTextBoxColumn();
            totalPrice = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 30);
            label1.TabIndex = 0;
            label1.Text = "Manager Tab";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 30);
            label2.Name = "label2";
            label2.Size = new Size(111, 30);
            label2.TabIndex = 1;
            label2.Text = "Customers";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(1512, 30);
            label3.Name = "label3";
            label3.Size = new Size(64, 30);
            label3.TabIndex = 2;
            label3.Text = "Items";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(0, 916);
            label4.Name = "label4";
            label4.Size = new Size(127, 30);
            label4.TabIndex = 3;
            label4.Text = "Transactions";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(1512, 916);
            label5.Name = "label5";
            label5.Size = new Size(171, 30);
            label5.TabIndex = 4;
            label5.Text = "Transaction Lines";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { name, surname, cardNumber });
            dataGridView1.Location = new Point(3, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.Size = new Size(1115, 365);
            dataGridView1.TabIndex = 5;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.HeaderText = "Name:";
            name.MinimumWidth = 9;
            name.Name = "name";
            // 
            // surname
            // 
            surname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            surname.HeaderText = "Surname:";
            surname.MinimumWidth = 9;
            surname.Name = "surname";
            // 
            // cardNumber
            // 
            cardNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cardNumber.HeaderText = "CardNumber:";
            cardNumber.MinimumWidth = 9;
            cardNumber.Name = "cardNumber";
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { code, description, itemType, price, cost });
            dataGridView2.Location = new Point(1512, 63);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 72;
            dataGridView2.RowTemplate.Height = 37;
            dataGridView2.Size = new Size(1113, 365);
            dataGridView2.TabIndex = 6;
            // 
            // code
            // 
            code.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            code.HeaderText = "Code:";
            code.MinimumWidth = 9;
            code.Name = "code";
            // 
            // description
            // 
            description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            description.HeaderText = "Description:";
            description.MinimumWidth = 9;
            description.Name = "description";
            // 
            // itemType
            // 
            itemType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemType.HeaderText = "Item Type:";
            itemType.MinimumWidth = 9;
            itemType.Name = "itemType";
            // 
            // price
            // 
            price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            price.HeaderText = "Price:";
            price.MinimumWidth = 9;
            price.Name = "price";
            // 
            // cost
            // 
            cost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cost.HeaderText = "Cost:";
            cost.MinimumWidth = 9;
            cost.Name = "cost";
            // 
            // dataGridView3
            // 
            dataGridView3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { date, employeeID, customerID, paymentMethod, totalValue });
            dataGridView3.Location = new Point(0, 949);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 72;
            dataGridView3.RowTemplate.Height = 37;
            dataGridView3.Size = new Size(1115, 353);
            dataGridView3.TabIndex = 7;
            // 
            // date
            // 
            date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            date.HeaderText = "Date:";
            date.MinimumWidth = 9;
            date.Name = "date";
            // 
            // employeeID
            // 
            employeeID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            employeeID.HeaderText = "employeeID";
            employeeID.MinimumWidth = 9;
            employeeID.Name = "employeeID";
            // 
            // customerID
            // 
            customerID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customerID.HeaderText = "Customer ID:";
            customerID.MinimumWidth = 9;
            customerID.Name = "customerID";
            // 
            // paymentMethod
            // 
            paymentMethod.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            paymentMethod.HeaderText = "PaymentMethod:";
            paymentMethod.MinimumWidth = 9;
            paymentMethod.Name = "paymentMethod";
            // 
            // totalValue
            // 
            totalValue.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            totalValue.HeaderText = "Total Value:";
            totalValue.MinimumWidth = 9;
            totalValue.Name = "totalValue";
            // 
            // dataGridView4
            // 
            dataGridView4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { transactionID, itemID, quantity, itemPrice, netValue, discountPercent, discountValue, totalPrice });
            dataGridView4.Location = new Point(1512, 946);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 72;
            dataGridView4.RowTemplate.Height = 37;
            dataGridView4.Size = new Size(1116, 356);
            dataGridView4.TabIndex = 8;
            // 
            // transactionID
            // 
            transactionID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            transactionID.HeaderText = "TransactionID:";
            transactionID.MinimumWidth = 9;
            transactionID.Name = "transactionID";
            // 
            // itemID
            // 
            itemID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemID.HeaderText = "Item ID:";
            itemID.MinimumWidth = 9;
            itemID.Name = "itemID";
            // 
            // quantity
            // 
            quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            quantity.HeaderText = "Quantity:";
            quantity.MinimumWidth = 9;
            quantity.Name = "quantity";
            // 
            // itemPrice
            // 
            itemPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemPrice.HeaderText = "Item Price:";
            itemPrice.MinimumWidth = 9;
            itemPrice.Name = "itemPrice";
            // 
            // netValue
            // 
            netValue.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            netValue.HeaderText = "Net Value:";
            netValue.MinimumWidth = 9;
            netValue.Name = "netValue";
            // 
            // discountPercent
            // 
            discountPercent.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            discountPercent.HeaderText = "Discount Percent:";
            discountPercent.MinimumWidth = 9;
            discountPercent.Name = "discountPercent";
            // 
            // discountValue
            // 
            discountValue.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            discountValue.HeaderText = "Discount Value:";
            discountValue.MinimumWidth = 9;
            discountValue.Name = "discountValue";
            // 
            // totalPrice
            // 
            totalPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            totalPrice.HeaderText = "Total Price:";
            totalPrice.MinimumWidth = 9;
            totalPrice.Name = "totalPrice";
            // 
            // ManagerControl
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView4);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ManagerControl";
            Size = new Size(2628, 1302);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn surname;
        private DataGridViewTextBoxColumn cardNumber;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn code;
        private DataGridViewTextBoxColumn description;
        private DataGridViewComboBoxColumn itemType;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn cost;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn employeeID;
        private DataGridViewTextBoxColumn customerID;
        private DataGridViewComboBoxColumn paymentMethod;
        private DataGridViewTextBoxColumn totalValue;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn transactionID;
        private DataGridViewTextBoxColumn itemID;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn itemPrice;
        private DataGridViewTextBoxColumn netValue;
        private DataGridViewTextBoxColumn discountPercent;
        private DataGridViewTextBoxColumn discountValue;
        private DataGridViewTextBoxColumn totalPrice;
    }
}
