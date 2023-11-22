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
        DataClasses1DataContext db = new DataClasses1DataContext();
        private int adminId;
        public adminProfile(int adminId)
        {
            InitializeComponent();
            this.adminId = adminId;
            getAdmin();
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

        private void getAdmin()
        {
            var res = db.getAdmin(adminId).ToList();
            if (res != null && res.Any())
            {
                foreach (var item in res)
                {
                    fnameTxtbox.Text = item.admin_fname;
                    lnameTxtbox.Text = item.admin_lname;
                    miTxtbox.Text = item.admin_mi;
                    phone.Text = item.admin_phone;
                    emailtextBox.Text = item.admin_email;
                }
            }
        }
    }
}
