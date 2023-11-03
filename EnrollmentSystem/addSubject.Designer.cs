namespace EnrollmentSystem
{
    partial class addSubject
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.unitTxtbox = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.subdescTxtbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.subcodeTxtbox = new System.Windows.Forms.TextBox();
            this.subjectLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitTxtbox)).BeginInit();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(402, 270);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(129, 32);
            this.saveBtn.TabIndex = 19;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.MouseLeave += new System.EventHandler(this.saveBtn_MouseLeave);
            this.saveBtn.MouseHover += new System.EventHandler(this.saveBtn_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.unitTxtbox);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.subdescTxtbox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.subcodeTxtbox);
            this.panel1.Controls.Add(this.subjectLbl);
            this.panel1.Location = new System.Drawing.Point(28, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 238);
            this.panel1.TabIndex = 18;
            // 
            // unitTxtbox
            // 
            this.unitTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitTxtbox.Location = new System.Drawing.Point(309, 34);
            this.unitTxtbox.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.unitTxtbox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.unitTxtbox.Name = "unitTxtbox";
            this.unitTxtbox.Size = new System.Drawing.Size(51, 26);
            this.unitTxtbox.TabIndex = 24;
            this.unitTxtbox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label11.Location = new System.Drawing.Point(261, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Unit:";
            // 
            // subdescTxtbox
            // 
            this.subdescTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subdescTxtbox.Location = new System.Drawing.Point(18, 96);
            this.subdescTxtbox.Multiline = true;
            this.subdescTxtbox.Name = "subdescTxtbox";
            this.subdescTxtbox.Size = new System.Drawing.Size(469, 124);
            this.subdescTxtbox.TabIndex = 22;
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
            // subcodeTxtbox
            // 
            this.subcodeTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subcodeTxtbox.Location = new System.Drawing.Point(18, 34);
            this.subcodeTxtbox.Name = "subcodeTxtbox";
            this.subcodeTxtbox.Size = new System.Drawing.Size(215, 26);
            this.subcodeTxtbox.TabIndex = 20;
            // 
            // subjectLbl
            // 
            this.subjectLbl.AutoSize = true;
            this.subjectLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.subjectLbl.Location = new System.Drawing.Point(14, 11);
            this.subjectLbl.Name = "subjectLbl";
            this.subjectLbl.Size = new System.Drawing.Size(106, 20);
            this.subjectLbl.TabIndex = 19;
            this.subjectLbl.Text = "Subject code:";
            // 
            // addSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(559, 323);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addSubject";
            this.Text = "ADD NEW SUBJECT";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitTxtbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox subdescTxtbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox subcodeTxtbox;
        private System.Windows.Forms.Label subjectLbl;
        private System.Windows.Forms.NumericUpDown unitTxtbox;
        private System.Windows.Forms.Label label11;
    }
}