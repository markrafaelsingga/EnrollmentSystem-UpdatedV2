namespace EnrollmentSystem
{
    partial class studentClass
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.classsectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classfromTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classtoTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crsnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearlevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studClassBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbmsDataSet25 = new EnrollmentSystem.dbmsDataSet25();
            this.studClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbmsDataSet16 = new EnrollmentSystem.dbmsDataSet16();
            this.studClassTableAdapter = new EnrollmentSystem.dbmsDataSet16TableAdapters.studClassTableAdapter();
            this.studClassTableAdapter1 = new EnrollmentSystem.dbmsDataSet25TableAdapters.studClassTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studClassBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet16)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(65, 106);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 444);
            this.panel1.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(131)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classsectionDataGridViewTextBoxColumn,
            this.classfromTimeDataGridViewTextBoxColumn,
            this.classtoTimeDataGridViewTextBoxColumn,
            this.classdayDataGridViewTextBoxColumn,
            this.crsnameDataGridViewTextBoxColumn,
            this.instructornameDataGridViewTextBoxColumn,
            this.roomnameDataGridViewTextBoxColumn,
            this.yearlevelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studClassBindingSource1;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(980, 444);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // classsectionDataGridViewTextBoxColumn
            // 
            this.classsectionDataGridViewTextBoxColumn.DataPropertyName = "class_section";
            this.classsectionDataGridViewTextBoxColumn.HeaderText = "Class section";
            this.classsectionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.classsectionDataGridViewTextBoxColumn.Name = "classsectionDataGridViewTextBoxColumn";
            this.classsectionDataGridViewTextBoxColumn.ReadOnly = true;
            this.classsectionDataGridViewTextBoxColumn.ToolTipText = "Class section";
            // 
            // classfromTimeDataGridViewTextBoxColumn
            // 
            this.classfromTimeDataGridViewTextBoxColumn.DataPropertyName = "class_fromTime";
            this.classfromTimeDataGridViewTextBoxColumn.HeaderText = "Class start";
            this.classfromTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.classfromTimeDataGridViewTextBoxColumn.Name = "classfromTimeDataGridViewTextBoxColumn";
            this.classfromTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.classfromTimeDataGridViewTextBoxColumn.ToolTipText = "Class start";
            // 
            // classtoTimeDataGridViewTextBoxColumn
            // 
            this.classtoTimeDataGridViewTextBoxColumn.DataPropertyName = "class_toTime";
            this.classtoTimeDataGridViewTextBoxColumn.HeaderText = "Class end";
            this.classtoTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.classtoTimeDataGridViewTextBoxColumn.Name = "classtoTimeDataGridViewTextBoxColumn";
            this.classtoTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.classtoTimeDataGridViewTextBoxColumn.ToolTipText = "Class end";
            // 
            // classdayDataGridViewTextBoxColumn
            // 
            this.classdayDataGridViewTextBoxColumn.DataPropertyName = "class_day";
            this.classdayDataGridViewTextBoxColumn.HeaderText = "Class day";
            this.classdayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.classdayDataGridViewTextBoxColumn.Name = "classdayDataGridViewTextBoxColumn";
            this.classdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.classdayDataGridViewTextBoxColumn.ToolTipText = "Class day";
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
            // instructornameDataGridViewTextBoxColumn
            // 
            this.instructornameDataGridViewTextBoxColumn.DataPropertyName = "instructor_name";
            this.instructornameDataGridViewTextBoxColumn.HeaderText = "Instructor name";
            this.instructornameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.instructornameDataGridViewTextBoxColumn.Name = "instructornameDataGridViewTextBoxColumn";
            this.instructornameDataGridViewTextBoxColumn.ReadOnly = true;
            this.instructornameDataGridViewTextBoxColumn.ToolTipText = "Instructor name";
            // 
            // roomnameDataGridViewTextBoxColumn
            // 
            this.roomnameDataGridViewTextBoxColumn.DataPropertyName = "room_name";
            this.roomnameDataGridViewTextBoxColumn.HeaderText = "Room name";
            this.roomnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomnameDataGridViewTextBoxColumn.Name = "roomnameDataGridViewTextBoxColumn";
            this.roomnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomnameDataGridViewTextBoxColumn.ToolTipText = "Room name";
            // 
            // yearlevelDataGridViewTextBoxColumn
            // 
            this.yearlevelDataGridViewTextBoxColumn.DataPropertyName = "year_level";
            this.yearlevelDataGridViewTextBoxColumn.HeaderText = "Year level";
            this.yearlevelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearlevelDataGridViewTextBoxColumn.Name = "yearlevelDataGridViewTextBoxColumn";
            this.yearlevelDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearlevelDataGridViewTextBoxColumn.ToolTipText = "Year level";
            // 
            // studClassBindingSource1
            // 
            this.studClassBindingSource1.DataMember = "studClass";
            this.studClassBindingSource1.DataSource = this.dbmsDataSet25;
            // 
            // dbmsDataSet25
            // 
            this.dbmsDataSet25.DataSetName = "dbmsDataSet25";
            this.dbmsDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studClassBindingSource
            // 
            this.studClassBindingSource.DataMember = "studClass";
            this.studClassBindingSource.DataSource = this.dbmsDataSet16;
            // 
            // dbmsDataSet16
            // 
            this.dbmsDataSet16.DataSetName = "dbmsDataSet16";
            this.dbmsDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studClassTableAdapter
            // 
            this.studClassTableAdapter.ClearBeforeFill = true;
            // 
            // studClassTableAdapter1
            // 
            this.studClassTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(57, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "MY CLASSES";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(53, 49, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1099, 98);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // studentClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(1099, 709);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "studentClass";
            this.Text = "studentClass";
            this.Load += new System.EventHandler(this.studentClass_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studClassBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet16)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studClassBindingSource;
        private dbmsDataSet16 dbmsDataSet16;
        private dbmsDataSet16TableAdapters.studClassTableAdapter studClassTableAdapter;
        private System.Windows.Forms.BindingSource studClassBindingSource1;
        private dbmsDataSet25 dbmsDataSet25;
        private dbmsDataSet25TableAdapters.studClassTableAdapter studClassTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn classsectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classfromTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classtoTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crsnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearlevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}