namespace EnrollmentSystem
{
    partial class chooseClass
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveBtn = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.class_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crs_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crs_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_Fromtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_Totime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructor_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(40, 32);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(744, 385);
            this.panel3.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
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
            this.check,
            this.class_code,
            this.crs_name,
            this.crs_desc,
            this.class_Fromtime,
            this.class_Totime,
            this.class_day,
            this.instructor_name,
            this.room_name,
            this.year_id});
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(744, 385);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(612, 425);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(172, 39);
            this.saveBtn.TabIndex = 20;
            this.saveBtn.Text = "ENROLL";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            this.saveBtn.MouseLeave += new System.EventHandler(this.saveBtn_MouseLeave);
            this.saveBtn.MouseHover += new System.EventHandler(this.saveBtn_MouseHover);
            // 
            // check
            // 
            this.check.HeaderText = "Select";
            this.check.MinimumWidth = 6;
            this.check.Name = "check";
            this.check.ReadOnly = true;
            this.check.ToolTipText = "Select";
            this.check.Width = 62;
            // 
            // class_code
            // 
            this.class_code.DataPropertyName = "class_code";
            this.class_code.HeaderText = "Class code";
            this.class_code.MinimumWidth = 6;
            this.class_code.Name = "class_code";
            this.class_code.ReadOnly = true;
            this.class_code.ToolTipText = "Class code";
            this.class_code.Width = 122;
            // 
            // crs_name
            // 
            this.crs_name.DataPropertyName = "crs_name";
            this.crs_name.HeaderText = "Course name";
            this.crs_name.MinimumWidth = 6;
            this.crs_name.Name = "crs_name";
            this.crs_name.ReadOnly = true;
            this.crs_name.ToolTipText = "Course name";
            this.crs_name.Width = 138;
            // 
            // crs_desc
            // 
            this.crs_desc.DataPropertyName = "crs_desc";
            this.crs_desc.HeaderText = "Course description";
            this.crs_desc.MinimumWidth = 6;
            this.crs_desc.Name = "crs_desc";
            this.crs_desc.ReadOnly = true;
            this.crs_desc.ToolTipText = "Course description";
            this.crs_desc.Width = 179;
            // 
            // class_Fromtime
            // 
            this.class_Fromtime.DataPropertyName = "class_fromTime";
            this.class_Fromtime.HeaderText = "Class start";
            this.class_Fromtime.MinimumWidth = 6;
            this.class_Fromtime.Name = "class_Fromtime";
            this.class_Fromtime.ReadOnly = true;
            this.class_Fromtime.ToolTipText = "Class start";
            this.class_Fromtime.Width = 120;
            // 
            // class_Totime
            // 
            this.class_Totime.DataPropertyName = "class_toTime";
            this.class_Totime.HeaderText = "Class end";
            this.class_Totime.MinimumWidth = 6;
            this.class_Totime.Name = "class_Totime";
            this.class_Totime.ReadOnly = true;
            this.class_Totime.ToolTipText = "Class end";
            this.class_Totime.Width = 113;
            // 
            // class_day
            // 
            this.class_day.DataPropertyName = "class_day";
            this.class_day.HeaderText = "Class day";
            this.class_day.MinimumWidth = 6;
            this.class_day.Name = "class_day";
            this.class_day.ReadOnly = true;
            this.class_day.ToolTipText = "Class day";
            this.class_day.Width = 112;
            // 
            // instructor_name
            // 
            this.instructor_name.DataPropertyName = "instructor_name";
            this.instructor_name.HeaderText = "Instructor";
            this.instructor_name.MinimumWidth = 6;
            this.instructor_name.Name = "instructor_name";
            this.instructor_name.ReadOnly = true;
            this.instructor_name.ToolTipText = "Instructor";
            this.instructor_name.Width = 109;
            // 
            // room_name
            // 
            this.room_name.DataPropertyName = "room_name";
            this.room_name.HeaderText = "Room";
            this.room_name.MinimumWidth = 6;
            this.room_name.Name = "room_name";
            this.room_name.ReadOnly = true;
            this.room_name.ToolTipText = "Room";
            this.room_name.Width = 82;
            // 
            // year_id
            // 
            this.year_id.DataPropertyName = "year_id";
            this.year_id.HeaderText = "Year level";
            this.year_id.MinimumWidth = 6;
            this.year_id.Name = "year_id";
            this.year_id.ReadOnly = true;
            this.year_id.ToolTipText = "Year level";
            this.year_id.Width = 111;
            // 
            // chooseClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(820, 477);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.panel3);
            this.Name = "chooseClass";
            this.Text = "Choose a class to enroll:";
            this.Load += new System.EventHandler(this.chooseClass_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn crs_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn crs_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_Fromtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_Totime;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_day;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructor_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn year_id;
    }
}