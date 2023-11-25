namespace EnrollmentSystem
{
    partial class adminStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminStudent));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.delete = new System.Windows.Forms.PictureBox();
            this.add = new System.Windows.Forms.PictureBox();
            this.edit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.search = new System.Windows.Forms.PictureBox();
            this.searchTxtbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studfnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studlnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studmiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studbdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studgenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearlevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prognameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studgpaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showStudentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbmsDataSet17 = new EnrollmentSystem.dbmsDataSet17();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dbmsDataSet12 = new EnrollmentSystem.dbmsDataSet12();
            this.showStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showStudentTableAdapter = new EnrollmentSystem.dbmsDataSet12TableAdapters.showStudentTableAdapter();
            this.showStudentTableAdapter1 = new EnrollmentSystem.dbmsDataSet17TableAdapters.showStudentTableAdapter();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showStudentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet17)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showStudentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.delete);
            this.flowLayoutPanel2.Controls.Add(this.add);
            this.flowLayoutPanel2.Controls.Add(this.edit);
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 65);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 10, 40, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(865, 64);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // delete
            // 
            this.delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.Location = new System.Drawing.Point(790, 13);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(32, 35);
            this.delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.delete.TabIndex = 5;
            this.delete.TabStop = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            this.delete.MouseLeave += new System.EventHandler(this.delete_MouseLeave);
            this.delete.MouseHover += new System.EventHandler(this.delete_MouseHover);
            // 
            // add
            // 
            this.add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add.Image = ((System.Drawing.Image)(resources.GetObject("add.Image")));
            this.add.Location = new System.Drawing.Point(752, 13);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(32, 35);
            this.add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.add.TabIndex = 5;
            this.add.TabStop = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            this.add.MouseLeave += new System.EventHandler(this.add_MouseLeave);
            this.add.MouseHover += new System.EventHandler(this.add_MouseHover);
            // 
            // edit
            // 
            this.edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.Location = new System.Drawing.Point(711, 13);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(35, 35);
            this.edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.edit.TabIndex = 5;
            this.edit.TabStop = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            this.edit.MouseLeave += new System.EventHandler(this.edit_MouseLeave);
            this.edit.MouseHover += new System.EventHandler(this.edit_MouseHover);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.search);
            this.panel2.Controls.Add(this.searchTxtbox);
            this.panel2.Location = new System.Drawing.Point(296, 13);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.panel2.Size = new System.Drawing.Size(409, 35);
            this.panel2.TabIndex = 6;
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.Location = new System.Drawing.Point(386, 7);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(20, 20);
            this.search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.search.TabIndex = 5;
            this.search.TabStop = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            this.search.MouseLeave += new System.EventHandler(this.search_MouseLeave);
            this.search.MouseHover += new System.EventHandler(this.search_MouseHover);
            // 
            // searchTxtbox
            // 
            this.searchTxtbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxtbox.Location = new System.Drawing.Point(0, 4);
            this.searchTxtbox.Name = "searchTxtbox";
            this.searchTxtbox.Size = new System.Drawing.Size(409, 26);
            this.searchTxtbox.TabIndex = 3;
            this.searchTxtbox.TextChanged += new System.EventHandler(this.searchTxtbox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(49, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 348);
            this.panel1.TabIndex = 7;
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
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studidDataGridViewTextBoxColumn,
            this.studnoDataGridViewTextBoxColumn,
            this.studfnameDataGridViewTextBoxColumn,
            this.studlnameDataGridViewTextBoxColumn,
            this.studmiDataGridViewTextBoxColumn,
            this.studbdayDataGridViewTextBoxColumn,
            this.studaddressDataGridViewTextBoxColumn,
            this.studphoneDataGridViewTextBoxColumn,
            this.studemailDataGridViewTextBoxColumn,
            this.studgenderDataGridViewTextBoxColumn,
            this.yearlevelDataGridViewTextBoxColumn,
            this.prognameDataGridViewTextBoxColumn,
            this.studgpaDataGridViewTextBoxColumn,
            this.batchyearDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.showStudentBindingSource1;
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
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(772, 348);
            this.dataGridView1.TabIndex = 0;
            // 
            // studidDataGridViewTextBoxColumn
            // 
            this.studidDataGridViewTextBoxColumn.DataPropertyName = "stud_id";
            this.studidDataGridViewTextBoxColumn.HeaderText = "Student ID";
            this.studidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studidDataGridViewTextBoxColumn.Name = "studidDataGridViewTextBoxColumn";
            this.studidDataGridViewTextBoxColumn.ReadOnly = true;
            this.studidDataGridViewTextBoxColumn.ToolTipText = "Student ID";
            // 
            // studnoDataGridViewTextBoxColumn
            // 
            this.studnoDataGridViewTextBoxColumn.DataPropertyName = "stud_no";
            this.studnoDataGridViewTextBoxColumn.HeaderText = "Student no.";
            this.studnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studnoDataGridViewTextBoxColumn.Name = "studnoDataGridViewTextBoxColumn";
            this.studnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.studnoDataGridViewTextBoxColumn.ToolTipText = "Student no.";
            // 
            // studfnameDataGridViewTextBoxColumn
            // 
            this.studfnameDataGridViewTextBoxColumn.DataPropertyName = "stud_fname";
            this.studfnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.studfnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studfnameDataGridViewTextBoxColumn.Name = "studfnameDataGridViewTextBoxColumn";
            this.studfnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.studfnameDataGridViewTextBoxColumn.ToolTipText = "Firstname";
            // 
            // studlnameDataGridViewTextBoxColumn
            // 
            this.studlnameDataGridViewTextBoxColumn.DataPropertyName = "stud_lname";
            this.studlnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.studlnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studlnameDataGridViewTextBoxColumn.Name = "studlnameDataGridViewTextBoxColumn";
            this.studlnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.studlnameDataGridViewTextBoxColumn.ToolTipText = "Lastname";
            // 
            // studmiDataGridViewTextBoxColumn
            // 
            this.studmiDataGridViewTextBoxColumn.DataPropertyName = "stud_mi";
            this.studmiDataGridViewTextBoxColumn.HeaderText = "MI";
            this.studmiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studmiDataGridViewTextBoxColumn.Name = "studmiDataGridViewTextBoxColumn";
            this.studmiDataGridViewTextBoxColumn.ReadOnly = true;
            this.studmiDataGridViewTextBoxColumn.ToolTipText = "MI";
            // 
            // studbdayDataGridViewTextBoxColumn
            // 
            this.studbdayDataGridViewTextBoxColumn.DataPropertyName = "stud_bday";
            this.studbdayDataGridViewTextBoxColumn.HeaderText = "Birthdate";
            this.studbdayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studbdayDataGridViewTextBoxColumn.Name = "studbdayDataGridViewTextBoxColumn";
            this.studbdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.studbdayDataGridViewTextBoxColumn.ToolTipText = "Birthdate";
            // 
            // studaddressDataGridViewTextBoxColumn
            // 
            this.studaddressDataGridViewTextBoxColumn.DataPropertyName = "stud_address";
            this.studaddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.studaddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studaddressDataGridViewTextBoxColumn.Name = "studaddressDataGridViewTextBoxColumn";
            this.studaddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.studaddressDataGridViewTextBoxColumn.ToolTipText = "Address";
            // 
            // studphoneDataGridViewTextBoxColumn
            // 
            this.studphoneDataGridViewTextBoxColumn.DataPropertyName = "stud_phone";
            this.studphoneDataGridViewTextBoxColumn.HeaderText = "Phone no.";
            this.studphoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studphoneDataGridViewTextBoxColumn.Name = "studphoneDataGridViewTextBoxColumn";
            this.studphoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.studphoneDataGridViewTextBoxColumn.ToolTipText = "Phone no.";
            // 
            // studemailDataGridViewTextBoxColumn
            // 
            this.studemailDataGridViewTextBoxColumn.DataPropertyName = "stud_email";
            this.studemailDataGridViewTextBoxColumn.HeaderText = "Email address";
            this.studemailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studemailDataGridViewTextBoxColumn.Name = "studemailDataGridViewTextBoxColumn";
            this.studemailDataGridViewTextBoxColumn.ReadOnly = true;
            this.studemailDataGridViewTextBoxColumn.ToolTipText = "Email address";
            // 
            // studgenderDataGridViewTextBoxColumn
            // 
            this.studgenderDataGridViewTextBoxColumn.DataPropertyName = "stud_gender";
            this.studgenderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.studgenderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studgenderDataGridViewTextBoxColumn.Name = "studgenderDataGridViewTextBoxColumn";
            this.studgenderDataGridViewTextBoxColumn.ReadOnly = true;
            this.studgenderDataGridViewTextBoxColumn.ToolTipText = "Gender";
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
            // prognameDataGridViewTextBoxColumn
            // 
            this.prognameDataGridViewTextBoxColumn.DataPropertyName = "prog_name";
            this.prognameDataGridViewTextBoxColumn.HeaderText = "Program name";
            this.prognameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prognameDataGridViewTextBoxColumn.Name = "prognameDataGridViewTextBoxColumn";
            this.prognameDataGridViewTextBoxColumn.ReadOnly = true;
            this.prognameDataGridViewTextBoxColumn.ToolTipText = "Program name";
            // 
            // studgpaDataGridViewTextBoxColumn
            // 
            this.studgpaDataGridViewTextBoxColumn.DataPropertyName = "stud_gpa";
            this.studgpaDataGridViewTextBoxColumn.HeaderText = "GPA";
            this.studgpaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studgpaDataGridViewTextBoxColumn.Name = "studgpaDataGridViewTextBoxColumn";
            this.studgpaDataGridViewTextBoxColumn.ReadOnly = true;
            this.studgpaDataGridViewTextBoxColumn.ToolTipText = "GPA";
            // 
            // batchyearDataGridViewTextBoxColumn
            // 
            this.batchyearDataGridViewTextBoxColumn.DataPropertyName = "batch_year";
            this.batchyearDataGridViewTextBoxColumn.HeaderText = "Batch year";
            this.batchyearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.batchyearDataGridViewTextBoxColumn.Name = "batchyearDataGridViewTextBoxColumn";
            this.batchyearDataGridViewTextBoxColumn.ReadOnly = true;
            this.batchyearDataGridViewTextBoxColumn.ToolTipText = "Batch year";
            // 
            // showStudentBindingSource1
            // 
            this.showStudentBindingSource1.DataMember = "showStudent";
            this.showStudentBindingSource1.DataSource = this.dbmsDataSet17;
            // 
            // dbmsDataSet17
            // 
            this.dbmsDataSet17.DataSetName = "dbmsDataSet17";
            this.dbmsDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(40, 20, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(865, 59);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(43, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENTS INFORMATION";
            // 
            // dbmsDataSet12
            // 
            this.dbmsDataSet12.DataSetName = "dbmsDataSet12";
            this.dbmsDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showStudentBindingSource
            // 
            this.showStudentBindingSource.DataMember = "showStudent";
            this.showStudentBindingSource.DataSource = this.dbmsDataSet12;
            // 
            // showStudentTableAdapter
            // 
            this.showStudentTableAdapter.ClearBeforeFill = true;
            // 
            // showStudentTableAdapter1
            // 
            this.showStudentTableAdapter1.ClearBeforeFill = true;
            // 
            // adminStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(865, 541);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminStudent";
            this.Text = "adminStudent";
            this.Load += new System.EventHandler(this.adminStudent_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showStudentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet17)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showStudentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox delete;
        private System.Windows.Forms.PictureBox add;
        private System.Windows.Forms.PictureBox edit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox search;
        private System.Windows.Forms.TextBox searchTxtbox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource showStudentBindingSource;
        private dbmsDataSet12 dbmsDataSet12;
        private dbmsDataSet12TableAdapters.showStudentTableAdapter showStudentTableAdapter;
        private System.Windows.Forms.BindingSource showStudentBindingSource1;
        private dbmsDataSet17 dbmsDataSet17;
        private dbmsDataSet17TableAdapters.showStudentTableAdapter showStudentTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studfnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studlnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studmiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studbdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studgenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearlevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prognameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studgpaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchyearDataGridViewTextBoxColumn;
    }
}