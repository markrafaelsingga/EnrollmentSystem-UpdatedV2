namespace EnrollmentSystem
{
    partial class updateProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateProfessor));
            this.saveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.search = new System.Windows.Forms.PictureBox();
            this.searchTxtbox = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.lnameTxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fnameTxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.miTxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.birthdatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insfnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insmiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inslnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insdobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showInstructorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbmsDataSet8 = new EnrollmentSystem.dbmsDataSet8();
            this.dbmsDataSet7 = new EnrollmentSystem.dbmsDataSet7();
            this.showInstructorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showInstructorTableAdapter = new EnrollmentSystem.dbmsDataSet7TableAdapters.showInstructorTableAdapter();
            this.showInstructorTableAdapter1 = new EnrollmentSystem.dbmsDataSet8TableAdapters.showInstructorTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showInstructorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showInstructorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(764, 781);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(129, 32);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            this.saveBtn.MouseLeave += new System.EventHandler(this.saveBtn_MouseLeave);
            this.saveBtn.MouseHover += new System.EventHandler(this.saveBtn_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Instructor";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.search);
            this.panel2.Controls.Add(this.searchTxtbox);
            this.panel2.Location = new System.Drawing.Point(193, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 25);
            this.panel2.TabIndex = 11;
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search.BackColor = System.Drawing.Color.White;
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.Location = new System.Drawing.Point(446, 3);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(19, 19);
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
            this.searchTxtbox.Location = new System.Drawing.Point(0, 0);
            this.searchTxtbox.Multiline = true;
            this.searchTxtbox.Name = "searchTxtbox";
            this.searchTxtbox.Size = new System.Drawing.Size(469, 25);
            this.searchTxtbox.TabIndex = 6;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.emailLbl.Location = new System.Drawing.Point(15, 97);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(84, 20);
            this.emailLbl.TabIndex = 21;
            this.emailLbl.Text = "Lastname:";
            // 
            // lnameTxtbox
            // 
            this.lnameTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameTxtbox.Location = new System.Drawing.Point(17, 68);
            this.lnameTxtbox.Name = "lnameTxtbox";
            this.lnameTxtbox.Size = new System.Drawing.Size(217, 26);
            this.lnameTxtbox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(276, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Firstname:";
            // 
            // fnameTxtbox
            // 
            this.fnameTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameTxtbox.Location = new System.Drawing.Point(280, 68);
            this.fnameTxtbox.Name = "fnameTxtbox";
            this.fnameTxtbox.Size = new System.Drawing.Size(230, 26);
            this.fnameTxtbox.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(574, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "MI:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(13, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Birthdate:";
            // 
            // miTxtbox
            // 
            this.miTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miTxtbox.Location = new System.Drawing.Point(545, 68);
            this.miTxtbox.Name = "miTxtbox";
            this.miTxtbox.Size = new System.Drawing.Size(81, 26);
            this.miTxtbox.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(276, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Phone number:";
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(280, 146);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(192, 26);
            this.phone.TabIndex = 33;
            // 
            // emailtextBox
            // 
            this.emailtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtextBox.Location = new System.Drawing.Point(19, 237);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(215, 26);
            this.emailtextBox.TabIndex = 35;
            // 
            // birthdatePicker
            // 
            this.birthdatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdatePicker.Location = new System.Drawing.Point(17, 146);
            this.birthdatePicker.Name = "birthdatePicker";
            this.birthdatePicker.Size = new System.Drawing.Size(177, 26);
            this.birthdatePicker.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(13, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Email:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.birthdatePicker);
            this.panel1.Controls.Add(this.emailtextBox);
            this.panel1.Controls.Add(this.phone);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.miTxtbox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.fnameTxtbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lnameTxtbox);
            this.panel1.Controls.Add(this.emailLbl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(28, 463);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 312);
            this.panel1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(131)))), ((int)(((byte)(179)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.insidDataGridViewTextBoxColumn,
            this.insnoDataGridViewTextBoxColumn,
            this.insfnameDataGridViewTextBoxColumn,
            this.insmiDataGridViewTextBoxColumn,
            this.inslnameDataGridViewTextBoxColumn,
            this.insdobDataGridViewTextBoxColumn,
            this.insageDataGridViewTextBoxColumn,
            this.insphoneDataGridViewTextBoxColumn,
            this.insemailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.showInstructorBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(28, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(865, 418);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // insidDataGridViewTextBoxColumn
            // 
            this.insidDataGridViewTextBoxColumn.DataPropertyName = "ins_id";
            this.insidDataGridViewTextBoxColumn.HeaderText = "ins_id";
            this.insidDataGridViewTextBoxColumn.Name = "insidDataGridViewTextBoxColumn";
            this.insidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // insnoDataGridViewTextBoxColumn
            // 
            this.insnoDataGridViewTextBoxColumn.DataPropertyName = "ins_no";
            this.insnoDataGridViewTextBoxColumn.HeaderText = "ins_no";
            this.insnoDataGridViewTextBoxColumn.Name = "insnoDataGridViewTextBoxColumn";
            this.insnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // insfnameDataGridViewTextBoxColumn
            // 
            this.insfnameDataGridViewTextBoxColumn.DataPropertyName = "ins_fname";
            this.insfnameDataGridViewTextBoxColumn.HeaderText = "ins_fname";
            this.insfnameDataGridViewTextBoxColumn.Name = "insfnameDataGridViewTextBoxColumn";
            this.insfnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // insmiDataGridViewTextBoxColumn
            // 
            this.insmiDataGridViewTextBoxColumn.DataPropertyName = "ins_mi";
            this.insmiDataGridViewTextBoxColumn.HeaderText = "ins_mi";
            this.insmiDataGridViewTextBoxColumn.Name = "insmiDataGridViewTextBoxColumn";
            this.insmiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inslnameDataGridViewTextBoxColumn
            // 
            this.inslnameDataGridViewTextBoxColumn.DataPropertyName = "ins_lname";
            this.inslnameDataGridViewTextBoxColumn.HeaderText = "ins_lname";
            this.inslnameDataGridViewTextBoxColumn.Name = "inslnameDataGridViewTextBoxColumn";
            this.inslnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // insdobDataGridViewTextBoxColumn
            // 
            this.insdobDataGridViewTextBoxColumn.DataPropertyName = "ins_dob";
            this.insdobDataGridViewTextBoxColumn.HeaderText = "ins_dob";
            this.insdobDataGridViewTextBoxColumn.Name = "insdobDataGridViewTextBoxColumn";
            this.insdobDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // insageDataGridViewTextBoxColumn
            // 
            this.insageDataGridViewTextBoxColumn.DataPropertyName = "ins_age";
            this.insageDataGridViewTextBoxColumn.HeaderText = "ins_age";
            this.insageDataGridViewTextBoxColumn.Name = "insageDataGridViewTextBoxColumn";
            this.insageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // insphoneDataGridViewTextBoxColumn
            // 
            this.insphoneDataGridViewTextBoxColumn.DataPropertyName = "ins_phone";
            this.insphoneDataGridViewTextBoxColumn.HeaderText = "ins_phone";
            this.insphoneDataGridViewTextBoxColumn.Name = "insphoneDataGridViewTextBoxColumn";
            this.insphoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // insemailDataGridViewTextBoxColumn
            // 
            this.insemailDataGridViewTextBoxColumn.DataPropertyName = "ins_email";
            this.insemailDataGridViewTextBoxColumn.HeaderText = "ins_email";
            this.insemailDataGridViewTextBoxColumn.Name = "insemailDataGridViewTextBoxColumn";
            this.insemailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // showInstructorBindingSource1
            // 
            this.showInstructorBindingSource1.DataMember = "showInstructor";
            this.showInstructorBindingSource1.DataSource = this.dbmsDataSet8;
            // 
            // dbmsDataSet8
            // 
            this.dbmsDataSet8.DataSetName = "dbmsDataSet8";
            this.dbmsDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbmsDataSet7
            // 
            this.dbmsDataSet7.DataSetName = "dbmsDataSet7";
            this.dbmsDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showInstructorBindingSource
            // 
            this.showInstructorBindingSource.DataMember = "showInstructor";
            this.showInstructorBindingSource.DataSource = this.dbmsDataSet7;
            // 
            // showInstructorTableAdapter
            // 
            this.showInstructorTableAdapter.ClearBeforeFill = true;
            // 
            // showInstructorTableAdapter1
            // 
            this.showInstructorTableAdapter1.ClearBeforeFill = true;
            // 
            // updateProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(921, 825);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "updateProfessor";
            this.Text = "UPDATE PROFESSOR INFORMATION";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showInstructorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showInstructorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox search;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox lnameTxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fnameTxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox miTxtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.DateTimePicker birthdatePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource showInstructorBindingSource;
        private dbmsDataSet7 dbmsDataSet7;
        private dbmsDataSet7TableAdapters.showInstructorTableAdapter showInstructorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn insidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insfnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insmiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inslnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insdobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource showInstructorBindingSource1;
        private dbmsDataSet8 dbmsDataSet8;
        private dbmsDataSet8TableAdapters.showInstructorTableAdapter showInstructorTableAdapter1;
        private System.Windows.Forms.TextBox searchTxtbox;
    }
}