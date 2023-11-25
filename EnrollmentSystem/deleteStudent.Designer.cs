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
            this.dbmsDataSet19 = new EnrollmentSystem.dbmsDataSet19();
            this.panel2 = new System.Windows.Forms.Panel();
            this.search = new System.Windows.Forms.PictureBox();
            this.searchTxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbmsDataSet18 = new EnrollmentSystem.dbmsDataSet18();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.showStudentTableAdapter = new EnrollmentSystem.dbmsDataSet18TableAdapters.showStudentTableAdapter();
            this.showStudentTableAdapter1 = new EnrollmentSystem.dbmsDataSet19TableAdapters.showStudentTableAdapter();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showStudentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet19)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet18)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(33, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 411);
            this.panel1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(28, 68);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(681, 310);
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
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(681, 310);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // studidDataGridViewTextBoxColumn
            // 
            this.studidDataGridViewTextBoxColumn.DataPropertyName = "stud_id";
            this.studidDataGridViewTextBoxColumn.HeaderText = "stud_id";
            this.studidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studidDataGridViewTextBoxColumn.Name = "studidDataGridViewTextBoxColumn";
            this.studidDataGridViewTextBoxColumn.ReadOnly = true;
            this.studidDataGridViewTextBoxColumn.Width = 125;
            // 
            // studnoDataGridViewTextBoxColumn
            // 
            this.studnoDataGridViewTextBoxColumn.DataPropertyName = "stud_no";
            this.studnoDataGridViewTextBoxColumn.HeaderText = "stud_no";
            this.studnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studnoDataGridViewTextBoxColumn.Name = "studnoDataGridViewTextBoxColumn";
            this.studnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.studnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // studfnameDataGridViewTextBoxColumn
            // 
            this.studfnameDataGridViewTextBoxColumn.DataPropertyName = "stud_fname";
            this.studfnameDataGridViewTextBoxColumn.HeaderText = "stud_fname";
            this.studfnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studfnameDataGridViewTextBoxColumn.Name = "studfnameDataGridViewTextBoxColumn";
            this.studfnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.studfnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // studlnameDataGridViewTextBoxColumn
            // 
            this.studlnameDataGridViewTextBoxColumn.DataPropertyName = "stud_lname";
            this.studlnameDataGridViewTextBoxColumn.HeaderText = "stud_lname";
            this.studlnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studlnameDataGridViewTextBoxColumn.Name = "studlnameDataGridViewTextBoxColumn";
            this.studlnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.studlnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // studmiDataGridViewTextBoxColumn
            // 
            this.studmiDataGridViewTextBoxColumn.DataPropertyName = "stud_mi";
            this.studmiDataGridViewTextBoxColumn.HeaderText = "stud_mi";
            this.studmiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studmiDataGridViewTextBoxColumn.Name = "studmiDataGridViewTextBoxColumn";
            this.studmiDataGridViewTextBoxColumn.ReadOnly = true;
            this.studmiDataGridViewTextBoxColumn.Width = 125;
            // 
            // studbdayDataGridViewTextBoxColumn
            // 
            this.studbdayDataGridViewTextBoxColumn.DataPropertyName = "stud_bday";
            this.studbdayDataGridViewTextBoxColumn.HeaderText = "stud_bday";
            this.studbdayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studbdayDataGridViewTextBoxColumn.Name = "studbdayDataGridViewTextBoxColumn";
            this.studbdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.studbdayDataGridViewTextBoxColumn.Width = 125;
            // 
            // studaddressDataGridViewTextBoxColumn
            // 
            this.studaddressDataGridViewTextBoxColumn.DataPropertyName = "stud_address";
            this.studaddressDataGridViewTextBoxColumn.HeaderText = "stud_address";
            this.studaddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studaddressDataGridViewTextBoxColumn.Name = "studaddressDataGridViewTextBoxColumn";
            this.studaddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.studaddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // studphoneDataGridViewTextBoxColumn
            // 
            this.studphoneDataGridViewTextBoxColumn.DataPropertyName = "stud_phone";
            this.studphoneDataGridViewTextBoxColumn.HeaderText = "stud_phone";
            this.studphoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studphoneDataGridViewTextBoxColumn.Name = "studphoneDataGridViewTextBoxColumn";
            this.studphoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.studphoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // studemailDataGridViewTextBoxColumn
            // 
            this.studemailDataGridViewTextBoxColumn.DataPropertyName = "stud_email";
            this.studemailDataGridViewTextBoxColumn.HeaderText = "stud_email";
            this.studemailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studemailDataGridViewTextBoxColumn.Name = "studemailDataGridViewTextBoxColumn";
            this.studemailDataGridViewTextBoxColumn.ReadOnly = true;
            this.studemailDataGridViewTextBoxColumn.Width = 125;
            // 
            // studgenderDataGridViewTextBoxColumn
            // 
            this.studgenderDataGridViewTextBoxColumn.DataPropertyName = "stud_gender";
            this.studgenderDataGridViewTextBoxColumn.HeaderText = "stud_gender";
            this.studgenderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studgenderDataGridViewTextBoxColumn.Name = "studgenderDataGridViewTextBoxColumn";
            this.studgenderDataGridViewTextBoxColumn.ReadOnly = true;
            this.studgenderDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearlevelDataGridViewTextBoxColumn
            // 
            this.yearlevelDataGridViewTextBoxColumn.DataPropertyName = "year_level";
            this.yearlevelDataGridViewTextBoxColumn.HeaderText = "year_level";
            this.yearlevelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearlevelDataGridViewTextBoxColumn.Name = "yearlevelDataGridViewTextBoxColumn";
            this.yearlevelDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearlevelDataGridViewTextBoxColumn.Width = 125;
            // 
            // prognameDataGridViewTextBoxColumn
            // 
            this.prognameDataGridViewTextBoxColumn.DataPropertyName = "prog_name";
            this.prognameDataGridViewTextBoxColumn.HeaderText = "prog_name";
            this.prognameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prognameDataGridViewTextBoxColumn.Name = "prognameDataGridViewTextBoxColumn";
            this.prognameDataGridViewTextBoxColumn.ReadOnly = true;
            this.prognameDataGridViewTextBoxColumn.Width = 125;
            // 
            // studgpaDataGridViewTextBoxColumn
            // 
            this.studgpaDataGridViewTextBoxColumn.DataPropertyName = "stud_gpa";
            this.studgpaDataGridViewTextBoxColumn.HeaderText = "stud_gpa";
            this.studgpaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studgpaDataGridViewTextBoxColumn.Name = "studgpaDataGridViewTextBoxColumn";
            this.studgpaDataGridViewTextBoxColumn.ReadOnly = true;
            this.studgpaDataGridViewTextBoxColumn.Width = 125;
            // 
            // batchyearDataGridViewTextBoxColumn
            // 
            this.batchyearDataGridViewTextBoxColumn.DataPropertyName = "batch_year";
            this.batchyearDataGridViewTextBoxColumn.HeaderText = "batch_year";
            this.batchyearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.batchyearDataGridViewTextBoxColumn.Name = "batchyearDataGridViewTextBoxColumn";
            this.batchyearDataGridViewTextBoxColumn.ReadOnly = true;
            this.batchyearDataGridViewTextBoxColumn.Width = 125;
            // 
            // showStudentBindingSource1
            // 
            this.showStudentBindingSource1.DataMember = "showStudent";
            this.showStudentBindingSource1.DataSource = this.dbmsDataSet19;
            // 
            // dbmsDataSet19
            // 
            this.dbmsDataSet19.DataSetName = "dbmsDataSet19";
            this.dbmsDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.search);
            this.panel2.Controls.Add(this.searchTxtbox);
            this.panel2.Location = new System.Drawing.Point(257, 18);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 31);
            this.panel2.TabIndex = 11;
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search.BackColor = System.Drawing.Color.White;
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.Location = new System.Drawing.Point(249, 4);
            this.search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(25, 23);
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
            this.searchTxtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchTxtbox.Multiline = true;
            this.searchTxtbox.Name = "searchTxtbox";
            this.searchTxtbox.Size = new System.Drawing.Size(280, 31);
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
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search the ID number:";
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
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBtn.Location = new System.Drawing.Point(608, 458);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(172, 49);
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
            // showStudentTableAdapter1
            // 
            this.showStudentTableAdapter1.ClearBeforeFill = true;
            // 
            // deleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(18)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(816, 517);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "deleteStudent";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DELETE STUDENT INFORMATION";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showStudentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet19)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet18)).EndInit();
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