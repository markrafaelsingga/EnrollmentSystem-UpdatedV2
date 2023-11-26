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

        private void getAdmin()
        {
            var res = db.admins.ToList();
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
