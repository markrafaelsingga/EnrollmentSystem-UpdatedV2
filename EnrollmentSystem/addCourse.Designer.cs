namespace EnrollmentSystem
{
    partial class addCourse
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.crsdescTxtbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.crscodeTxtbox = new System.Windows.Forms.TextBox();
            this.courseLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.crsdescTxtbox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.crscodeTxtbox);
            this.panel1.Controls.Add(this.courseLbl);
            this.panel1.Location = new System.Drawing.Point(27, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 238);
            this.panel1.TabIndex = 0;
            // 
            // crsdescTxtbox
            // 
            this.crsdescTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crsdescTxtbox.Location = new System.Drawing.Point(18, 96);
            this.crsdescTxtbox.Multiline = true;
            this.crsdescTxtbox.Name = "crsdescTxtbox";
            this.crsdescTxtbox.Size = new System.Drawing.Size(469, 124);
            this.crsdescTxtbox.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(14, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Description:";
            // 
            // crscodeTxtbox
            // 
            this.crscodeTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crscodeTxtbox.Location = new System.Drawing.Point(18, 34);
            this.crscodeTxtbox.Name = "crscodeTxtbox";
            this.crscodeTxtbox.Size = new System.Drawing.Size(215, 26);
            this.crscodeTxtbox.TabIndex = 20;
            // 
            // courseLbl
            // 
            this.courseLbl.AutoSize = true;
            this.courseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.courseLbl.Location = new System.Drawing.Point(14, 11);
            this.courseLbl.Name = "courseLbl";
            this.courseLbl.Size = new System.Drawing.Size(103, 20);
            this.courseLbl.TabIndex = 19;
            this.courseLbl.Text = "Course code:";
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(401, 279);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(129, 32);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.MouseLeave += new System.EventHandler(this.saveBtn_MouseLeave);
            this.saveBtn.MouseHover += new System.EventHandler(this.saveBtn_MouseHover);
            // 
            // addCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(559, 323);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addCourse";
            this.Text = "ADD NEW COURSE";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox crsdescTxtbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox crscodeTxtbox;
        private System.Windows.Forms.Label courseLbl;
        private System.Windows.Forms.Button saveBtn;
    }
}