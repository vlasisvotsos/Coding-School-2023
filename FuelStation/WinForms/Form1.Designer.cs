namespace WinForms
{
    partial class Form1
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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            Homebtn = new Button();
            Staffbtn = new Button();
            Cashierbtn = new Button();
            Managerbtn = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(369, 1252);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(Homebtn, 0, 0);
            tableLayoutPanel1.Controls.Add(Staffbtn, 0, 1);
            tableLayoutPanel1.Controls.Add(Cashierbtn, 0, 2);
            tableLayoutPanel1.Controls.Add(Managerbtn, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(369, 692);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Homebtn
            // 
            Homebtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Homebtn.Location = new Point(3, 3);
            Homebtn.Name = "Homebtn";
            Homebtn.Size = new Size(363, 167);
            Homebtn.TabIndex = 0;
            Homebtn.Text = "Home";
            Homebtn.UseVisualStyleBackColor = true;
            Homebtn.Click += Homebtn_Click;
            // 
            // Staffbtn
            // 
            Staffbtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Staffbtn.Location = new Point(3, 176);
            Staffbtn.Name = "Staffbtn";
            Staffbtn.Size = new Size(363, 167);
            Staffbtn.TabIndex = 1;
            Staffbtn.Text = "Staff";
            Staffbtn.UseVisualStyleBackColor = true;
            Staffbtn.Click += Staffbtn_Click;
            // 
            // Cashierbtn
            // 
            Cashierbtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Cashierbtn.Location = new Point(3, 349);
            Cashierbtn.Name = "Cashierbtn";
            Cashierbtn.Size = new Size(363, 167);
            Cashierbtn.TabIndex = 2;
            Cashierbtn.Text = "Cashier";
            Cashierbtn.UseVisualStyleBackColor = true;
            Cashierbtn.Click += Cashierbtn_Click;
            // 
            // Managerbtn
            // 
            Managerbtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Managerbtn.Location = new Point(3, 522);
            Managerbtn.Name = "Managerbtn";
            Managerbtn.Size = new Size(363, 167);
            Managerbtn.TabIndex = 3;
            Managerbtn.Text = "Manager";
            Managerbtn.UseVisualStyleBackColor = true;
            Managerbtn.Click += Managerbtn_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(372, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(2284, 1252);
            panel2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2656, 1252);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button Homebtn;
        private Button Staffbtn;
        private Button Cashierbtn;
        private Button Managerbtn;
        private Panel panel2;
    }
}