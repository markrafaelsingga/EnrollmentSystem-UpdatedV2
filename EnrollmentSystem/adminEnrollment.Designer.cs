namespace EnrollmentSystem
{
    partial class adminEnrollment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Approve = new System.Windows.Forms.DataGridViewButtonColumn();
            this.viewEnrolleeBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.dbmsDataSet5 = new EnrollmentSystem.dbmsDataSet5();
            this.search = new System.Windows.Forms.PictureBox();
            this.searchTxtbox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dbmsDataSet1 = new EnrollmentSystem.dbmsDataSet1();
            this.viewEnrolleeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.viewEnrolleeTableAdapter1 = new EnrollmentSystem.dbmsDataSet1TableAdapters.viewEnrolleeTableAdapter();
            this.dbmsDataSet2 = new EnrollmentSystem.dbmsDataSet2();
            this.viewEnrolleeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.viewEnrolleeTableAdapter2 = new EnrollmentSystem.dbmsDataSet2TableAdapters.viewEnrolleeTableAdapter();
            this.dbmsDataSet3 = new EnrollmentSystem.dbmsDataSet3();
            this.viewEnrolleeBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.viewEnrolleeTableAdapter3 = new EnrollmentSystem.dbmsDataSet3TableAdapters.viewEnrolleeTableAdapter();
            this.dbmsDataSet4 = new EnrollmentSystem.dbmsDataSet4();
            this.viewEnrolleeBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.viewEnrolleeTableAdapter4 = new EnrollmentSystem.dbmsDataSet4TableAdapters.viewEnrolleeTableAdapter();
            this.viewEnrolleeTableAdapter5 = new EnrollmentSystem.dbmsDataSet5TableAdapters.viewEnrolleeTableAdapter();
            this.dbmsDataSet = new EnrollmentSystem.dbmsDataSet();
            this.viewEnrolleeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewEnrolleeTableAdapter = new EnrollmentSystem.dbmsDataSetTableAdapters.viewEnrolleeTableAdapter();
            this.dbmsDataSet29 = new EnrollmentSystem.dbmsDataSet29();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEnrolleeBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEnrolleeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEnrolleeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEnrolleeBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEnrolleeBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEnrolleeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet29)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(64, 99);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 508);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.Approve});
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
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 508);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Approve
            // 
            this.Approve.HeaderText = "Approve";
            this.Approve.MinimumWidth = 6;
            this.Approve.Name = "Approve";
            this.Approve.ReadOnly = true;
            this.Approve.Text = "Approve";
            this.Approve.UseColumnTextForButtonValue = true;
            // 
            // viewEnrolleeBindingSource5
            // 
            this.viewEnrolleeBindingSource5.DataMember = "viewEnrollee";
            this.viewEnrolleeBindingSource5.DataSource = this.dbmsDataSet5;
            // 
            // dbmsDataSet5
            // 
            this.dbmsDataSet5.DataSetName = "dbmsDataSet5";
            this.dbmsDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(0, 0);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(100, 50);
            this.search.TabIndex = 0;
            this.search.TabStop = false;
            // 
            // searchTxtbox
            // 
            this.searchTxtbox.Location = new System.Drawing.Point(0, 0);
            this.searchTxtbox.Name = "searchTxtbox";
            this.searchTxtbox.Size = new System.Drawing.Size(100, 22);
            this.searchTxtbox.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(53, 25, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1153, 73);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(57, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENROLLMENT";
            // 
            // dbmsDataSet1
            // 
            this.dbmsDataSet1.DataSetName = "dbmsDataSet1";
            this.dbmsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewEnrolleeBindingSource1
            // 
            this.viewEnrolleeBindingSource1.DataMember = "viewEnrollee";
            this.viewEnrolleeBindingSource1.DataSource = this.dbmsDataSet1;
            // 
            // viewEnrolleeTableAdapter1
            // 
            this.viewEnrolleeTableAdapter1.ClearBeforeFill = true;
            // 
            // dbmsDataSet2
            // 
            this.dbmsDataSet2.DataSetName = "dbmsDataSet2";
            this.dbmsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewEnrolleeBindingSource2
            // 
            this.viewEnrolleeBindingSource2.DataMember = "viewEnrollee";
            this.viewEnrolleeBindingSource2.DataSource = this.dbmsDataSet2;
            // 
            // viewEnrolleeTableAdapter2
            // 
            this.viewEnrolleeTableAdapter2.ClearBeforeFill = true;
            // 
            // dbmsDataSet3
            // 
            this.dbmsDataSet3.DataSetName = "dbmsDataSet3";
            this.dbmsDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewEnrolleeBindingSource3
            // 
            this.viewEnrolleeBindingSource3.DataMember = "viewEnrollee";
            this.viewEnrolleeBindingSource3.DataSource = this.dbmsDataSet3;
            // 
            // viewEnrolleeTableAdapter3
            // 
            this.viewEnrolleeTableAdapter3.ClearBeforeFill = true;
            // 
            // dbmsDataSet4
            // 
            this.dbmsDataSet4.DataSetName = "dbmsDataSet4";
            this.dbmsDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewEnrolleeBindingSource4
            // 
            this.viewEnrolleeBindingSource4.DataMember = "viewEnrollee";
            this.viewEnrolleeBindingSource4.DataSource = this.dbmsDataSet4;
            // 
            // viewEnrolleeTableAdapter4
            // 
            this.viewEnrolleeTableAdapter4.ClearBeforeFill = true;
            // 
            // viewEnrolleeTableAdapter5
            // 
            this.viewEnrolleeTableAdapter5.ClearBeforeFill = true;
            // 
            // dbmsDataSet
            // 
            this.dbmsDataSet.DataSetName = "dbmsDataSet";
            this.dbmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewEnrolleeBindingSource
            // 
            this.viewEnrolleeBindingSource.DataMember = "viewEnrollee";
            this.viewEnrolleeBindingSource.DataSource = this.dbmsDataSet;
            // 
            // viewEnrolleeTableAdapter
            // 
            this.viewEnrolleeTableAdapter.ClearBeforeFill = true;
            // 
            // dbmsDataSet29
            // 
            this.dbmsDataSet29.DataSetName = "dbmsDataSet29";
            this.dbmsDataSet29.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminEnrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1153, 666);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "adminEnrollment";
            this.Text = "adminEnrollment";
            this.Load += new System.EventHandler(this.adminEnrollment_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEnrolleeBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEnrolleeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEnrolleeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEnrolleeBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEnrolleeBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEnrolleeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet29)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource viewEnrolleeBindingSource;
        private dbmsDataSet dbmsDataSet;
        private dbmsDataSetTableAdapters.viewEnrolleeTableAdapter viewEnrolleeTableAdapter;
        private System.Windows.Forms.BindingSource viewEnrolleeBindingSource1;
        private dbmsDataSet1 dbmsDataSet1;
        private dbmsDataSet1TableAdapters.viewEnrolleeTableAdapter viewEnrolleeTableAdapter1;
        private System.Windows.Forms.BindingSource viewEnrolleeBindingSource2;
        private dbmsDataSet2 dbmsDataSet2;
        private dbmsDataSet2TableAdapters.viewEnrolleeTableAdapter viewEnrolleeTableAdapter2;
        private System.Windows.Forms.BindingSource viewEnrolleeBindingSource3;
        private dbmsDataSet3 dbmsDataSet3;
        private dbmsDataSet3TableAdapters.viewEnrolleeTableAdapter viewEnrolleeTableAdapter3;
        private System.Windows.Forms.BindingSource viewEnrolleeBindingSource4;
        private dbmsDataSet4 dbmsDataSet4;
        private dbmsDataSet4TableAdapters.viewEnrolleeTableAdapter viewEnrolleeTableAdapter4;
        private System.Windows.Forms.BindingSource viewEnrolleeBindingSource5;
        private dbmsDataSet5 dbmsDataSet5;
        private dbmsDataSet5TableAdapters.viewEnrolleeTableAdapter viewEnrolleeTableAdapter5;
        private System.Windows.Forms.PictureBox search;
        private System.Windows.Forms.TextBox searchTxtbox;
        private dbmsDataSet29 dbmsDataSet29;
        private System.Windows.Forms.DataGridViewButtonColumn Approve;
    }
}