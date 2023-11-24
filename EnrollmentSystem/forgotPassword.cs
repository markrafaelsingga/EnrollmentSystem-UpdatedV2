﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrollmentSystem
{
    public partial class forgotPassword : Form
    {
        public forgotPassword()
        {
            InitializeComponent();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            changePassword change = new changePassword();
            change.FormClosed += Change_FormClosed;
            change.Show();
            Visible = false;
        }

        private void Change_FormClosed(object sender, FormClosedEventArgs e)
        {
            login log = new login();
            log.Show();
            Visible = false;
        }

        private void nextBtn_MouseHover(object sender, EventArgs e)
        {
            nextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
        }

        private void nextBtn_MouseLeave(object sender, EventArgs e)
        {
            nextBtn.BackColor = System.Drawing.Color.White;
        }
    }
}
