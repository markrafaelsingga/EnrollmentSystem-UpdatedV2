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
    public partial class deleteStudent : Form
    {
        public deleteStudent()
        {
            InitializeComponent();
        }
        private void deleteBtn_MouseHover(object sender, EventArgs e)
        {
            deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
        }

        private void deleteBtn_MouseLeave(object sender, EventArgs e)
        {
            deleteBtn.BackColor = System.Drawing.Color.White;
        }

        private void search_MouseHover(object sender, EventArgs e)
        {
            search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
        }

        private void search_MouseLeave(object sender, EventArgs e)
        {
            search.BackColor = System.Drawing.Color.White;
        }
        
    }
}
