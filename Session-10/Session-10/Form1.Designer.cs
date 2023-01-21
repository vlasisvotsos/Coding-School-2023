namespace Session_10
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.registrationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.courseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 36);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(383, 131);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(Session_10.Course);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.studentIDDataGridViewTextBoxColumn,
            this.courseIDDataGridViewTextBoxColumn,
            this.gradesDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.gradeBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(641, 36);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 72;
            this.dataGridView2.RowTemplate.Height = 37;
            this.dataGridView2.Size = new System.Drawing.Size(476, 131);
            this.dataGridView2.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            // 
            // gradesDataGridViewTextBoxColumn
            // 
            this.gradesDataGridViewTextBoxColumn.DataPropertyName = "Grades";
            this.gradesDataGridViewTextBoxColumn.HeaderText = "Grades";
            this.gradesDataGridViewTextBoxColumn.Name = "gradesDataGridViewTextBoxColumn";
            // 
            // gradeBindingSource
            // 
            this.gradeBindingSource.DataSource = typeof(Session_10.Grade);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.courseIDDataGridViewTextBoxColumn1,
            this.professorIDDataGridViewTextBoxColumn,
            this.callenderDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.scheduleBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(11, 354);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 72;
            this.dataGridView3.RowTemplate.Height = 37;
            this.dataGridView3.Size = new System.Drawing.Size(476, 151);
            this.dataGridView3.TabIndex = 2;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            // 
            // courseIDDataGridViewTextBoxColumn1
            // 
            this.courseIDDataGridViewTextBoxColumn1.DataPropertyName = "CourseID";
            this.courseIDDataGridViewTextBoxColumn1.HeaderText = "CourseID";
            this.courseIDDataGridViewTextBoxColumn1.Name = "courseIDDataGridViewTextBoxColumn1";
            // 
            // professorIDDataGridViewTextBoxColumn
            // 
            this.professorIDDataGridViewTextBoxColumn.DataPropertyName = "ProfessorID";
            this.professorIDDataGridViewTextBoxColumn.HeaderText = "ProfessorID";
            this.professorIDDataGridViewTextBoxColumn.Name = "professorIDDataGridViewTextBoxColumn";
            // 
            // callenderDataGridViewTextBoxColumn
            // 
            this.callenderDataGridViewTextBoxColumn.DataPropertyName = "Callender";
            this.callenderDataGridViewTextBoxColumn.HeaderText = "Callender";
            this.callenderDataGridViewTextBoxColumn.Name = "callenderDataGridViewTextBoxColumn";
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataSource = typeof(Session_10.Schedule);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registrationNumberDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn3,
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.studentBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(641, 354);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 72;
            this.dataGridView4.RowTemplate.Height = 37;
            this.dataGridView4.Size = new System.Drawing.Size(475, 131);
            this.dataGridView4.TabIndex = 3;
            // 
            // registrationNumberDataGridViewTextBoxColumn
            // 
            this.registrationNumberDataGridViewTextBoxColumn.DataPropertyName = "RegistrationNumber";
            this.registrationNumberDataGridViewTextBoxColumn.HeaderText = "RegistrationNumber";
            this.registrationNumberDataGridViewTextBoxColumn.Name = "registrationNumberDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn3
            // 
            this.iDDataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn3.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn3.Name = "iDDataGridViewTextBoxColumn3";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Session_10.Student);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 598);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private BindingSource courseBindingSource;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gradesDataGridViewTextBoxColumn;
        private BindingSource gradeBindingSource;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn professorIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn callenderDataGridViewTextBoxColumn;
        private BindingSource scheduleBindingSource;
        private DataGridViewTextBoxColumn registrationNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private BindingSource studentBindingSource;
    }
}