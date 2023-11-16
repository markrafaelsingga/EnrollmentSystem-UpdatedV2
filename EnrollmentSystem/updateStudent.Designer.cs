namespace EnrollmentSystem
{
    partial class updateStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateStudent));
            this.saveBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gender = new System.Windows.Forms.ComboBox();
            this.course = new System.Windows.Forms.ComboBox();
            this.birthdatePicker = new System.Windows.Forms.DateTimePicker();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addressTxtbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.miTxtbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fnameTxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lnameTxtbox = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.search = new System.Windows.Forms.PictureBox();
            this.searchTxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yr = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbmsDataSet9 = new EnrollmentSystem.dbmsDataSet9();
            this.showStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showStudentTableAdapter = new EnrollmentSystem.dbmsDataSet9TableAdapters.showStudentTableAdapter();
            this.gpa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dbmsDataSet10 = new EnrollmentSystem.dbmsDataSet10();
            this.showStudentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.showStudentTableAdapter1 = new EnrollmentSystem.dbmsDataSet10TableAdapters.showStudentTableAdapter();
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
            this.studyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prognameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studgpaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showStudentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(761, 781);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(129, 32);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            this.saveBtn.MouseLeave += new System.EventHandler(this.saveBtn_MouseLeave);
            this.saveBtn.MouseHover += new System.EventHandler(this.saveBtn_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.gpa);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.yr);
            this.panel1.Controls.Add(this.gender);
            this.panel1.Controls.Add(this.course);
            this.panel1.Controls.Add(this.birthdatePicker);
            this.panel1.Controls.Add(this.emailtextBox);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.addressTxtbox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.phone);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.miTxtbox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label11);
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
            this.panel1.TabIndex = 9;
            // 
            // gender
            // 
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(325, 174);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(117, 28);
            this.gender.TabIndex = 43;
            // 
            // course
            // 
            this.course.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course.FormattingEnabled = true;
            this.course.Location = new System.Drawing.Point(101, 174);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(122, 28);
            this.course.TabIndex = 42;
            // 
            // birthdatePicker
            // 
            this.birthdatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdatePicker.Location = new System.Drawing.Point(591, 62);
            this.birthdatePicker.Name = "birthdatePicker";
            this.birthdatePicker.Size = new System.Drawing.Size(177, 26);
            this.birthdatePicker.TabIndex = 41;
            // 
            // emailtextBox
            // 
            this.emailtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtextBox.Location = new System.Drawing.Point(171, 267);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(215, 26);
            this.emailtextBox.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label12.Location = new System.Drawing.Point(249, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = "Gender: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(17, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Email:";
            // 
            // addressTxtbox
            // 
            this.addressTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTxtbox.Location = new System.Drawing.Point(101, 128);
            this.addressTxtbox.Name = "addressTxtbox";
            this.addressTxtbox.Size = new System.Drawing.Size(667, 26);
            this.addressTxtbox.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(17, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Course: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(17, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Address:";
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(171, 224);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(215, 26);
            this.phone.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(17, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Phone number:";
            // 
            // miTxtbox
            // 
            this.miTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miTxtbox.Location = new System.Drawing.Point(487, 62);
            this.miTxtbox.Name = "miTxtbox";
            this.miTxtbox.Size = new System.Drawing.Size(81, 26);
            this.miTxtbox.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(638, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Birthdate:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label11.Location = new System.Drawing.Point(467, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Yr:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(516, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "MI:";
            // 
            // fnameTxtbox
            // 
            this.fnameTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameTxtbox.Location = new System.Drawing.Point(253, 62);
            this.fnameTxtbox.Name = "fnameTxtbox";
            this.fnameTxtbox.Size = new System.Drawing.Size(215, 26);
            this.fnameTxtbox.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(321, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Firstname:";
            // 
            // lnameTxtbox
            // 
            this.lnameTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameTxtbox.Location = new System.Drawing.Point(21, 62);
            this.lnameTxtbox.Name = "lnameTxtbox";
            this.lnameTxtbox.Size = new System.Drawing.Size(215, 26);
            this.lnameTxtbox.TabIndex = 22;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.emailLbl.Location = new System.Drawing.Point(83, 91);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(84, 20);
            this.emailLbl.TabIndex = 21;
            this.emailLbl.Text = "Lastname:";
            // 
            // panel2
            // 
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
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search the ID number:";
            // 
            // yr
            // 
            this.yr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yr.FormattingEnabled = true;
            this.yr.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.yr.Location = new System.Drawing.Point(502, 177);
            this.yr.Name = "yr";
            this.yr.Size = new System.Drawing.Size(117, 28);
            this.yr.TabIndex = 44;
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
            this.studyearDataGridViewTextBoxColumn,
            this.prognameDataGridViewTextBoxColumn,
            this.studgpaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.showStudentBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(28, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(865, 418);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dbmsDataSet9
            // 
            this.dbmsDataSet9.DataSetName = "dbmsDataSet9";
            this.dbmsDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showStudentBindingSource
            // 
            this.showStudentBindingSource.DataMember = "showStudent";
            this.showStudentBindingSource.DataSource = this.dbmsDataSet9;
            // 
            // showStudentTableAdapter
            // 
            this.showStudentTableAdapter.ClearBeforeFill = true;
            // 
            // gpa
            // 
            this.gpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpa.Location = new System.Drawing.Point(501, 224);
            this.gpa.Name = "gpa";
            this.gpa.Size = new System.Drawing.Size(215, 26);
            this.gpa.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(444, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "GPA: ";
            // 
            // dbmsDataSet10
            // 
            this.dbmsDataSet10.DataSetName = "dbmsDataSet10";
            this.dbmsDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showStudentBindingSource1
            // 
            this.showStudentBindingSource1.DataMember = "showStudent";
            this.showStudentBindingSource1.DataSource = this.dbmsDataSet10;
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
            // studyearDataGridViewTextBoxColumn
            // 
            this.studyearDataGridViewTextBoxColumn.DataPropertyName = "stud_year";
            this.studyearDataGridViewTextBoxColumn.HeaderText = "stud_year";
            this.studyearDataGridViewTextBoxColumn.Name = "studyearDataGridViewTextBoxColumn";
            this.studyearDataGridViewTextBoxColumn.ReadOnly = true;
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
            // updateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(18)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(921, 825);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "updateStudent";
            this.Text = "UPDATE STUDENT INFORMATION";
            this.Load += new System.EventHandler(this.updateStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showStudentBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox search;
        private System.Windows.Forms.TextBox searchTxtbox;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.ComboBox course;
        private System.Windows.Forms.DateTimePicker birthdatePicker;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addressTxtbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox miTxtbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fnameTxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lnameTxtbox;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.ComboBox yr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource showStudentBindingSource;
        private dbmsDataSet9 dbmsDataSet9;
        private dbmsDataSet9TableAdapters.showStudentTableAdapter showStudentTableAdapter;
        private System.Windows.Forms.TextBox gpa;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn studyearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prognameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studgpaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource showStudentBindingSource1;
        private dbmsDataSet10 dbmsDataSet10;
        private dbmsDataSet10TableAdapters.showStudentTableAdapter showStudentTableAdapter1;
    }
}