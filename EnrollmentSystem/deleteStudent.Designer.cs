namespace EnrollmentSystem
{
    partial class deleteStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deleteStudent));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbmsDataSet18 = new EnrollmentSystem.dbmsDataSet18();
            this.panel2 = new System.Windows.Forms.Panel();
            this.search = new System.Windows.Forms.PictureBox();
            this.searchTxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.showStudentTableAdapter = new EnrollmentSystem.dbmsDataSet18TableAdapters.showStudentTableAdapter();
            this.dbmsDataSet19 = new EnrollmentSystem.dbmsDataSet19();
            this.showStudentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.showStudentTableAdapter1 = new EnrollmentSystem.dbmsDataSet19TableAdapters.showStudentTableAdapter();
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
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet18)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showStudentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 334);
            this.panel1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(21, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(511, 252);
            this.panel3.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(131)))), ((int)(((byte)(179)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(511, 252);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // showStudentBindingSource
            // 
            this.showStudentBindingSource.DataMember = "showStudent";
            this.showStudentBindingSource.DataSource = this.dbmsDataSet18;
            // 
            // dbmsDataSet18
            // 
            this.dbmsDataSet18.DataSetName = "dbmsDataSet18";
            this.dbmsDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.search);
            this.panel2.Controls.Add(this.searchTxtbox);
            this.panel2.Location = new System.Drawing.Point(193, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 25);
            this.panel2.TabIndex = 11;
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search.BackColor = System.Drawing.Color.White;
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.Location = new System.Drawing.Point(187, 3);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(19, 19);
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
            this.searchTxtbox.Location = new System.Drawing.Point(0, 0);
            this.searchTxtbox.Multiline = true;
            this.searchTxtbox.Name = "searchTxtbox";
            this.searchTxtbox.Size = new System.Drawing.Size(210, 25);
            this.searchTxtbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search the ID number:";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBtn.Location = new System.Drawing.Point(456, 372);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(129, 40);
            this.deleteBtn.TabIndex = 11;
            this.deleteBtn.Text = "       DELETE";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            this.deleteBtn.MouseLeave += new System.EventHandler(this.deleteBtn_MouseLeave);
            this.deleteBtn.MouseHover += new System.EventHandler(this.deleteBtn_MouseHover);
            // 
            // showStudentTableAdapter
            // 
            this.showStudentTableAdapter.ClearBeforeFill = true;
            // 
            // dbmsDataSet19
            // 
            this.dbmsDataSet19.DataSetName = "dbmsDataSet19";
            this.dbmsDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showStudentBindingSource1
            // 
            this.showStudentBindingSource1.DataMember = "showStudent";
            this.showStudentBindingSource1.DataSource = this.dbmsDataSet19;
            // 
            // showStudentTableAdapter1
            // 
            this.showStudentTableAdapter1.ClearBeforeFill = true;
            // 
            // studidDataGridViewTextBoxColumn
            // 
            this.studidDataGridViewTextBoxColumn.DataPropertyName = "stud_id";
            this.studidDataGridViewTextBoxColumn.HeaderText = "stud_id";
            this.studidDataGridViewTextBoxColumn.Name = "studidDataGridViewTextBoxColumn";
            this.studidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studnoDataGridViewTextBoxColumn
            // 
            this.studnoDataGridViewTextBoxColumn.DataPropertyName = "stud_no";
            this.studnoDataGridViewTextBoxColumn.HeaderText = "stud_no";
            this.studnoDataGridViewTextBoxColumn.Name = "studnoDataGridViewTextBoxColumn";
            this.studnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studfnameDataGridViewTextBoxColumn
            // 
            this.studfnameDataGridViewTextBoxColumn.DataPropertyName = "stud_fname";
            this.studfnameDataGridViewTextBoxColumn.HeaderText = "stud_fname";
            this.studfnameDataGridViewTextBoxColumn.Name = "studfnameDataGridViewTextBoxColumn";
            this.studfnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studlnameDataGridViewTextBoxColumn
            // 
            this.studlnameDataGridViewTextBoxColumn.DataPropertyName = "stud_lname";
            this.studlnameDataGridViewTextBoxColumn.HeaderText = "stud_lname";
            this.studlnameDataGridViewTextBoxColumn.Name = "studlnameDataGridViewTextBoxColumn";
            this.studlnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studmiDataGridViewTextBoxColumn
            // 
            this.studmiDataGridViewTextBoxColumn.DataPropertyName = "stud_mi";
            this.studmiDataGridViewTextBoxColumn.HeaderText = "stud_mi";
            this.studmiDataGridViewTextBoxColumn.Name = "studmiDataGridViewTextBoxColumn";
            this.studmiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studbdayDataGridViewTextBoxColumn
            // 
            this.studbdayDataGridViewTextBoxColumn.DataPropertyName = "stud_bday";
            this.studbdayDataGridViewTextBoxColumn.HeaderText = "stud_bday";
            this.studbdayDataGridViewTextBoxColumn.Name = "studbdayDataGridViewTextBoxColumn";
            this.studbdayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studaddressDataGridViewTextBoxColumn
            // 
            this.studaddressDataGridViewTextBoxColumn.DataPropertyName = "stud_address";
            this.studaddressDataGridViewTextBoxColumn.HeaderText = "stud_address";
            this.studaddressDataGridViewTextBoxColumn.Name = "studaddressDataGridViewTextBoxColumn";
            this.studaddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studphoneDataGridViewTextBoxColumn
            // 
            this.studphoneDataGridViewTextBoxColumn.DataPropertyName = "stud_phone";
            this.studphoneDataGridViewTextBoxColumn.HeaderText = "stud_phone";
            this.studphoneDataGridViewTextBoxColumn.Name = "studphoneDataGridViewTextBoxColumn";
            this.studphoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studemailDataGridViewTextBoxColumn
            // 
            this.studemailDataGridViewTextBoxColumn.DataPropertyName = "stud_email";
            this.studemailDataGridViewTextBoxColumn.HeaderText = "stud_email";
            this.studemailDataGridViewTextBoxColumn.Name = "studemailDataGridViewTextBoxColumn";
            this.studemailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studgenderDataGridViewTextBoxColumn
            // 
            this.studgenderDataGridViewTextBoxColumn.DataPropertyName = "stud_gender";
            this.studgenderDataGridViewTextBoxColumn.HeaderText = "stud_gender";
            this.studgenderDataGridViewTextBoxColumn.Name = "studgenderDataGridViewTextBoxColumn";
            this.studgenderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearlevelDataGridViewTextBoxColumn
            // 
            this.yearlevelDataGridViewTextBoxColumn.DataPropertyName = "year_level";
            this.yearlevelDataGridViewTextBoxColumn.HeaderText = "year_level";
            this.yearlevelDataGridViewTextBoxColumn.Name = "yearlevelDataGridViewTextBoxColumn";
            this.yearlevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prognameDataGridViewTextBoxColumn
            // 
            this.prognameDataGridViewTextBoxColumn.DataPropertyName = "prog_name";
            this.prognameDataGridViewTextBoxColumn.HeaderText = "prog_name";
            this.prognameDataGridViewTextBoxColumn.Name = "prognameDataGridViewTextBoxColumn";
            this.prognameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studgpaDataGridViewTextBoxColumn
            // 
            this.studgpaDataGridViewTextBoxColumn.DataPropertyName = "stud_gpa";
            this.studgpaDataGridViewTextBoxColumn.HeaderText = "stud_gpa";
            this.studgpaDataGridViewTextBoxColumn.Name = "studgpaDataGridViewTextBoxColumn";
            this.studgpaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // batchyearDataGridViewTextBoxColumn
            // 
            this.batchyearDataGridViewTextBoxColumn.DataPropertyName = "batch_year";
            this.batchyearDataGridViewTextBoxColumn.HeaderText = "batch_year";
            this.batchyearDataGridViewTextBoxColumn.Name = "batchyearDataGridViewTextBoxColumn";
            this.batchyearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(18)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(612, 420);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "deleteStudent";
            this.Text = "DELETE STUDENT INFORMATION";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet18)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showStudentBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox search;
        private System.Windows.Forms.TextBox searchTxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.BindingSource showStudentBindingSource;
        private dbmsDataSet18 dbmsDataSet18;
        private dbmsDataSet18TableAdapters.showStudentTableAdapter showStudentTableAdapter;
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
        private System.Windows.Forms.BindingSource showStudentBindingSource1;
        private dbmsDataSet19 dbmsDataSet19;
        private dbmsDataSet19TableAdapters.showStudentTableAdapter showStudentTableAdapter1;
    }
}