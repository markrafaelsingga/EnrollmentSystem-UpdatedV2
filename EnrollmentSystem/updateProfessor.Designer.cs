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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.showInstructorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbmsDataSet8 = new EnrollmentSystem.dbmsDataSet8();
            this.dbmsDataSet7 = new EnrollmentSystem.dbmsDataSet7();
            this.showInstructorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showInstructorTableAdapter = new EnrollmentSystem.dbmsDataSet7TableAdapters.showInstructorTableAdapter();
            this.showInstructorTableAdapter1 = new EnrollmentSystem.dbmsDataSet8TableAdapters.showInstructorTableAdapter();
            this.insidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insfnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insmiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inslnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insdobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.saveBtn.Location = new System.Drawing.Point(1018, 561);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(172, 39);
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
            this.label1.Location = new System.Drawing.Point(44, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Instructor";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.search);
            this.panel2.Controls.Add(this.searchTxtbox);
            this.panel2.Location = new System.Drawing.Point(278, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 31);
            this.panel2.TabIndex = 11;
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search.BackColor = System.Drawing.Color.White;
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.Location = new System.Drawing.Point(679, 4);
            this.search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(25, 23);
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
            this.searchTxtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchTxtbox.Multiline = true;
            this.searchTxtbox.Name = "searchTxtbox";
            this.searchTxtbox.Size = new System.Drawing.Size(709, 31);
            this.searchTxtbox.TabIndex = 6;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.emailLbl.Location = new System.Drawing.Point(44, 66);
            this.emailLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(104, 25);
            this.emailLbl.TabIndex = 21;
            this.emailLbl.Text = "Lastname:";
            // 
            // lnameTxtbox
            // 
            this.lnameTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameTxtbox.Location = new System.Drawing.Point(48, 95);
            this.lnameTxtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lnameTxtbox.Name = "lnameTxtbox";
            this.lnameTxtbox.Size = new System.Drawing.Size(288, 30);
            this.lnameTxtbox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(362, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Firstname:";
            // 
            // fnameTxtbox
            // 
            this.fnameTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameTxtbox.Location = new System.Drawing.Point(367, 95);
            this.fnameTxtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fnameTxtbox.Name = "fnameTxtbox";
            this.fnameTxtbox.Size = new System.Drawing.Size(305, 30);
            this.fnameTxtbox.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(697, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "MI:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(43, 151);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 25);
            this.label8.TabIndex = 27;
            this.label8.Text = "Birthdate:";
            // 
            // miTxtbox
            // 
            this.miTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miTxtbox.Location = new System.Drawing.Point(702, 95);
            this.miTxtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.miTxtbox.Name = "miTxtbox";
            this.miTxtbox.Size = new System.Drawing.Size(107, 30);
            this.miTxtbox.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(362, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Phone number:";
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(367, 178);
            this.phone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(305, 30);
            this.phone.TabIndex = 33;
            // 
            // emailtextBox
            // 
            this.emailtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtextBox.Location = new System.Drawing.Point(702, 180);
            this.emailtextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(285, 30);
            this.emailtextBox.TabIndex = 35;
            // 
            // birthdatePicker
            // 
            this.birthdatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdatePicker.Location = new System.Drawing.Point(50, 178);
            this.birthdatePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.birthdatePicker.Name = "birthdatePicker";
            this.birthdatePicker.Size = new System.Drawing.Size(286, 30);
            this.birthdatePicker.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(697, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
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
            this.panel1.Location = new System.Drawing.Point(37, 316);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 237);
            this.panel1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(131)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(37, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1153, 293);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
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
            // insidDataGridViewTextBoxColumn
            // 
            this.insidDataGridViewTextBoxColumn.DataPropertyName = "ins_id";
            this.insidDataGridViewTextBoxColumn.HeaderText = "Instructor ID";
            this.insidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.insidDataGridViewTextBoxColumn.Name = "insidDataGridViewTextBoxColumn";
            this.insidDataGridViewTextBoxColumn.ReadOnly = true;
            this.insidDataGridViewTextBoxColumn.ToolTipText = "Instructor ID";
            // 
            // insnoDataGridViewTextBoxColumn
            // 
            this.insnoDataGridViewTextBoxColumn.DataPropertyName = "ins_no";
            this.insnoDataGridViewTextBoxColumn.HeaderText = "Instructor no.";
            this.insnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.insnoDataGridViewTextBoxColumn.Name = "insnoDataGridViewTextBoxColumn";
            this.insnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.insnoDataGridViewTextBoxColumn.ToolTipText = "Instructor no.";
            // 
            // insfnameDataGridViewTextBoxColumn
            // 
            this.insfnameDataGridViewTextBoxColumn.DataPropertyName = "ins_fname";
            this.insfnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.insfnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.insfnameDataGridViewTextBoxColumn.Name = "insfnameDataGridViewTextBoxColumn";
            this.insfnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.insfnameDataGridViewTextBoxColumn.ToolTipText = "Firstname";
            // 
            // insmiDataGridViewTextBoxColumn
            // 
            this.insmiDataGridViewTextBoxColumn.DataPropertyName = "ins_mi";
            this.insmiDataGridViewTextBoxColumn.HeaderText = "MI";
            this.insmiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.insmiDataGridViewTextBoxColumn.Name = "insmiDataGridViewTextBoxColumn";
            this.insmiDataGridViewTextBoxColumn.ReadOnly = true;
            this.insmiDataGridViewTextBoxColumn.ToolTipText = "MI";
            // 
            // inslnameDataGridViewTextBoxColumn
            // 
            this.inslnameDataGridViewTextBoxColumn.DataPropertyName = "ins_lname";
            this.inslnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.inslnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inslnameDataGridViewTextBoxColumn.Name = "inslnameDataGridViewTextBoxColumn";
            this.inslnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.inslnameDataGridViewTextBoxColumn.ToolTipText = "Lastname";
            // 
            // insdobDataGridViewTextBoxColumn
            // 
            this.insdobDataGridViewTextBoxColumn.DataPropertyName = "ins_dob";
            this.insdobDataGridViewTextBoxColumn.HeaderText = "Birthdate";
            this.insdobDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.insdobDataGridViewTextBoxColumn.Name = "insdobDataGridViewTextBoxColumn";
            this.insdobDataGridViewTextBoxColumn.ReadOnly = true;
            this.insdobDataGridViewTextBoxColumn.ToolTipText = "Birthdate";
            // 
            // insageDataGridViewTextBoxColumn
            // 
            this.insageDataGridViewTextBoxColumn.DataPropertyName = "ins_age";
            this.insageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.insageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.insageDataGridViewTextBoxColumn.Name = "insageDataGridViewTextBoxColumn";
            this.insageDataGridViewTextBoxColumn.ReadOnly = true;
            this.insageDataGridViewTextBoxColumn.ToolTipText = "Age";
            // 
            // insphoneDataGridViewTextBoxColumn
            // 
            this.insphoneDataGridViewTextBoxColumn.DataPropertyName = "ins_phone";
            this.insphoneDataGridViewTextBoxColumn.HeaderText = "Phone no.";
            this.insphoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.insphoneDataGridViewTextBoxColumn.Name = "insphoneDataGridViewTextBoxColumn";
            this.insphoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.insphoneDataGridViewTextBoxColumn.ToolTipText = "Phone no.";
            // 
            // insemailDataGridViewTextBoxColumn
            // 
            this.insemailDataGridViewTextBoxColumn.DataPropertyName = "ins_email";
            this.insemailDataGridViewTextBoxColumn.HeaderText = "Email Address";
            this.insemailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.insemailDataGridViewTextBoxColumn.Name = "insemailDataGridViewTextBoxColumn";
            this.insemailDataGridViewTextBoxColumn.ReadOnly = true;
            this.insemailDataGridViewTextBoxColumn.ToolTipText = "Email Address";
            // 
            // updateProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1228, 607);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.BindingSource showInstructorBindingSource1;
        private dbmsDataSet8 dbmsDataSet8;
        private dbmsDataSet8TableAdapters.showInstructorTableAdapter showInstructorTableAdapter1;
        private System.Windows.Forms.TextBox searchTxtbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn insidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insfnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insmiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inslnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insdobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insemailDataGridViewTextBoxColumn;
    }
}