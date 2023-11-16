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
    public partial class login : Form
    {

        private int id;
        private int studId;
        public login()
        {
            InitializeComponent();
            this.id = id;
            this.studId = studId;
        }


        DataClasses1DataContext db = new DataClasses1DataContext();
        private void signinLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signIn_student chooseUser = new signIn_student();
            chooseUser.Show();
            Visible = false;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string user = uname.Text;
            string pass = pword.Text;

            var verId = db.logId(uname.Text, pword.Text).ToList();
            var sId = db.studId(uname.Text, pword.Text).ToList();
            
            if (verId != null && verId.Any())
            {
                foreach (var item in verId)
                {
                    int id = item.admin_id;                   
                    if (id > 0)
                    {
                        admin_page dashboard = new admin_page(id);
                        dashboard.Show();
                        Visible = false;
                        
                    }
                    else 
                    {
                        MessageBox.Show("WRONG KA BOGO", "UNDANG SKWELA!");
                    }
                }
            }
            else if (sId != null && sId.Any())
            {
                foreach (var items in sId)
                {
                    studId = items.stud_id;
                    if (studId > 0)
                    {
                        student_page dashboard = new student_page(studId);
                        dashboard.Show();
                        Visible = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("WALAY SULOD OI!", "UNDANG SKWELA!");
            }
         

        }

        private void loginBtn_MouseHover(object sender, EventArgs e)
        {
            loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
        }

        private void loginBtn_MouseLeave(object sender, EventArgs e)
        {
            loginBtn.BackColor = System.Drawing.Color.White;
        }

        private void signinLink_MouseHover(object sender, EventArgs e)
        {
            signinLink.LinkColor = System.Drawing.Color.Red;
        }

        private void signinLink_MouseLeave(object sender, EventArgs e)
        {
            signinLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
        }

        private void forgotpassLink_MouseHover(object sender, EventArgs e)
        {
            forgotpassLink.LinkColor = System.Drawing.Color.Red;
        }

        private void forgotpassLink_MouseLeave(object sender, EventArgs e)
        {
            forgotpassLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
        }
    }
}