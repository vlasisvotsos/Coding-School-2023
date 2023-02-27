namespace WinForms.UserControlls
{
    partial class StaffControl
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
            dataGridView1 = new DataGridView();
            Code = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            ItemType = new DataGridViewComboBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Cost = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 30);
            label1.TabIndex = 0;
            label1.Text = "Staff Tab";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(264, 209);
            label2.Name = "label2";
            label2.Size = new Size(64, 30);
            label2.TabIndex = 1;
            label2.Text = "Items";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Code, Description, ItemType, Price, Cost });
            dataGridView1.Location = new Point(264, 242);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.Size = new Size(2065, 823);
            dataGridView1.TabIndex = 2;
            // 
            // Code
            // 
            Code.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Code.HeaderText = "Code:";
            Code.MinimumWidth = 9;
            Code.Name = "Code";
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Description.HeaderText = "Description:";
            Description.MinimumWidth = 9;
            Description.Name = "Description";
            // 
            // ItemType
            // 
            ItemType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ItemType.HeaderText = "Item Type:";
            ItemType.MinimumWidth = 9;
            ItemType.Name = "ItemType";
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Price.HeaderText = "Price:";
            Price.MinimumWidth = 9;
            Price.Name = "Price";
            Price.Resizable = DataGridViewTriState.True;
            Price.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Cost
            // 
            Cost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Cost.HeaderText = "Cost:";
            Cost.MinimumWidth = 9;
            Cost.Name = "Cost";
            Cost.Resizable = DataGridViewTriState.True;
            Cost.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // button1
            // 
            button1.Location = new Point(550, 140);
            button1.Name = "button1";
            button1.Size = new Size(131, 40);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // StaffControl
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StaffControl";
            Size = new Size(2578, 1310);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewComboBoxColumn ItemType;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Cost;
        private Button button1;
    }
}
