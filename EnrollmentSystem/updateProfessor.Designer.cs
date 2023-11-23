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
            this.saveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.idTxtbox = new System.Windows.Forms.TextBox();
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
            this.gender = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.showInstructorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbmsDataSet8 = new EnrollmentSystem.dbmsDataSet8();
            this.dbmsDataSet7 = new EnrollmentSystem.dbmsDataSet7();
            this.showInstructorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showInstructorTableAdapter = new EnrollmentSystem.dbmsDataSet7TableAdapters.showInstructorTableAdapter();
            this.showInstructorTableAdapter1 = new EnrollmentSystem.dbmsDataSet8TableAdapters.showInstructorTableAdapter();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showInstructorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmsDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showInstructorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(481, 278);
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
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Instructor ID:";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.idTxtbox);
            this.panel2.Location = new System.Drawing.Point(151, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 25);
            this.panel2.TabIndex = 11;
            // 
            // idTxtbox
            // 
            this.idTxtbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idTxtbox.Enabled = false;
            this.idTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtbox.Location = new System.Drawing.Point(0, 0);
            this.idTxtbox.Multiline = true;
            this.idTxtbox.Name = "idTxtbox";
            this.idTxtbox.Size = new System.Drawing.Size(210, 25);
            this.idTxtbox.TabIndex = 6;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.emailLbl.Location = new System.Drawing.Point(33, 54);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(84, 20);
            this.emailLbl.TabIndex = 21;
            this.emailLbl.Text = "Lastname:";
            // 
            // lnameTxtbox
            // 
            this.lnameTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameTxtbox.Location = new System.Drawing.Point(36, 77);
            this.lnameTxtbox.Name = "lnameTxtbox";
            this.lnameTxtbox.Size = new System.Drawing.Size(230, 26);
            this.lnameTxtbox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(32, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Firstname:";
            // 
            // fnameTxtbox
            // 
            this.fnameTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameTxtbox.Location = new System.Drawing.Point(36, 139);
            this.fnameTxtbox.Name = "fnameTxtbox";
            this.fnameTxtbox.Size = new System.Drawing.Size(230, 26);
            this.fnameTxtbox.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(32, 179);
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
            this.label8.Location = new System.Drawing.Point(296, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Birthdate:";
            // 
            // miTxtbox
            // 
            this.miTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miTxtbox.Location = new System.Drawing.Point(36, 202);
            this.miTxtbox.Name = "miTxtbox";
            this.miTxtbox.Size = new System.Drawing.Size(81, 26);
            this.miTxtbox.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(296, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Phone number:";
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(300, 137);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(245, 26);
            this.phone.TabIndex = 33;
            // 
            // emailtextBox
            // 
            this.emailtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtextBox.Location = new System.Drawing.Point(302, 202);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(243, 26);
            this.emailtextBox.TabIndex = 35;
            // 
            // birthdatePicker
            // 
            this.birthdatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdatePicker.Location = new System.Drawing.Point(302, 76);
            this.birthdatePicker.Name = "birthdatePicker";
            this.birthdatePicker.Size = new System.Drawing.Size(243, 26);
            this.birthdatePicker.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(298, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Email:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.gender);
            this.panel1.Controls.Add(this.label12);
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
            this.panel1.Location = new System.Drawing.Point(30, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 246);
            this.panel1.TabIndex = 11;
            // 
            // gender
            // 
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(130, 200);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(135, 28);
            this.gender.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label12.Location = new System.Drawing.Point(127, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 20);
            this.label12.TabIndex = 45;
            this.label12.Text = "Gender: ";
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
            this.ClientSize = new System.Drawing.Size(640, 320);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "updateProfessor";
            this.Text = "UPDATE PROFESSOR INFORMATION";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.updateProfessor_FormClosing);
            this.Load += new System.EventHandler(this.updateProfessor_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.BindingSource showInstructorBindingSource;
        private dbmsDataSet7 dbmsDataSet7;
        private dbmsDataSet7TableAdapters.showInstructorTableAdapter showInstructorTableAdapter;
        private System.Windows.Forms.BindingSource showInstructorBindingSource1;
        private dbmsDataSet8 dbmsDataSet8;
        private dbmsDataSet8TableAdapters.showInstructorTableAdapter showInstructorTableAdapter1;
        private System.Windows.Forms.TextBox idTxtbox;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.Label label12;
    }
}