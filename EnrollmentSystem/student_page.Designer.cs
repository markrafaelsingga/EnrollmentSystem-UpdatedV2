namespace EnrollmentSystem
{
    partial class student_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(student_page));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userFname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnHome = new System.Windows.Forms.Panel();
            this.homeBtn = new System.Windows.Forms.Button();
            this.pnEnroll = new System.Windows.Forms.Panel();
            this.enrollmentBtn = new System.Windows.Forms.Button();
            this.pnCourse = new System.Windows.Forms.Panel();
            this.courseBtn = new System.Windows.Forms.Button();
            this.pnClass = new System.Windows.Forms.Panel();
            this.classBtn = new System.Windows.Forms.Button();
            this.pnProfile = new System.Windows.Forms.Panel();
            this.profileBtn = new System.Windows.Forms.Button();
            this.pnLogout = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnHome.SuspendLayout();
            this.pnEnroll.SuspendLayout();
            this.pnCourse.SuspendLayout();
            this.pnClass.SuspendLayout();
            this.pnProfile.SuspendLayout();
            this.pnLogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.pnHome);
            this.sidebar.Controls.Add(this.pnEnroll);
            this.sidebar.Controls.Add(this.pnCourse);
            this.sidebar.Controls.Add(this.pnClass);
            this.sidebar.Controls.Add(this.pnProfile);
            this.sidebar.Controls.Add(this.pnLogout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.sidebar.Size = new System.Drawing.Size(220, 576);
            this.sidebar.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 106);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userFname);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 44);
            this.panel2.TabIndex = 1;
            // 
            // userFname
            // 
            this.userFname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userFname.AutoSize = true;
            this.userFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userFname.ForeColor = System.Drawing.Color.White;
            this.userFname.Location = new System.Drawing.Point(59, 21);
            this.userFname.Name = "userFname";
            this.userFname.Size = new System.Drawing.Size(91, 20);
            this.userFname.TabIndex = 0;
            this.userFname.Text = "STUDENT";
            this.userFname.Click += new System.EventHandler(this.userFname_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(146, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME ";
            // 
            // pnHome
            // 
            this.pnHome.Controls.Add(this.homeBtn);
            this.pnHome.Location = new System.Drawing.Point(3, 170);
            this.pnHome.Name = "pnHome";
            this.pnHome.Size = new System.Drawing.Size(219, 40);
            this.pnHome.TabIndex = 1;
            // 
            // homeBtn
            // 
            this.homeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
            this.homeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
            this.homeBtn.FlatAppearance.BorderSize = 2;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(0, 0);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.homeBtn.Size = new System.Drawing.Size(219, 40);
            this.homeBtn.TabIndex = 3;
            this.homeBtn.Text = "      HOME";
            this.homeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // pnEnroll
            // 
            this.pnEnroll.Controls.Add(this.enrollmentBtn);
            this.pnEnroll.Location = new System.Drawing.Point(3, 216);
            this.pnEnroll.Name = "pnEnroll";
            this.pnEnroll.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.pnEnroll.Size = new System.Drawing.Size(219, 40);
            this.pnEnroll.TabIndex = 1;
            // 
            // enrollmentBtn
            // 
            this.enrollmentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enrollmentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
            this.enrollmentBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
            this.enrollmentBtn.FlatAppearance.BorderSize = 2;
            this.enrollmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enrollmentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrollmentBtn.Image = ((System.Drawing.Image)(resources.GetObject("enrollmentBtn.Image")));
            this.enrollmentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.enrollmentBtn.Location = new System.Drawing.Point(0, 0);
            this.enrollmentBtn.Name = "enrollmentBtn";
            this.enrollmentBtn.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.enrollmentBtn.Size = new System.Drawing.Size(219, 40);
            this.enrollmentBtn.TabIndex = 3;
            this.enrollmentBtn.Text = "      ENROLLMENT";
            this.enrollmentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.enrollmentBtn.UseVisualStyleBackColor = false;
            this.enrollmentBtn.Click += new System.EventHandler(this.enrollmentBtn_Click);
            // 
            // pnCourse
            // 
            this.pnCourse.Controls.Add(this.courseBtn);
            this.pnCourse.Location = new System.Drawing.Point(3, 262);
            this.pnCourse.Name = "pnCourse";
            this.pnCourse.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.pnCourse.Size = new System.Drawing.Size(219, 40);
            this.pnCourse.TabIndex = 1;
            // 
            // courseBtn
            // 
            this.courseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.courseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
            this.courseBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
            this.courseBtn.FlatAppearance.BorderSize = 2;
            this.courseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.courseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseBtn.Image = ((System.Drawing.Image)(resources.GetObject("courseBtn.Image")));
            this.courseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.courseBtn.Location = new System.Drawing.Point(0, 0);
            this.courseBtn.Name = "courseBtn";
            this.courseBtn.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.courseBtn.Size = new System.Drawing.Size(219, 40);
            this.courseBtn.TabIndex = 3;
            this.courseBtn.Text = "      COURSES";
            this.courseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.courseBtn.UseVisualStyleBackColor = false;
            this.courseBtn.Click += new System.EventHandler(this.courseBtn_Click);
            // 
            // pnClass
            // 
            this.pnClass.Controls.Add(this.classBtn);
            this.pnClass.Location = new System.Drawing.Point(3, 308);
            this.pnClass.Name = "pnClass";
            this.pnClass.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.pnClass.Size = new System.Drawing.Size(219, 40);
            this.pnClass.TabIndex = 1;
            // 
            // classBtn
            // 
            this.classBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
            this.classBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
            this.classBtn.FlatAppearance.BorderSize = 2;
            this.classBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classBtn.Image = ((System.Drawing.Image)(resources.GetObject("classBtn.Image")));
            this.classBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.classBtn.Location = new System.Drawing.Point(0, 0);
            this.classBtn.Name = "classBtn";
            this.classBtn.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.classBtn.Size = new System.Drawing.Size(219, 40);
            this.classBtn.TabIndex = 3;
            this.classBtn.Text = "      CLASS";
            this.classBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.classBtn.UseVisualStyleBackColor = false;
            this.classBtn.Click += new System.EventHandler(this.classBtn_Click);
            // 
            // pnProfile
            // 
            this.pnProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnProfile.Controls.Add(this.profileBtn);
            this.pnProfile.Location = new System.Drawing.Point(3, 354);
            this.pnProfile.Name = "pnProfile";
            this.pnProfile.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.pnProfile.Size = new System.Drawing.Size(219, 40);
            this.pnProfile.TabIndex = 1;
            // 
            // profileBtn
            // 
            this.profileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
            this.profileBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
            this.profileBtn.FlatAppearance.BorderSize = 2;
            this.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBtn.Image = ((System.Drawing.Image)(resources.GetObject("profileBtn.Image")));
            this.profileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileBtn.Location = new System.Drawing.Point(0, 0);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.profileBtn.Size = new System.Drawing.Size(218, 40);
            this.profileBtn.TabIndex = 3;
            this.profileBtn.Text = "      PROFILE";
            this.profileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileBtn.UseVisualStyleBackColor = false;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // pnLogout
            // 
            this.pnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnLogout.Controls.Add(this.logoutBtn);
            this.pnLogout.Location = new System.Drawing.Point(3, 400);
            this.pnLogout.Name = "pnLogout";
            this.pnLogout.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.pnLogout.Size = new System.Drawing.Size(219, 40);
            this.pnLogout.TabIndex = 1;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
            this.logoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
            this.logoutBtn.FlatAppearance.BorderSize = 2;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(0, 0);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Padding = new System.Windows.Forms.Padding(12, 5, 10, 5);
            this.logoutBtn.Size = new System.Drawing.Size(219, 40);
            this.logoutBtn.TabIndex = 3;
            this.logoutBtn.Text = "      LOGOUT";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // student_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 576);
            this.Controls.Add(this.sidebar);
            this.IsMdiContainer = true;
            this.Name = "student_page";
            this.Text = "ENROLLMENT SYSTEM / STUDENT";
            this.Load += new System.EventHandler(this.student_page_Load);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnHome.ResumeLayout(false);
            this.pnEnroll.ResumeLayout(false);
            this.pnCourse.ResumeLayout(false);
            this.pnClass.ResumeLayout(false);
            this.pnProfile.ResumeLayout(false);
            this.pnLogout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnHome;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Panel pnEnroll;
        private System.Windows.Forms.Button enrollmentBtn;
        private System.Windows.Forms.Panel pnCourse;
        private System.Windows.Forms.Button courseBtn;
        private System.Windows.Forms.Panel pnClass;
        private System.Windows.Forms.Button classBtn;
        private System.Windows.Forms.Panel pnProfile;
        private System.Windows.Forms.Button profileBtn;
        private System.Windows.Forms.Panel pnLogout;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label userFname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}