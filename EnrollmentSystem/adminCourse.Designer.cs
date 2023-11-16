namespace EnrollmentSystem
{
    partial class adminCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminCourse));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.college = new System.Windows.Forms.PictureBox();
            this.delete = new System.Windows.Forms.PictureBox();
            this.add = new System.Windows.Forms.PictureBox();
            this.edit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.search = new System.Windows.Forms.PictureBox();
            this.searchTxtbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.crscodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crsnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crsdescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearlevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showCrsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dbmsDataSet15 = new EnrollmentSystem.dbmsDataSet15();
            this.showCrsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbmsDataSet6 = new EnrollmentSystem.dbmsDataSet6();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.showCrsTableAdapter = new EnrollmentSystem.dbmsDataSet6TableAdapters.showCrsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dbmsDataSet13 = new EnrollmentSystem.dbmsDataSet13();
            this.showCrsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.showCrsTableAdapter1 = new EnrollmentSystem.dbmsDataSet13TableAdapters.showCrsTableAdapter();
            this.dbmsDataSet14 = new EnrollmentSystem.dbmsDataSet14();
            this.showCrsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.showCrsTableAdapter2 = new EnrollmentSystem.dbmsDataSet14TableAdapters.showCrsTableAdapter();
            this.showCrsTableAdapter3 = new EnrollmentSystem.dbmsDataSet15TableAdapters.showCrsTableAdapter();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.college)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showCrsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showCrsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet6)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showCrsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showCrsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.college);
            this.flowLayoutPanel2.Controls.Add(this.delete);
            this.flowLayoutPanel2.Controls.Add(this.add);
            this.flowLayoutPanel2.Controls.Add(this.edit);
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 65);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 10, 40, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(865, 55);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // college
            // 
            this.college.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.college.Image = ((System.Drawing.Image)(resources.GetObject("college.Image")));
            this.college.Location = new System.Drawing.Point(790, 13);
            this.college.Name = "college";
            this.college.Size = new System.Drawing.Size(32, 35);
            this.college.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.college.TabIndex = 5;
            this.college.TabStop = false;
            this.college.Click += new System.EventHandler(this.college_Click);
            this.college.MouseLeave += new System.EventHandler(this.college_MouseLeave);
            this.college.MouseHover += new System.EventHandler(this.college_MouseHover);
            // 
            // delete
            // 
            this.delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.Location = new System.Drawing.Point(752, 13);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(32, 35);
            this.delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.delete.TabIndex = 5;
            this.delete.TabStop = false;
            this.delete.MouseLeave += new System.EventHandler(this.delete_MouseLeave);
            this.delete.MouseHover += new System.EventHandler(this.delete_MouseHover);
            // 
            // add
            // 
            this.add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add.Image = ((System.Drawing.Image)(resources.GetObject("add.Image")));
            this.add.Location = new System.Drawing.Point(714, 13);
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
            this.edit.Location = new System.Drawing.Point(673, 13);
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
            this.panel2.Location = new System.Drawing.Point(258, 13);
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
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(49, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 348);
            this.panel1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(131)))), ((int)(((byte)(179)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.crscodeDataGridViewTextBoxColumn,
            this.crsnameDataGridViewTextBoxColumn,
            this.crsdescDataGridViewTextBoxColumn,
            this.yearlevelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.showCrsBindingSource3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(772, 348);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // crscodeDataGridViewTextBoxColumn
            // 
            this.crscodeDataGridViewTextBoxColumn.DataPropertyName = "crs_code";
            this.crscodeDataGridViewTextBoxColumn.HeaderText = "crs_code";
            this.crscodeDataGridViewTextBoxColumn.Name = "crscodeDataGridViewTextBoxColumn";
            this.crscodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // crsnameDataGridViewTextBoxColumn
            // 
            this.crsnameDataGridViewTextBoxColumn.DataPropertyName = "crs_name";
            this.crsnameDataGridViewTextBoxColumn.HeaderText = "crs_name";
            this.crsnameDataGridViewTextBoxColumn.Name = "crsnameDataGridViewTextBoxColumn";
            this.crsnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // crsdescDataGridViewTextBoxColumn
            // 
            this.crsdescDataGridViewTextBoxColumn.DataPropertyName = "crs_desc";
            this.crsdescDataGridViewTextBoxColumn.HeaderText = "crs_desc";
            this.crsdescDataGridViewTextBoxColumn.Name = "crsdescDataGridViewTextBoxColumn";
            this.crsdescDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearlevelDataGridViewTextBoxColumn
            // 
            this.yearlevelDataGridViewTextBoxColumn.DataPropertyName = "year_level";
            this.yearlevelDataGridViewTextBoxColumn.HeaderText = "year_level";
            this.yearlevelDataGridViewTextBoxColumn.Name = "yearlevelDataGridViewTextBoxColumn";
            this.yearlevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // showCrsBindingSource3
            // 
            this.showCrsBindingSource3.DataMember = "showCrs";
            this.showCrsBindingSource3.DataSource = this.dbmsDataSet15;
            // 
            // dbmsDataSet15
            // 
            this.dbmsDataSet15.DataSetName = "dbmsDataSet15";
            this.dbmsDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showCrsBindingSource
            // 
            this.showCrsBindingSource.DataMember = "showCrs";
            this.showCrsBindingSource.DataSource = this.dbmsDataSet6;
            // 
            // dbmsDataSet6
            // 
            this.dbmsDataSet6.DataSetName = "dbmsDataSet6";
            this.dbmsDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.label1.Size = new System.Drawing.Size(367, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "COURSES INFORMATION";
            // 
            // showCrsTableAdapter
            // 
            this.showCrsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(689, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dbmsDataSet13
            // 
            this.dbmsDataSet13.DataSetName = "dbmsDataSet13";
            this.dbmsDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showCrsBindingSource1
            // 
            this.showCrsBindingSource1.DataMember = "showCrs";
            this.showCrsBindingSource1.DataSource = this.dbmsDataSet13;
            // 
            // showCrsTableAdapter1
            // 
            this.showCrsTableAdapter1.ClearBeforeFill = true;
            // 
            // dbmsDataSet14
            // 
            this.dbmsDataSet14.DataSetName = "dbmsDataSet14";
            this.dbmsDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showCrsBindingSource2
            // 
            this.showCrsBindingSource2.DataMember = "showCrs";
            this.showCrsBindingSource2.DataSource = this.dbmsDataSet14;
            // 
            // showCrsTableAdapter2
            // 
            this.showCrsTableAdapter2.ClearBeforeFill = true;
            // 
            // showCrsTableAdapter3
            // 
            this.showCrsTableAdapter3.ClearBeforeFill = true;
            // 
            // adminCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(865, 541);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminCourse";
            this.Text = "adminCourse";
            this.Load += new System.EventHandler(this.adminCourse_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.college)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showCrsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showCrsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet6)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showCrsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showCrsBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox delete;
        private System.Windows.Forms.PictureBox add;
        private System.Windows.Forms.PictureBox edit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox college;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox search;
        private System.Windows.Forms.TextBox searchTxtbox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private dbmsDataSet6 dbmsDataSet6;
        private System.Windows.Forms.BindingSource showCrsBindingSource;
        private dbmsDataSet6TableAdapters.showCrsTableAdapter showCrsTableAdapter;
        private System.Windows.Forms.Button button1;
        private dbmsDataSet13 dbmsDataSet13;
        private System.Windows.Forms.BindingSource showCrsBindingSource1;
        private dbmsDataSet13TableAdapters.showCrsTableAdapter showCrsTableAdapter1;
        private dbmsDataSet14 dbmsDataSet14;
        private System.Windows.Forms.BindingSource showCrsBindingSource2;
        private dbmsDataSet14TableAdapters.showCrsTableAdapter showCrsTableAdapter2;
        private dbmsDataSet15 dbmsDataSet15;
        private System.Windows.Forms.BindingSource showCrsBindingSource3;
        private dbmsDataSet15TableAdapters.showCrsTableAdapter showCrsTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn crscodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crsnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crsdescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearlevelDataGridViewTextBoxColumn;
    }
}