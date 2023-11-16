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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dbmsDataSet16 = new EnrollmentSystem.dbmsDataSet16();
            this.studClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studClassTableAdapter = new EnrollmentSystem.dbmsDataSet16TableAdapters.studClassTableAdapter();
            this.classsectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classfromTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classtoTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crsnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearlevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studClassBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(49, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 361);
            this.panel1.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(131)))), ((int)(((byte)(179)))));
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
            this.dataGridView1.DataSource = this.studClassBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(735, 361);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(40, 40, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(824, 80);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(43, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "MY CLASSES";
            // 
            // dbmsDataSet16
            // 
            this.dbmsDataSet16.DataSetName = "dbmsDataSet16";
            this.dbmsDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studClassBindingSource
            // 
            this.studClassBindingSource.DataMember = "studClass";
            this.studClassBindingSource.DataSource = this.dbmsDataSet16;
            // 
            // studClassTableAdapter
            // 
            this.studClassTableAdapter.ClearBeforeFill = true;
            // 
            // classsectionDataGridViewTextBoxColumn
            // 
            this.classsectionDataGridViewTextBoxColumn.DataPropertyName = "class_section";
            this.classsectionDataGridViewTextBoxColumn.HeaderText = "class_section";
            this.classsectionDataGridViewTextBoxColumn.Name = "classsectionDataGridViewTextBoxColumn";
            this.classsectionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classfromTimeDataGridViewTextBoxColumn
            // 
            this.classfromTimeDataGridViewTextBoxColumn.DataPropertyName = "class_fromTime";
            this.classfromTimeDataGridViewTextBoxColumn.HeaderText = "class_fromTime";
            this.classfromTimeDataGridViewTextBoxColumn.Name = "classfromTimeDataGridViewTextBoxColumn";
            this.classfromTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classtoTimeDataGridViewTextBoxColumn
            // 
            this.classtoTimeDataGridViewTextBoxColumn.DataPropertyName = "class_toTime";
            this.classtoTimeDataGridViewTextBoxColumn.HeaderText = "class_toTime";
            this.classtoTimeDataGridViewTextBoxColumn.Name = "classtoTimeDataGridViewTextBoxColumn";
            this.classtoTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classdayDataGridViewTextBoxColumn
            // 
            this.classdayDataGridViewTextBoxColumn.DataPropertyName = "class_day";
            this.classdayDataGridViewTextBoxColumn.HeaderText = "class_day";
            this.classdayDataGridViewTextBoxColumn.Name = "classdayDataGridViewTextBoxColumn";
            this.classdayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // crsnameDataGridViewTextBoxColumn
            // 
            this.crsnameDataGridViewTextBoxColumn.DataPropertyName = "crs_name";
            this.crsnameDataGridViewTextBoxColumn.HeaderText = "crs_name";
            this.crsnameDataGridViewTextBoxColumn.Name = "crsnameDataGridViewTextBoxColumn";
            this.crsnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // instructornameDataGridViewTextBoxColumn
            // 
            this.instructornameDataGridViewTextBoxColumn.DataPropertyName = "instructor_name";
            this.instructornameDataGridViewTextBoxColumn.HeaderText = "instructor_name";
            this.instructornameDataGridViewTextBoxColumn.Name = "instructornameDataGridViewTextBoxColumn";
            this.instructornameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomnameDataGridViewTextBoxColumn
            // 
            this.roomnameDataGridViewTextBoxColumn.DataPropertyName = "room_name";
            this.roomnameDataGridViewTextBoxColumn.HeaderText = "room_name";
            this.roomnameDataGridViewTextBoxColumn.Name = "roomnameDataGridViewTextBoxColumn";
            this.roomnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearlevelDataGridViewTextBoxColumn
            // 
            this.yearlevelDataGridViewTextBoxColumn.DataPropertyName = "year_level";
            this.yearlevelDataGridViewTextBoxColumn.HeaderText = "year_level";
            this.yearlevelDataGridViewTextBoxColumn.Name = "yearlevelDataGridViewTextBoxColumn";
            this.yearlevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 576);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "studentClass";
            this.Text = "studentClass";
            this.Load += new System.EventHandler(this.studentClass_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studClassBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn classsectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classfromTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classtoTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crsnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearlevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studClassBindingSource;
        private dbmsDataSet16 dbmsDataSet16;
        private dbmsDataSet16TableAdapters.studClassTableAdapter studClassTableAdapter;
    }
}