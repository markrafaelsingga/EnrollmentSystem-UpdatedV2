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
        public login()
        {
            InitializeComponent();
        }

        private void signinLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sign_in chooseUser = new sign_in();
            chooseUser.Show();
            Visible = false;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = emailTxtbox.Text;
            string pass = passwordTxtbox.Text;

            string emailAdmin = "admin";
            string passAdmin = "admin123";
            string emailStud = "student";
            string passStud = "student123";

            if (email == emailAdmin && pass == passAdmin)
            {
                admin_page dashboard = new admin_page();
                dashboard.Show();
                Visible = false;
            }
            else if (email == emailAdmin && pass != passAdmin)
            {
                MessageBox.Show("Wrong password", "Can't login");
            }
            else if (email == emailStud && pass == passStud)
            {
                student_page dashboard = new student_page();
                dashboard.Show();
                Visible = false;
            } 
            else if (email == emailStud && pass != passStud)
            {
                MessageBox.Show("Wrong password", "Can't login");
            }
            else
            {
                MessageBox.Show("Account not found", "Error");
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
