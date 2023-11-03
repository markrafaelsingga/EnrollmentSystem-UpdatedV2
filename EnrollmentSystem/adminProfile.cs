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
    public partial class adminProfile : Form
    {
        public adminProfile()
        {
            InitializeComponent();
        }

        private void adminProfile_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void edit_MouseHover(object sender, EventArgs e)
        {
            edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(131)))), ((int)(((byte)(179)))));
        }

        private void edit_MouseLeave(object sender, EventArgs e)
        {
            edit.BackColor = System.Drawing.Color.White;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            updateProfile adminprofile = new updateProfile();
            adminprofile.ShowDialog();
        }
    }
}
