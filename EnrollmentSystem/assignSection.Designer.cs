namespace EnrollmentSystem
{
    partial class assignSection
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
            this.label2 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.program = new System.Windows.Forms.ComboBox();
            this.panel21 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.section = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.yr = new System.Windows.Forms.ComboBox();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.gpa = new System.Windows.Forms.TextBox();
            this.panel23 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.emailTxtbox = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.phoneTxtbox = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.mitextBox = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.fnameTxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lnameTxtbox = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel21.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(48, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Select student id:";
            // 
            // id
            // 
            this.id.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.FormattingEnabled = true;
            this.id.Location = new System.Drawing.Point(53, 100);
            this.id.Margin = new System.Windows.Forms.Padding(4);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(284, 33);
            this.id.TabIndex = 22;
            this.id.SelectedIndexChanged += new System.EventHandler(this.id_SelectedIndexChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(665, 403);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(172, 39);
            this.saveBtn.TabIndex = 23;
            this.saveBtn.Text = "ASSIGN";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            this.saveBtn.MouseLeave += new System.EventHandler(this.saveBtn_MouseLeave);
            this.saveBtn.MouseHover += new System.EventHandler(this.saveBtn_MouseHover);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(4, 1);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 25);
            this.label9.TabIndex = 46;
            this.label9.Text = "Course program:";
            // 
            // program
            // 
            this.program.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.program.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.program.Enabled = false;
            this.program.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.program.FormattingEnabled = true;
            this.program.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.program.Location = new System.Drawing.Point(0, 30);
            this.program.Margin = new System.Windows.Forms.Padding(4);
            this.program.Name = "program";
            this.program.Size = new System.Drawing.Size(248, 33);
            this.program.TabIndex = 24;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.program);
            this.panel21.Controls.Add(this.label9);
            this.panel21.Location = new System.Drawing.Point(321, 323);
            this.panel21.Margin = new System.Windows.Forms.Padding(10);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(248, 63);
            this.panel21.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(4, 1);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 46;
            this.label4.Text = "Section:";
            // 
            // section
            // 
            this.section.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.section.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.section.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.section.FormattingEnabled = true;
            this.section.Items.AddRange(new object[] {
            "A",
            "B",
            "1A",
            "1B"});
            this.section.Location = new System.Drawing.Point(0, 30);
            this.section.Margin = new System.Windows.Forms.Padding(4);
            this.section.Name = "section";
            this.section.Size = new System.Drawing.Size(248, 33);
            this.section.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.section);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(589, 323);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 63);
            this.panel1.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(4, 1);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 45;
            this.label8.Text = "Year level:";
            // 
            // yr
            // 
            this.yr.DisplayMember = "year_level";
            this.yr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.yr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yr.Enabled = false;
            this.yr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yr.FormattingEnabled = true;
            this.yr.Location = new System.Drawing.Point(0, 30);
            this.yr.Margin = new System.Windows.Forms.Padding(4);
            this.yr.Name = "yr";
            this.yr.Size = new System.Drawing.Size(248, 33);
            this.yr.TabIndex = 23;
            this.yr.ValueMember = "year_id";
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.yr);
            this.panel19.Controls.Add(this.label8);
            this.panel19.Location = new System.Drawing.Point(53, 323);
            this.panel19.Margin = new System.Windows.Forms.Padding(10);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(248, 63);
            this.panel19.TabIndex = 64;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label14.Location = new System.Drawing.Point(4, 1);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 25);
            this.label14.TabIndex = 47;
            this.label14.Text = "GPA:";
            // 
            // gpa
            // 
            this.gpa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gpa.Enabled = false;
            this.gpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpa.Location = new System.Drawing.Point(0, 30);
            this.gpa.Margin = new System.Windows.Forms.Padding(4);
            this.gpa.Name = "gpa";
            this.gpa.Size = new System.Drawing.Size(248, 30);
            this.gpa.TabIndex = 4;
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.gpa);
            this.panel23.Controls.Add(this.label14);
            this.panel23.Location = new System.Drawing.Point(589, 241);
            this.panel23.Margin = new System.Windows.Forms.Padding(10);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(248, 60);
            this.panel23.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(4, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email:";
            // 
            // emailTxtbox
            // 
            this.emailTxtbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.emailTxtbox.Enabled = false;
            this.emailTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxtbox.Location = new System.Drawing.Point(0, 30);
            this.emailTxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTxtbox.Name = "emailTxtbox";
            this.emailTxtbox.Size = new System.Drawing.Size(248, 30);
            this.emailTxtbox.TabIndex = 9;
            // 
            // panel12
            // 
            this.panel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel12.Controls.Add(this.emailTxtbox);
            this.panel12.Controls.Add(this.label6);
            this.panel12.Location = new System.Drawing.Point(321, 241);
            this.panel12.Margin = new System.Windows.Forms.Padding(10);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(248, 60);
            this.panel12.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(1, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone number:";
            // 
            // phoneTxtbox
            // 
            this.phoneTxtbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.phoneTxtbox.Enabled = false;
            this.phoneTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTxtbox.Location = new System.Drawing.Point(0, 32);
            this.phoneTxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTxtbox.Name = "phoneTxtbox";
            this.phoneTxtbox.Size = new System.Drawing.Size(248, 30);
            this.phoneTxtbox.TabIndex = 9;
            // 
            // panel10
            // 
            this.panel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel10.Controls.Add(this.phoneTxtbox);
            this.panel10.Controls.Add(this.label5);
            this.panel10.Location = new System.Drawing.Point(53, 241);
            this.panel10.Margin = new System.Windows.Forms.Padding(10);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(248, 62);
            this.panel10.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(1, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "MI:";
            // 
            // mitextBox
            // 
            this.mitextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mitextBox.Enabled = false;
            this.mitextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mitextBox.Location = new System.Drawing.Point(0, 30);
            this.mitextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mitextBox.Name = "mitextBox";
            this.mitextBox.Size = new System.Drawing.Size(248, 30);
            this.mitextBox.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.Controls.Add(this.mitextBox);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(589, 161);
            this.panel7.Margin = new System.Windows.Forms.Padding(10);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(248, 60);
            this.panel7.TabIndex = 60;
            // 
            // fnameTxtbox
            // 
            this.fnameTxtbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fnameTxtbox.Enabled = false;
            this.fnameTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameTxtbox.Location = new System.Drawing.Point(0, 31);
            this.fnameTxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.fnameTxtbox.Name = "fnameTxtbox";
            this.fnameTxtbox.Size = new System.Drawing.Size(248, 30);
            this.fnameTxtbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Firstname:";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.fnameTxtbox);
            this.panel4.Location = new System.Drawing.Point(321, 161);
            this.panel4.Margin = new System.Windows.Forms.Padding(10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(248, 61);
            this.panel4.TabIndex = 59;
            // 
            // lnameTxtbox
            // 
            this.lnameTxtbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lnameTxtbox.Enabled = false;
            this.lnameTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameTxtbox.Location = new System.Drawing.Point(0, 32);
            this.lnameTxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.lnameTxtbox.Name = "lnameTxtbox";
            this.lnameTxtbox.Size = new System.Drawing.Size(248, 30);
            this.lnameTxtbox.TabIndex = 3;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.emailLbl.Location = new System.Drawing.Point(1, 0);
            this.emailLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(104, 25);
            this.emailLbl.TabIndex = 2;
            this.emailLbl.Text = "Lastname:";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.emailLbl);
            this.panel2.Controls.Add(this.lnameTxtbox);
            this.panel2.Location = new System.Drawing.Point(53, 161);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 62);
            this.panel2.TabIndex = 58;
            // 
            // assignSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(878, 540);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel23);
            this.Controls.Add(this.panel19);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel21);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "assignSection";
            this.Text = "ASSIGN SECTION TO A STUDENT:";
            this.Load += new System.EventHandler(this.assignSection_Load);
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox id;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox program;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox section;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox yr;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox gpa;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailTxtbox;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phoneTxtbox;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mitextBox;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox fnameTxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox lnameTxtbox;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Panel panel2;
    }
}