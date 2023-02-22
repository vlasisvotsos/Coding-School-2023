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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Homebtn = new System.Windows.Forms.Button();
            this.Staffbtn = new System.Windows.Forms.Button();
            this.Cashierbtn = new System.Windows.Forms.Button();
            this.Managerbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 1252);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Homebtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Staffbtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Cashierbtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Managerbtn, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(369, 692);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Homebtn
            // 
            this.Homebtn.Location = new System.Drawing.Point(3, 3);
            this.Homebtn.Name = "Homebtn";
            this.Homebtn.Size = new System.Drawing.Size(363, 167);
            this.Homebtn.TabIndex = 0;
            this.Homebtn.Text = "Home";
            this.Homebtn.UseVisualStyleBackColor = true;
            this.Homebtn.Click += new System.EventHandler(this.Homebtn_Click);
            // 
            // Staffbtn
            // 
            this.Staffbtn.Location = new System.Drawing.Point(3, 176);
            this.Staffbtn.Name = "Staffbtn";
            this.Staffbtn.Size = new System.Drawing.Size(363, 167);
            this.Staffbtn.TabIndex = 1;
            this.Staffbtn.Text = "Staff";
            this.Staffbtn.UseVisualStyleBackColor = true;
            this.Staffbtn.Click += new System.EventHandler(this.Staffbtn_Click);
            // 
            // Cashierbtn
            // 
            this.Cashierbtn.Location = new System.Drawing.Point(3, 349);
            this.Cashierbtn.Name = "Cashierbtn";
            this.Cashierbtn.Size = new System.Drawing.Size(363, 167);
            this.Cashierbtn.TabIndex = 2;
            this.Cashierbtn.Text = "Cashier";
            this.Cashierbtn.UseVisualStyleBackColor = true;
            this.Cashierbtn.Click += new System.EventHandler(this.Cashierbtn_Click);
            // 
            // Managerbtn
            // 
            this.Managerbtn.Location = new System.Drawing.Point(3, 522);
            this.Managerbtn.Name = "Managerbtn";
            this.Managerbtn.Size = new System.Drawing.Size(363, 167);
            this.Managerbtn.TabIndex = 3;
            this.Managerbtn.Text = "Manager";
            this.Managerbtn.UseVisualStyleBackColor = true;
            this.Managerbtn.Click += new System.EventHandler(this.Managerbtn_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(2306, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 1252);
            this.panel2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2656, 1252);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

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