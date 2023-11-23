namespace EnrollmentSystem
{
    partial class adminClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminClass));
            this.showClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbmsDataSet26 = new EnrollmentSystem.dbmsDataSet26();
            this.showClassTableAdapter = new EnrollmentSystem.dbmsDataSet26TableAdapters.showClassTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchTxtbox = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.PictureBox();
            this.edit = new System.Windows.Forms.PictureBox();
            this.add = new System.Windows.Forms.PictureBox();
            this.delete = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbmsDataSet27 = new EnrollmentSystem.dbmsDataSet27();
            this.showClassBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.showClassTableAdapter1 = new EnrollmentSystem.dbmsDataSet27TableAdapters.showClassTableAdapter();
            this.classcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classsectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classfromTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classtoTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crsnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.showClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet26)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showClassBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // showClassBindingSource
            // 
            this.showClassBindingSource.DataMember = "showClass";
            this.showClassBindingSource.DataSource = this.dbmsDataSet26;
            // 
            // dbmsDataSet26
            // 
            this.dbmsDataSet26.DataSetName = "dbmsDataSet26";
            this.dbmsDataSet26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showClassTableAdapter
            // 
            this.showClassTableAdapter.ClearBeforeFill = true;
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
            // searchTxtbox
            // 
            this.searchTxtbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxtbox.Location = new System.Drawing.Point(0, 4);
            this.searchTxtbox.Name = "searchTxtbox";
            this.searchTxtbox.Size = new System.Drawing.Size(409, 26);
            this.searchTxtbox.TabIndex = 3;
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
            this.flowLayoutPanel2.Size = new System.Drawing.Size(865, 58);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(53, 25, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(865, 59);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(57, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLASSES";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(49, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 387);
            this.panel1.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(131)))), ((int)(((byte)(179)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classcodeDataGridViewTextBoxColumn,
            this.classsectionDataGridViewTextBoxColumn,
            this.classfromTimeDataGridViewTextBoxColumn,
            this.classtoTimeDataGridViewTextBoxColumn,
            this.classdayDataGridViewTextBoxColumn,
            this.crsnameDataGridViewTextBoxColumn,
            this.instructornameDataGridViewTextBoxColumn,
            this.roomnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.showClassBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(773, 387);
            this.dataGridView1.TabIndex = 0;
            // 
            // dbmsDataSet27
            // 
            this.dbmsDataSet27.DataSetName = "dbmsDataSet27";
            this.dbmsDataSet27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showClassBindingSource1
            // 
            this.showClassBindingSource1.DataMember = "showClass";
            this.showClassBindingSource1.DataSource = this.dbmsDataSet27;
            // 
            // showClassTableAdapter1
            // 
            this.showClassTableAdapter1.ClearBeforeFill = true;
            // 
            // classcodeDataGridViewTextBoxColumn
            // 
            this.classcodeDataGridViewTextBoxColumn.DataPropertyName = "class_code";
            this.classcodeDataGridViewTextBoxColumn.HeaderText = "class_code";
            this.classcodeDataGridViewTextBoxColumn.Name = "classcodeDataGridViewTextBoxColumn";
            this.classcodeDataGridViewTextBoxColumn.ReadOnly = true;
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
            // adminClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 541);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminClass";
            this.Text = "adminClass";
            this.Load += new System.EventHandler(this.adminClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet26)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showClassBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private dbmsDataSet26 dbmsDataSet26;
        private System.Windows.Forms.BindingSource showClassBindingSource;
        private dbmsDataSet26TableAdapters.showClassTableAdapter showClassTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox search;
        private System.Windows.Forms.TextBox searchTxtbox;
        private System.Windows.Forms.PictureBox edit;
        private System.Windows.Forms.PictureBox add;
        private System.Windows.Forms.PictureBox delete;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dbmsDataSet27 dbmsDataSet27;
        private System.Windows.Forms.BindingSource showClassBindingSource1;
        private dbmsDataSet27TableAdapters.showClassTableAdapter showClassTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn classcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classsectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classfromTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classtoTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crsnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomnameDataGridViewTextBoxColumn;
    }
}