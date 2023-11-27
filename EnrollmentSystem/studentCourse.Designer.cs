namespace EnrollmentSystem
{
    partial class studentCourse
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studCourseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dbmsDataSet24 = new EnrollmentSystem.dbmsDataSet24();
            this.dbmsDataSet22 = new EnrollmentSystem.dbmsDataSet22();
            this.studCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studCourseTableAdapter = new EnrollmentSystem.dbmsDataSet22TableAdapters.studCourseTableAdapter();
            this.dbmsDataSet23 = new EnrollmentSystem.dbmsDataSet23();
            this.studCourseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studCourseTableAdapter1 = new EnrollmentSystem.dbmsDataSet23TableAdapters.studCourseTableAdapter();
            this.studCourseTableAdapter2 = new EnrollmentSystem.dbmsDataSet24TableAdapters.studCourseTableAdapter();
            this.crsnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crsdescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearlevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studCourseBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studCourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studCourseBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(53, 49, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1153, 96);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(57, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "LIST OF COURSES";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(65, 103);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 385);
            this.panel1.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.crsnameDataGridViewTextBoxColumn,
            this.crsdescDataGridViewTextBoxColumn,
            this.yearlevelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studCourseBindingSource2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1034, 385);
            this.dataGridView1.TabIndex = 0;
            // 
            // studCourseBindingSource2
            // 
            this.studCourseBindingSource2.DataMember = "studCourse";
            this.studCourseBindingSource2.DataSource = this.dbmsDataSet24;
            // 
            // dbmsDataSet24
            // 
            this.dbmsDataSet24.DataSetName = "dbmsDataSet24";
            this.dbmsDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbmsDataSet22
            // 
            this.dbmsDataSet22.DataSetName = "dbmsDataSet22";
            this.dbmsDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studCourseBindingSource
            // 
            this.studCourseBindingSource.DataMember = "studCourse";
            this.studCourseBindingSource.DataSource = this.dbmsDataSet22;
            // 
            // studCourseTableAdapter
            // 
            this.studCourseTableAdapter.ClearBeforeFill = true;
            // 
            // dbmsDataSet23
            // 
            this.dbmsDataSet23.DataSetName = "dbmsDataSet23";
            this.dbmsDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studCourseBindingSource1
            // 
            this.studCourseBindingSource1.DataMember = "studCourse";
            this.studCourseBindingSource1.DataSource = this.dbmsDataSet23;
            // 
            // studCourseTableAdapter1
            // 
            this.studCourseTableAdapter1.ClearBeforeFill = true;
            // 
            // studCourseTableAdapter2
            // 
            this.studCourseTableAdapter2.ClearBeforeFill = true;
            // 
            // crsnameDataGridViewTextBoxColumn
            // 
            this.crsnameDataGridViewTextBoxColumn.DataPropertyName = "crs_name";
            this.crsnameDataGridViewTextBoxColumn.HeaderText = "Course name";
            this.crsnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.crsnameDataGridViewTextBoxColumn.Name = "crsnameDataGridViewTextBoxColumn";
            this.crsnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.crsnameDataGridViewTextBoxColumn.ToolTipText = "Course name";
            // 
            // crsdescDataGridViewTextBoxColumn
            // 
            this.crsdescDataGridViewTextBoxColumn.DataPropertyName = "crs_desc";
            this.crsdescDataGridViewTextBoxColumn.HeaderText = "Description";
            this.crsdescDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.crsdescDataGridViewTextBoxColumn.Name = "crsdescDataGridViewTextBoxColumn";
            this.crsdescDataGridViewTextBoxColumn.ReadOnly = true;
            this.crsdescDataGridViewTextBoxColumn.ToolTipText = "Description";
            // 
            // yearlevelDataGridViewTextBoxColumn
            // 
            this.yearlevelDataGridViewTextBoxColumn.DataPropertyName = "year_id";
            this.yearlevelDataGridViewTextBoxColumn.HeaderText = "Year level";
            this.yearlevelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearlevelDataGridViewTextBoxColumn.Name = "yearlevelDataGridViewTextBoxColumn";
            this.yearlevelDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearlevelDataGridViewTextBoxColumn.ToolTipText = "Year level";
            // 
            // studentCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(1153, 666);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "studentCourse";
            this.Text = "studentCourse";
            this.Load += new System.EventHandler(this.studentCourse_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studCourseBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studCourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studCourseBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studCourseBindingSource;
        private dbmsDataSet22 dbmsDataSet22;
        private dbmsDataSet22TableAdapters.studCourseTableAdapter studCourseTableAdapter;
        private System.Windows.Forms.BindingSource studCourseBindingSource1;
        private dbmsDataSet23 dbmsDataSet23;
        private dbmsDataSet23TableAdapters.studCourseTableAdapter studCourseTableAdapter1;
        private System.Windows.Forms.BindingSource studCourseBindingSource2;
        private dbmsDataSet24 dbmsDataSet24;
        private dbmsDataSet24TableAdapters.studCourseTableAdapter studCourseTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn crsnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crsdescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearlevelDataGridViewTextBoxColumn;
    }
}