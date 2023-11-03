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
    public partial class signIn_admin : Form
    {
        public signIn_admin()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            sign_in back_to = new sign_in();
            back_to.Show();
            Visible = false;
        }

        private void signinBtn_Click(object sender, EventArgs e)
        {
            login back_login = new login();
            back_login.Show();
            Visible = false;
        }
        
    }
}
