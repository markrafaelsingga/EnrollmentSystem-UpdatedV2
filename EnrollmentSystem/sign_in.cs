using System;
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
    public partial class sign_in : Form
    {
        public sign_in()
        {
            InitializeComponent();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            signIn_admin as_admin = new signIn_admin();
            as_admin.Show();
            Visible = false;
        }

        private void studentBtn_Click(object sender, EventArgs e)
        {
            signIn_student as_student = new signIn_student();
            as_student.Show();
            Visible = false;
        }

        private void back2Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login back_login = new login();
            back_login.Show();
            Visible = false;
        }
    }
}
