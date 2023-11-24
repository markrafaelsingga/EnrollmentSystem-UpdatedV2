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
    public partial class faceRecognition : Form
    {
        private int adminId;
        public faceRecognition(int adminId)
        {
            InitializeComponent();
            this.adminId = adminId;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            admin_page dashboard = new admin_page(adminId);
            dashboard.FormClosed += Dashboard_FormClosed;
            dashboard.Show();
            Visible = false;
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            login log = new login();
            log.Show();
            Visible = false;
        }
    }
}